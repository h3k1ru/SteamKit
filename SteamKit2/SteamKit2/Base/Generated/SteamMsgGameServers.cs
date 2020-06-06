// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_gameservers.steamclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameServers_GetServerList_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string filter
        {
            get { return __pbn__filter ?? ""; }
            set { __pbn__filter = value; }
        }
        public bool ShouldSerializefilter() => __pbn__filter != null;
        public void Resetfilter() => __pbn__filter = null;
        private string __pbn__filter;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(100)]
        public uint limit
        {
            get { return __pbn__limit ?? 100; }
            set { __pbn__limit = value; }
        }
        public bool ShouldSerializelimit() => __pbn__limit != null;
        public void Resetlimit() => __pbn__limit = null;
        private uint? __pbn__limit;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameServers_GetServerList_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Server> servers { get; } = new global::System.Collections.Generic.List<Server>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Server : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string addr
            {
                get { return __pbn__addr ?? ""; }
                set { __pbn__addr = value; }
            }
            public bool ShouldSerializeaddr() => __pbn__addr != null;
            public void Resetaddr() => __pbn__addr = null;
            private string __pbn__addr;

            [global::ProtoBuf.ProtoMember(2)]
            public uint gameport
            {
                get { return __pbn__gameport.GetValueOrDefault(); }
                set { __pbn__gameport = value; }
            }
            public bool ShouldSerializegameport() => __pbn__gameport != null;
            public void Resetgameport() => __pbn__gameport = null;
            private uint? __pbn__gameport;

            [global::ProtoBuf.ProtoMember(3)]
            public uint specport
            {
                get { return __pbn__specport.GetValueOrDefault(); }
                set { __pbn__specport = value; }
            }
            public bool ShouldSerializespecport() => __pbn__specport != null;
            public void Resetspecport() => __pbn__specport = null;
            private uint? __pbn__specport;

            [global::ProtoBuf.ProtoMember(4, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            public ulong steamid
            {
                get { return __pbn__steamid.GetValueOrDefault(); }
                set { __pbn__steamid = value; }
            }
            public bool ShouldSerializesteamid() => __pbn__steamid != null;
            public void Resetsteamid() => __pbn__steamid = null;
            private ulong? __pbn__steamid;

            [global::ProtoBuf.ProtoMember(5)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get { return __pbn__name ?? ""; }
                set { __pbn__name = value; }
            }
            public bool ShouldSerializename() => __pbn__name != null;
            public void Resetname() => __pbn__name = null;
            private string __pbn__name;

            [global::ProtoBuf.ProtoMember(6)]
            public uint appid
            {
                get { return __pbn__appid.GetValueOrDefault(); }
                set { __pbn__appid = value; }
            }
            public bool ShouldSerializeappid() => __pbn__appid != null;
            public void Resetappid() => __pbn__appid = null;
            private uint? __pbn__appid;

            [global::ProtoBuf.ProtoMember(7)]
            [global::System.ComponentModel.DefaultValue("")]
            public string gamedir
            {
                get { return __pbn__gamedir ?? ""; }
                set { __pbn__gamedir = value; }
            }
            public bool ShouldSerializegamedir() => __pbn__gamedir != null;
            public void Resetgamedir() => __pbn__gamedir = null;
            private string __pbn__gamedir;

            [global::ProtoBuf.ProtoMember(8)]
            [global::System.ComponentModel.DefaultValue("")]
            public string version
            {
                get { return __pbn__version ?? ""; }
                set { __pbn__version = value; }
            }
            public bool ShouldSerializeversion() => __pbn__version != null;
            public void Resetversion() => __pbn__version = null;
            private string __pbn__version;

            [global::ProtoBuf.ProtoMember(9)]
            [global::System.ComponentModel.DefaultValue("")]
            public string product
            {
                get { return __pbn__product ?? ""; }
                set { __pbn__product = value; }
            }
            public bool ShouldSerializeproduct() => __pbn__product != null;
            public void Resetproduct() => __pbn__product = null;
            private string __pbn__product;

            [global::ProtoBuf.ProtoMember(10)]
            public int region
            {
                get { return __pbn__region.GetValueOrDefault(); }
                set { __pbn__region = value; }
            }
            public bool ShouldSerializeregion() => __pbn__region != null;
            public void Resetregion() => __pbn__region = null;
            private int? __pbn__region;

            [global::ProtoBuf.ProtoMember(11)]
            public int players
            {
                get { return __pbn__players.GetValueOrDefault(); }
                set { __pbn__players = value; }
            }
            public bool ShouldSerializeplayers() => __pbn__players != null;
            public void Resetplayers() => __pbn__players = null;
            private int? __pbn__players;

            [global::ProtoBuf.ProtoMember(12)]
            public int max_players
            {
                get { return __pbn__max_players.GetValueOrDefault(); }
                set { __pbn__max_players = value; }
            }
            public bool ShouldSerializemax_players() => __pbn__max_players != null;
            public void Resetmax_players() => __pbn__max_players = null;
            private int? __pbn__max_players;

            [global::ProtoBuf.ProtoMember(13)]
            public int bots
            {
                get { return __pbn__bots.GetValueOrDefault(); }
                set { __pbn__bots = value; }
            }
            public bool ShouldSerializebots() => __pbn__bots != null;
            public void Resetbots() => __pbn__bots = null;
            private int? __pbn__bots;

            [global::ProtoBuf.ProtoMember(14)]
            [global::System.ComponentModel.DefaultValue("")]
            public string map
            {
                get { return __pbn__map ?? ""; }
                set { __pbn__map = value; }
            }
            public bool ShouldSerializemap() => __pbn__map != null;
            public void Resetmap() => __pbn__map = null;
            private string __pbn__map;

            [global::ProtoBuf.ProtoMember(15)]
            public bool secure
            {
                get { return __pbn__secure.GetValueOrDefault(); }
                set { __pbn__secure = value; }
            }
            public bool ShouldSerializesecure() => __pbn__secure != null;
            public void Resetsecure() => __pbn__secure = null;
            private bool? __pbn__secure;

            [global::ProtoBuf.ProtoMember(16)]
            public bool dedicated
            {
                get { return __pbn__dedicated.GetValueOrDefault(); }
                set { __pbn__dedicated = value; }
            }
            public bool ShouldSerializededicated() => __pbn__dedicated != null;
            public void Resetdedicated() => __pbn__dedicated = null;
            private bool? __pbn__dedicated;

            [global::ProtoBuf.ProtoMember(17)]
            [global::System.ComponentModel.DefaultValue("")]
            public string os
            {
                get { return __pbn__os ?? ""; }
                set { __pbn__os = value; }
            }
            public bool ShouldSerializeos() => __pbn__os != null;
            public void Resetos() => __pbn__os = null;
            private string __pbn__os;

            [global::ProtoBuf.ProtoMember(18)]
            [global::System.ComponentModel.DefaultValue("")]
            public string gametype
            {
                get { return __pbn__gametype ?? ""; }
                set { __pbn__gametype = value; }
            }
            public bool ShouldSerializegametype() => __pbn__gametype != null;
            public void Resetgametype() => __pbn__gametype = null;
            private string __pbn__gametype;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameServers_GetServerSteamIDsByIP_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<string> server_ips { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameServers_IPsWithSteamIDs_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Server> servers { get; } = new global::System.Collections.Generic.List<Server>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Server : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string addr
            {
                get { return __pbn__addr ?? ""; }
                set { __pbn__addr = value; }
            }
            public bool ShouldSerializeaddr() => __pbn__addr != null;
            public void Resetaddr() => __pbn__addr = null;
            private string __pbn__addr;

            [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            public ulong steamid
            {
                get { return __pbn__steamid.GetValueOrDefault(); }
                set { __pbn__steamid = value; }
            }
            public bool ShouldSerializesteamid() => __pbn__steamid != null;
            public void Resetsteamid() => __pbn__steamid = null;
            private ulong? __pbn__steamid;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CGameServers_GetServerIPsBySteamID_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public global::System.Collections.Generic.List<ulong> server_steamids { get; } = new global::System.Collections.Generic.List<ulong>();

    }

    public interface IGameServers
    {
        CGameServers_GetServerList_Response GetServerList(CGameServers_GetServerList_Request request);
        CGameServers_IPsWithSteamIDs_Response GetServerSteamIDsByIP(CGameServers_GetServerSteamIDsByIP_Request request);
        CGameServers_IPsWithSteamIDs_Response GetServerIPsBySteamID(CGameServers_GetServerIPsBySteamID_Request request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
