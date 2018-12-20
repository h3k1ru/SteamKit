using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using SteamKit2.Util;
using SteamKit2.Util.MacHelpers;
using Microsoft.Win32;

using static SteamKit2.Util.MacHelpers.LibC;
using static SteamKit2.Util.MacHelpers.CoreFoundation;
using static SteamKit2.Util.MacHelpers.DiskArbitration;
using static SteamKit2.Util.MacHelpers.IOKit;

namespace SteamKit2
{
    abstract class MachineInfoProvider
    {
        public static MachineInfoProvider GetProvider(bool randomInfoProvider = false)
        {
            if (randomInfoProvider) {
                return new RandomInfoProvider();
            }
            return new DefaultInfoProvider();
        }

        public abstract byte[] GetMachineGuid();
        public abstract byte[] GetMacAddress();
        public abstract byte[] GetDiskId();
    }

    class RandomInfoProvider : MachineInfoProvider {
        readonly Random Random = new Random();
        public override byte[] GetMachineGuid() => GenerateRandomBytes();
        public override byte[] GetDiskId() => GenerateRandomBytes();
        public override byte[] GetMacAddress() => GenerateRandomBytes();

        byte[] GenerateRandomBytes() {
            byte[] buffer = new byte[32];
            Random.NextBytes(buffer);
            return buffer;
        }
    }

    class DefaultInfoProvider : MachineInfoProvider
    {
        private string random_string(int string_length) {
            using(var rng = new RNGCryptoServiceProvider()) {
                var bit_count = (string_length * 6);
                var byte_count = ((bit_count + 7) / 8); // rounded up
                var bytes = new byte[byte_count];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }

        public override byte[] GetMachineGuid()
        {
            return Encoding.UTF8.GetBytes(random_string(24));
        }

        public override byte[] GetMacAddress()
        {
            return Encoding.UTF8.GetBytes(random_string(24));
        }

        public override byte[] GetDiskId()
        {
            return Encoding.UTF8.GetBytes(random_string(24));
        }
    }

    /// <summary>
    /// Generator of the random machine ID
    /// </summary>
    public static class RandomHardwareInfoGenerator {
        public static string GenerateRandomMachineID() => HardwareUtils.GenerateRandomMachineID();
    }

    static class HardwareUtils
    {
        class MachineID : MessageObject
        {
            public MachineID()
                : base()
            {
                this.KeyValues["BB3"] = new KeyValue();
                this.KeyValues["FF2"] = new KeyValue();
                this.KeyValues["3B3"] = new KeyValue();
            }


            public void SetBB3( string value )
            {
                this.KeyValues["BB3"].Value = value;
            }

            public void SetFF2( string value )
            {
                this.KeyValues["FF2"].Value = value;
            }

            public void Set3B3( string value )
            {
                this.KeyValues["3B3"].Value = value;
            }

            public void Set333( string value )
            {
                this.KeyValues["333"] = new KeyValue( value: value );
            }
        }

        public static string GenerateRandomMachineID() {


            var machineId = new MachineID();

            MachineInfoProvider provider = new RandomInfoProvider();



            machineId.SetBB3( GetHexString( provider.GetMachineGuid() ) );
            machineId.SetFF2( GetHexString( provider.GetMacAddress() ) );
            machineId.Set3B3( GetHexString( provider.GetDiskId() ) );

            // 333 is some sort of user supplied data and is currently unused

            byte[] buffer;
            using ( MemoryStream ms = new MemoryStream() )
            {
                machineId.WriteToStream( ms );

                buffer = ms.ToArray();
            }

            return Convert.ToBase64String(buffer);
        }

        public static byte[] GenerateMachineID()
        {
            // the aug 25th 2015 CM update made well-formed machine MessageObjects required for logon
            // this was flipped off shortly after the update rolled out, likely due to linux steamclients running on distros without a way to build a machineid
            // so while a valid MO isn't currently (as of aug 25th) required, they could be in the future and we'll abide by The Valve Law now

            var machineId = new MachineID();

			using ( var ms = new MemoryStream() )
			{
				MachineInfoProvider provider = MachineInfoProvider.GetProvider();

				machineId.SetBB3( GetHexString( provider.GetMachineGuid() ) );
				machineId.SetFF2( GetHexString( provider.GetMacAddress() ) );
				machineId.Set3B3( GetHexString( provider.GetDiskId() ) );

				// 333 is some sort of user supplied data and is currently unused

				machineId.WriteToStream( ms );
				return ms.ToArray();
			}
        }

        static string GetHexString( byte[] data )
        {
            data = CryptoHelper.SHAHash( data );

            return BitConverter.ToString( data )
                .Replace( "-", "" )
                .ToLower();
        }
    }
}
