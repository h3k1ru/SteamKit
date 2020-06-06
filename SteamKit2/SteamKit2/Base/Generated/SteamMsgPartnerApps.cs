// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_partnerapps.steamclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_RequestUploadToken_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string filename
        {
            get { return __pbn__filename ?? ""; }
            set { __pbn__filename = value; }
        }
        public bool ShouldSerializefilename() => __pbn__filename != null;
        public void Resetfilename() => __pbn__filename = null;
        private string __pbn__filename;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_RequestUploadToken_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong upload_token
        {
            get { return __pbn__upload_token.GetValueOrDefault(); }
            set { __pbn__upload_token = value; }
        }
        public bool ShouldSerializeupload_token() => __pbn__upload_token != null;
        public void Resetupload_token() => __pbn__upload_token = null;
        private ulong? __pbn__upload_token;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string location
        {
            get { return __pbn__location ?? ""; }
            set { __pbn__location = value; }
        }
        public bool ShouldSerializelocation() => __pbn__location != null;
        public void Resetlocation() => __pbn__location = null;
        private string __pbn__location;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong routing_id
        {
            get { return __pbn__routing_id.GetValueOrDefault(); }
            set { __pbn__routing_id = value; }
        }
        public bool ShouldSerializerouting_id() => __pbn__routing_id != null;
        public void Resetrouting_id() => __pbn__routing_id = null;
        private ulong? __pbn__routing_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FinishUpload_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong upload_token
        {
            get { return __pbn__upload_token.GetValueOrDefault(); }
            set { __pbn__upload_token = value; }
        }
        public bool ShouldSerializeupload_token() => __pbn__upload_token != null;
        public void Resetupload_token() => __pbn__upload_token = null;
        private ulong? __pbn__upload_token;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong routing_id
        {
            get { return __pbn__routing_id.GetValueOrDefault(); }
            set { __pbn__routing_id = value; }
        }
        public bool ShouldSerializerouting_id() => __pbn__routing_id != null;
        public void Resetrouting_id() => __pbn__routing_id = null;
        private ulong? __pbn__routing_id;

        [global::ProtoBuf.ProtoMember(3)]
        public uint app_id
        {
            get { return __pbn__app_id.GetValueOrDefault(); }
            set { __pbn__app_id = value; }
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FinishUploadKVSign_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string signed_installscript
        {
            get { return __pbn__signed_installscript ?? ""; }
            set { __pbn__signed_installscript = value; }
        }
        public bool ShouldSerializesigned_installscript() => __pbn__signed_installscript != null;
        public void Resetsigned_installscript() => __pbn__signed_installscript = null;
        private string __pbn__signed_installscript;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FinishUploadLegacyDRM_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong upload_token
        {
            get { return __pbn__upload_token.GetValueOrDefault(); }
            set { __pbn__upload_token = value; }
        }
        public bool ShouldSerializeupload_token() => __pbn__upload_token != null;
        public void Resetupload_token() => __pbn__upload_token = null;
        private ulong? __pbn__upload_token;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong routing_id
        {
            get { return __pbn__routing_id.GetValueOrDefault(); }
            set { __pbn__routing_id = value; }
        }
        public bool ShouldSerializerouting_id() => __pbn__routing_id != null;
        public void Resetrouting_id() => __pbn__routing_id = null;
        private ulong? __pbn__routing_id;

        [global::ProtoBuf.ProtoMember(3)]
        public uint app_id
        {
            get { return __pbn__app_id.GetValueOrDefault(); }
            set { __pbn__app_id = value; }
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

        [global::ProtoBuf.ProtoMember(4)]
        public uint flags
        {
            get { return __pbn__flags.GetValueOrDefault(); }
            set { __pbn__flags = value; }
        }
        public bool ShouldSerializeflags() => __pbn__flags != null;
        public void Resetflags() => __pbn__flags = null;
        private uint? __pbn__flags;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tool_name
        {
            get { return __pbn__tool_name ?? ""; }
            set { __pbn__tool_name = value; }
        }
        public bool ShouldSerializetool_name() => __pbn__tool_name != null;
        public void Resettool_name() => __pbn__tool_name = null;
        private string __pbn__tool_name;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FinishUploadLegacyDRM_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string file_id
        {
            get { return __pbn__file_id ?? ""; }
            set { __pbn__file_id = value; }
        }
        public bool ShouldSerializefile_id() => __pbn__file_id != null;
        public void Resetfile_id() => __pbn__file_id = null;
        private string __pbn__file_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FinishUpload_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FinishUploadDepot_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong upload_token
        {
            get { return __pbn__upload_token.GetValueOrDefault(); }
            set { __pbn__upload_token = value; }
        }
        public bool ShouldSerializeupload_token() => __pbn__upload_token != null;
        public void Resetupload_token() => __pbn__upload_token = null;
        private ulong? __pbn__upload_token;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong routing_id
        {
            get { return __pbn__routing_id.GetValueOrDefault(); }
            set { __pbn__routing_id = value; }
        }
        public bool ShouldSerializerouting_id() => __pbn__routing_id != null;
        public void Resetrouting_id() => __pbn__routing_id = null;
        private ulong? __pbn__routing_id;

        [global::ProtoBuf.ProtoMember(3)]
        public uint app_id
        {
            get { return __pbn__app_id.GetValueOrDefault(); }
            set { __pbn__app_id = value; }
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

        [global::ProtoBuf.ProtoMember(4)]
        public uint depot_id
        {
            get { return __pbn__depot_id.GetValueOrDefault(); }
            set { __pbn__depot_id = value; }
        }
        public bool ShouldSerializedepot_id() => __pbn__depot_id != null;
        public void Resetdepot_id() => __pbn__depot_id = null;
        private uint? __pbn__depot_id;

        [global::ProtoBuf.ProtoMember(5)]
        public uint build_flags
        {
            get { return __pbn__build_flags.GetValueOrDefault(); }
            set { __pbn__build_flags = value; }
        }
        public bool ShouldSerializebuild_flags() => __pbn__build_flags != null;
        public void Resetbuild_flags() => __pbn__build_flags = null;
        private uint? __pbn__build_flags;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FinishUploadDepot_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_GetDepotBuildResult_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong upload_token
        {
            get { return __pbn__upload_token.GetValueOrDefault(); }
            set { __pbn__upload_token = value; }
        }
        public bool ShouldSerializeupload_token() => __pbn__upload_token != null;
        public void Resetupload_token() => __pbn__upload_token = null;
        private ulong? __pbn__upload_token;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong routing_id
        {
            get { return __pbn__routing_id.GetValueOrDefault(); }
            set { __pbn__routing_id = value; }
        }
        public bool ShouldSerializerouting_id() => __pbn__routing_id != null;
        public void Resetrouting_id() => __pbn__routing_id = null;
        private ulong? __pbn__routing_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_GetDepotBuildResult_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong manifest_id
        {
            get { return __pbn__manifest_id.GetValueOrDefault(); }
            set { __pbn__manifest_id = value; }
        }
        public bool ShouldSerializemanifest_id() => __pbn__manifest_id != null;
        public void Resetmanifest_id() => __pbn__manifest_id = null;
        private ulong? __pbn__manifest_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string error_msg
        {
            get { return __pbn__error_msg ?? ""; }
            set { __pbn__error_msg = value; }
        }
        public bool ShouldSerializeerror_msg() => __pbn__error_msg != null;
        public void Reseterror_msg() => __pbn__error_msg = null;
        private string __pbn__error_msg;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FindDRMUploads_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int app_id
        {
            get { return __pbn__app_id.GetValueOrDefault(); }
            set { __pbn__app_id = value; }
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private int? __pbn__app_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_ExistingDRMUpload : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string file_id
        {
            get { return __pbn__file_id ?? ""; }
            set { __pbn__file_id = value; }
        }
        public bool ShouldSerializefile_id() => __pbn__file_id != null;
        public void Resetfile_id() => __pbn__file_id = null;
        private string __pbn__file_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint app_id
        {
            get { return __pbn__app_id.GetValueOrDefault(); }
            set { __pbn__app_id = value; }
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private uint? __pbn__app_id;

        [global::ProtoBuf.ProtoMember(3)]
        public int actor_id
        {
            get { return __pbn__actor_id.GetValueOrDefault(); }
            set { __pbn__actor_id = value; }
        }
        public bool ShouldSerializeactor_id() => __pbn__actor_id != null;
        public void Resetactor_id() => __pbn__actor_id = null;
        private int? __pbn__actor_id;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string supplied_name
        {
            get { return __pbn__supplied_name ?? ""; }
            set { __pbn__supplied_name = value; }
        }
        public bool ShouldSerializesupplied_name() => __pbn__supplied_name != null;
        public void Resetsupplied_name() => __pbn__supplied_name = null;
        private string __pbn__supplied_name;

        [global::ProtoBuf.ProtoMember(6)]
        public uint flags
        {
            get { return __pbn__flags.GetValueOrDefault(); }
            set { __pbn__flags = value; }
        }
        public bool ShouldSerializeflags() => __pbn__flags != null;
        public void Resetflags() => __pbn__flags = null;
        private uint? __pbn__flags;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string mod_type
        {
            get { return __pbn__mod_type ?? ""; }
            set { __pbn__mod_type = value; }
        }
        public bool ShouldSerializemod_type() => __pbn__mod_type != null;
        public void Resetmod_type() => __pbn__mod_type = null;
        private string __pbn__mod_type;

        [global::ProtoBuf.ProtoMember(8, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint timestamp
        {
            get { return __pbn__timestamp.GetValueOrDefault(); }
            set { __pbn__timestamp = value; }
        }
        public bool ShouldSerializetimestamp() => __pbn__timestamp != null;
        public void Resettimestamp() => __pbn__timestamp = null;
        private uint? __pbn__timestamp;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string orig_file_id
        {
            get { return __pbn__orig_file_id ?? ""; }
            set { __pbn__orig_file_id = value; }
        }
        public bool ShouldSerializeorig_file_id() => __pbn__orig_file_id != null;
        public void Resetorig_file_id() => __pbn__orig_file_id = null;
        private string __pbn__orig_file_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_FindDRMUploads_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CPartnerApps_ExistingDRMUpload> uploads { get; } = new global::System.Collections.Generic.List<CPartnerApps_ExistingDRMUpload>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_Download_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string file_id
        {
            get { return __pbn__file_id ?? ""; }
            set { __pbn__file_id = value; }
        }
        public bool ShouldSerializefile_id() => __pbn__file_id != null;
        public void Resetfile_id() => __pbn__file_id = null;
        private string __pbn__file_id;

        [global::ProtoBuf.ProtoMember(2)]
        public int app_id
        {
            get { return __pbn__app_id.GetValueOrDefault(); }
            set { __pbn__app_id = value; }
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private int? __pbn__app_id;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPartnerApps_Download_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string download_url
        {
            get { return __pbn__download_url ?? ""; }
            set { __pbn__download_url = value; }
        }
        public bool ShouldSerializedownload_url() => __pbn__download_url != null;
        public void Resetdownload_url() => __pbn__download_url = null;
        private string __pbn__download_url;

        [global::ProtoBuf.ProtoMember(2)]
        public int app_id
        {
            get { return __pbn__app_id.GetValueOrDefault(); }
            set { __pbn__app_id = value; }
        }
        public bool ShouldSerializeapp_id() => __pbn__app_id != null;
        public void Resetapp_id() => __pbn__app_id = null;
        private int? __pbn__app_id;

    }

    public interface IPartnerApps
    {
        CPartnerApps_RequestUploadToken_Response RequestKVSignUploadToken(CPartnerApps_RequestUploadToken_Request request);
        CPartnerApps_RequestUploadToken_Response RequestDRMUploadToken(CPartnerApps_RequestUploadToken_Request request);
        CPartnerApps_RequestUploadToken_Response RequestCEGUploadToken(CPartnerApps_RequestUploadToken_Request request);
        CPartnerApps_RequestUploadToken_Response RequestDepotUploadToken(CPartnerApps_RequestUploadToken_Request request);
        CPartnerApps_FinishUploadKVSign_Response FinishUploadKVSign(CPartnerApps_FinishUpload_Request request);
        CPartnerApps_FinishUploadLegacyDRM_Response FinishUploadDRMUpload(CPartnerApps_FinishUploadLegacyDRM_Request request);
        CPartnerApps_FinishUpload_Response FinishUploadCEGUpload(CPartnerApps_FinishUpload_Request request);
        CPartnerApps_FinishUploadDepot_Response FinishUploadDepotUpload(CPartnerApps_FinishUploadDepot_Request request);
        CPartnerApps_GetDepotBuildResult_Response GetDepotBuildResult(CPartnerApps_GetDepotBuildResult_Request request);
        CPartnerApps_FindDRMUploads_Response FindDRMUploads(CPartnerApps_FindDRMUploads_Request request);
        CPartnerApps_Download_Response Download(CPartnerApps_Download_Request request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
