// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: loyaltystore.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CQuest_CommunityItem : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong communityitemid
        {
            get { return __pbn__communityitemid.GetValueOrDefault(); }
            set { __pbn__communityitemid = value; }
        }
        public bool ShouldSerializecommunityitemid() => __pbn__communityitemid != null;
        public void Resetcommunityitemid() => __pbn__communityitemid = null;
        private ulong? __pbn__communityitemid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint item_type
        {
            get { return __pbn__item_type.GetValueOrDefault(); }
            set { __pbn__item_type = value; }
        }
        public bool ShouldSerializeitem_type() => __pbn__item_type != null;
        public void Resetitem_type() => __pbn__item_type = null;
        private uint? __pbn__item_type;

        [global::ProtoBuf.ProtoMember(3)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(4)]
        public uint owner
        {
            get { return __pbn__owner.GetValueOrDefault(); }
            set { __pbn__owner = value; }
        }
        public bool ShouldSerializeowner() => __pbn__owner != null;
        public void Resetowner() => __pbn__owner = null;
        private uint? __pbn__owner;

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<CQuest_CommunityItem_Attribute> attributes { get; } = new global::System.Collections.Generic.List<CQuest_CommunityItem_Attribute>();

        [global::ProtoBuf.ProtoMember(6)]
        public bool used
        {
            get { return __pbn__used.GetValueOrDefault(); }
            set { __pbn__used = value; }
        }
        public bool ShouldSerializeused() => __pbn__used != null;
        public void Resetused() => __pbn__used = null;
        private bool? __pbn__used;

        [global::ProtoBuf.ProtoMember(7)]
        public uint owner_origin
        {
            get { return __pbn__owner_origin.GetValueOrDefault(); }
            set { __pbn__owner_origin = value; }
        }
        public bool ShouldSerializeowner_origin() => __pbn__owner_origin != null;
        public void Resetowner_origin() => __pbn__owner_origin = null;
        private uint? __pbn__owner_origin;

        [global::ProtoBuf.ProtoMember(8)]
        public long amount
        {
            get { return __pbn__amount.GetValueOrDefault(); }
            set { __pbn__amount = value; }
        }
        public bool ShouldSerializeamount() => __pbn__amount != null;
        public void Resetamount() => __pbn__amount = null;
        private long? __pbn__amount;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQuest_CommunityItem_Attribute : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint attributeid
        {
            get { return __pbn__attributeid.GetValueOrDefault(); }
            set { __pbn__attributeid = value; }
        }
        public bool ShouldSerializeattributeid() => __pbn__attributeid != null;
        public void Resetattributeid() => __pbn__attributeid = null;
        private uint? __pbn__attributeid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong value
        {
            get { return __pbn__value.GetValueOrDefault(); }
            set { __pbn__value = value; }
        }
        public bool ShouldSerializevalue() => __pbn__value != null;
        public void Resetvalue() => __pbn__value = null;
        private ulong? __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQuest_GetCommunityInventory_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<uint> filter_appids { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQuest_GetCommunityInventory_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CQuest_CommunityItem> items { get; } = new global::System.Collections.Generic.List<CQuest_CommunityItem>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQuest_GetCommunityItemDefinitions_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CQuest_GetCommunityItemDefinitions_Response_ItemDefinition> item_definitions { get; } = new global::System.Collections.Generic.List<CQuest_GetCommunityItemDefinitions_Response_ItemDefinition>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQuest_GetCommunityItemDefinitions_Response_ItemDefinition : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint item_type
        {
            get { return __pbn__item_type.GetValueOrDefault(); }
            set { __pbn__item_type = value; }
        }
        public bool ShouldSerializeitem_type() => __pbn__item_type != null;
        public void Resetitem_type() => __pbn__item_type = null;
        private uint? __pbn__item_type;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_name
        {
            get { return __pbn__item_name ?? ""; }
            set { __pbn__item_name = value; }
        }
        public bool ShouldSerializeitem_name() => __pbn__item_name != null;
        public void Resetitem_name() => __pbn__item_name = null;
        private string __pbn__item_name;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_title
        {
            get { return __pbn__item_title ?? ""; }
            set { __pbn__item_title = value; }
        }
        public bool ShouldSerializeitem_title() => __pbn__item_title != null;
        public void Resetitem_title() => __pbn__item_title = null;
        private string __pbn__item_title;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_description
        {
            get { return __pbn__item_description ?? ""; }
            set { __pbn__item_description = value; }
        }
        public bool ShouldSerializeitem_description() => __pbn__item_description != null;
        public void Resetitem_description() => __pbn__item_description = null;
        private string __pbn__item_description;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_image_small
        {
            get { return __pbn__item_image_small ?? ""; }
            set { __pbn__item_image_small = value; }
        }
        public bool ShouldSerializeitem_image_small() => __pbn__item_image_small != null;
        public void Resetitem_image_small() => __pbn__item_image_small = null;
        private string __pbn__item_image_small;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_image_large
        {
            get { return __pbn__item_image_large ?? ""; }
            set { __pbn__item_image_large = value; }
        }
        public bool ShouldSerializeitem_image_large() => __pbn__item_image_large != null;
        public void Resetitem_image_large() => __pbn__item_image_large = null;
        private string __pbn__item_image_large;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_key_values
        {
            get { return __pbn__item_key_values ?? ""; }
            set { __pbn__item_key_values = value; }
        }
        public bool ShouldSerializeitem_key_values() => __pbn__item_key_values != null;
        public void Resetitem_key_values() => __pbn__item_key_values = null;
        private string __pbn__item_key_values;

        [global::ProtoBuf.ProtoMember(9)]
        public uint item_series
        {
            get { return __pbn__item_series.GetValueOrDefault(); }
            set { __pbn__item_series = value; }
        }
        public bool ShouldSerializeitem_series() => __pbn__item_series != null;
        public void Resetitem_series() => __pbn__item_series = null;
        private uint? __pbn__item_series;

        [global::ProtoBuf.ProtoMember(10)]
        public uint item_class
        {
            get { return __pbn__item_class.GetValueOrDefault(); }
            set { __pbn__item_class = value; }
        }
        public bool ShouldSerializeitem_class() => __pbn__item_class != null;
        public void Resetitem_class() => __pbn__item_class = null;
        private uint? __pbn__item_class;

        [global::ProtoBuf.ProtoMember(11)]
        public uint editor_accountid
        {
            get { return __pbn__editor_accountid.GetValueOrDefault(); }
            set { __pbn__editor_accountid = value; }
        }
        public bool ShouldSerializeeditor_accountid() => __pbn__editor_accountid != null;
        public void Reseteditor_accountid() => __pbn__editor_accountid = null;
        private uint? __pbn__editor_accountid;

        [global::ProtoBuf.ProtoMember(12)]
        public bool active
        {
            get { return __pbn__active.GetValueOrDefault(); }
            set { __pbn__active = value; }
        }
        public bool ShouldSerializeactive() => __pbn__active != null;
        public void Resetactive() => __pbn__active = null;
        private bool? __pbn__active;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_image_composed
        {
            get { return __pbn__item_image_composed ?? ""; }
            set { __pbn__item_image_composed = value; }
        }
        public bool ShouldSerializeitem_image_composed() => __pbn__item_image_composed != null;
        public void Resetitem_image_composed() => __pbn__item_image_composed = null;
        private string __pbn__item_image_composed;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_image_composed_foil
        {
            get { return __pbn__item_image_composed_foil ?? ""; }
            set { __pbn__item_image_composed_foil = value; }
        }
        public bool ShouldSerializeitem_image_composed_foil() => __pbn__item_image_composed_foil != null;
        public void Resetitem_image_composed_foil() => __pbn__item_image_composed_foil = null;
        private string __pbn__item_image_composed_foil;

        [global::ProtoBuf.ProtoMember(15)]
        public bool deleted
        {
            get { return __pbn__deleted.GetValueOrDefault(); }
            set { __pbn__deleted = value; }
        }
        public bool ShouldSerializedeleted() => __pbn__deleted != null;
        public void Resetdeleted() => __pbn__deleted = null;
        private bool? __pbn__deleted;

        [global::ProtoBuf.ProtoMember(16)]
        public uint item_last_changed
        {
            get { return __pbn__item_last_changed.GetValueOrDefault(); }
            set { __pbn__item_last_changed = value; }
        }
        public bool ShouldSerializeitem_last_changed() => __pbn__item_last_changed != null;
        public void Resetitem_last_changed() => __pbn__item_last_changed = null;
        private uint? __pbn__item_last_changed;

        [global::ProtoBuf.ProtoMember(17)]
        public ulong broadcast_channel_id
        {
            get { return __pbn__broadcast_channel_id.GetValueOrDefault(); }
            set { __pbn__broadcast_channel_id = value; }
        }
        public bool ShouldSerializebroadcast_channel_id() => __pbn__broadcast_channel_id != null;
        public void Resetbroadcast_channel_id() => __pbn__broadcast_channel_id = null;
        private ulong? __pbn__broadcast_channel_id;

        [global::ProtoBuf.ProtoMember(18)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_movie_webm
        {
            get { return __pbn__item_movie_webm ?? ""; }
            set { __pbn__item_movie_webm = value; }
        }
        public bool ShouldSerializeitem_movie_webm() => __pbn__item_movie_webm != null;
        public void Resetitem_movie_webm() => __pbn__item_movie_webm = null;
        private string __pbn__item_movie_webm;

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_movie_mp4
        {
            get { return __pbn__item_movie_mp4 ?? ""; }
            set { __pbn__item_movie_mp4 = value; }
        }
        public bool ShouldSerializeitem_movie_mp4() => __pbn__item_movie_mp4 != null;
        public void Resetitem_movie_mp4() => __pbn__item_movie_mp4 = null;
        private string __pbn__item_movie_mp4;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQuest_ActivateProfileModifierItem_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong communityitemid
        {
            get { return __pbn__communityitemid.GetValueOrDefault(); }
            set { __pbn__communityitemid = value; }
        }
        public bool ShouldSerializecommunityitemid() => __pbn__communityitemid != null;
        public void Resetcommunityitemid() => __pbn__communityitemid = null;
        private ulong? __pbn__communityitemid;

        [global::ProtoBuf.ProtoMember(3)]
        public bool activate
        {
            get { return __pbn__activate.GetValueOrDefault(); }
            set { __pbn__activate = value; }
        }
        public bool ShouldSerializeactivate() => __pbn__activate != null;
        public void Resetactivate() => __pbn__activate = null;
        private bool? __pbn__activate;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQuest_ActivateProfileModifierItem_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CSummerSale2020_ClaimItem_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CSummerSale2020_ClaimItem_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_name
        {
            get { return __pbn__item_name ?? ""; }
            set { __pbn__item_name = value; }
        }
        public bool ShouldSerializeitem_name() => __pbn__item_name != null;
        public void Resetitem_name() => __pbn__item_name = null;
        private string __pbn__item_name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_title
        {
            get { return __pbn__item_title ?? ""; }
            set { __pbn__item_title = value; }
        }
        public bool ShouldSerializeitem_title() => __pbn__item_title != null;
        public void Resetitem_title() => __pbn__item_title = null;
        private string __pbn__item_title;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_description
        {
            get { return __pbn__item_description ?? ""; }
            set { __pbn__item_description = value; }
        }
        public bool ShouldSerializeitem_description() => __pbn__item_description != null;
        public void Resetitem_description() => __pbn__item_description = null;
        private string __pbn__item_description;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_image_small
        {
            get { return __pbn__item_image_small ?? ""; }
            set { __pbn__item_image_small = value; }
        }
        public bool ShouldSerializeitem_image_small() => __pbn__item_image_small != null;
        public void Resetitem_image_small() => __pbn__item_image_small = null;
        private string __pbn__item_image_small;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_image_large
        {
            get { return __pbn__item_image_large ?? ""; }
            set { __pbn__item_image_large = value; }
        }
        public bool ShouldSerializeitem_image_large() => __pbn__item_image_large != null;
        public void Resetitem_image_large() => __pbn__item_image_large = null;
        private string __pbn__item_image_large;

        [global::ProtoBuf.ProtoMember(6)]
        public bool animated
        {
            get { return __pbn__animated.GetValueOrDefault(); }
            set { __pbn__animated = value; }
        }
        public bool ShouldSerializeanimated() => __pbn__animated != null;
        public void Resetanimated() => __pbn__animated = null;
        private bool? __pbn__animated;

        [global::ProtoBuf.ProtoMember(7)]
        public ulong communityitemid
        {
            get { return __pbn__communityitemid.GetValueOrDefault(); }
            set { __pbn__communityitemid = value; }
        }
        public bool ShouldSerializecommunityitemid() => __pbn__communityitemid != null;
        public void Resetcommunityitemid() => __pbn__communityitemid = null;
        private ulong? __pbn__communityitemid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CSummerSale2020_CanClaimItem_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CSummerSale2020_CanClaimItem_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool can_claim
        {
            get { return __pbn__can_claim.GetValueOrDefault(); }
            set { __pbn__can_claim = value; }
        }
        public bool ShouldSerializecan_claim() => __pbn__can_claim != null;
        public void Resetcan_claim() => __pbn__can_claim = null;
        private bool? __pbn__can_claim;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPlayer_GetFavoriteBadge_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool has_favorite_badge
        {
            get { return __pbn__has_favorite_badge.GetValueOrDefault(); }
            set { __pbn__has_favorite_badge = value; }
        }
        public bool ShouldSerializehas_favorite_badge() => __pbn__has_favorite_badge != null;
        public void Resethas_favorite_badge() => __pbn__has_favorite_badge = null;
        private bool? __pbn__has_favorite_badge;

        [global::ProtoBuf.ProtoMember(2)]
        public uint badgeid
        {
            get { return __pbn__badgeid.GetValueOrDefault(); }
            set { __pbn__badgeid = value; }
        }
        public bool ShouldSerializebadgeid() => __pbn__badgeid != null;
        public void Resetbadgeid() => __pbn__badgeid = null;
        private uint? __pbn__badgeid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong communityitemid
        {
            get { return __pbn__communityitemid.GetValueOrDefault(); }
            set { __pbn__communityitemid = value; }
        }
        public bool ShouldSerializecommunityitemid() => __pbn__communityitemid != null;
        public void Resetcommunityitemid() => __pbn__communityitemid = null;
        private ulong? __pbn__communityitemid;

        [global::ProtoBuf.ProtoMember(4)]
        public uint item_type
        {
            get { return __pbn__item_type.GetValueOrDefault(); }
            set { __pbn__item_type = value; }
        }
        public bool ShouldSerializeitem_type() => __pbn__item_type != null;
        public void Resetitem_type() => __pbn__item_type = null;
        private uint? __pbn__item_type;

        [global::ProtoBuf.ProtoMember(5)]
        public uint border_color
        {
            get { return __pbn__border_color.GetValueOrDefault(); }
            set { __pbn__border_color = value; }
        }
        public bool ShouldSerializeborder_color() => __pbn__border_color != null;
        public void Resetborder_color() => __pbn__border_color = null;
        private uint? __pbn__border_color;

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
        public uint level
        {
            get { return __pbn__level.GetValueOrDefault(); }
            set { __pbn__level = value; }
        }
        public bool ShouldSerializelevel() => __pbn__level != null;
        public void Resetlevel() => __pbn__level = null;
        private uint? __pbn__level;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPlayer_SetFavoriteBadge_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProfileCustomizationSlot : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint slot
        {
            get { return __pbn__slot.GetValueOrDefault(); }
            set { __pbn__slot = value; }
        }
        public bool ShouldSerializeslot() => __pbn__slot != null;
        public void Resetslot() => __pbn__slot = null;
        private uint? __pbn__slot;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong publishedfileid
        {
            get { return __pbn__publishedfileid.GetValueOrDefault(); }
            set { __pbn__publishedfileid = value; }
        }
        public bool ShouldSerializepublishedfileid() => __pbn__publishedfileid != null;
        public void Resetpublishedfileid() => __pbn__publishedfileid = null;
        private ulong? __pbn__publishedfileid;

        [global::ProtoBuf.ProtoMember(4)]
        public ulong item_assetid
        {
            get { return __pbn__item_assetid.GetValueOrDefault(); }
            set { __pbn__item_assetid = value; }
        }
        public bool ShouldSerializeitem_assetid() => __pbn__item_assetid != null;
        public void Resetitem_assetid() => __pbn__item_assetid = null;
        private ulong? __pbn__item_assetid;

        [global::ProtoBuf.ProtoMember(5)]
        public ulong item_contextid
        {
            get { return __pbn__item_contextid.GetValueOrDefault(); }
            set { __pbn__item_contextid = value; }
        }
        public bool ShouldSerializeitem_contextid() => __pbn__item_contextid != null;
        public void Resetitem_contextid() => __pbn__item_contextid = null;
        private ulong? __pbn__item_contextid;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string notes
        {
            get { return __pbn__notes ?? ""; }
            set { __pbn__notes = value; }
        }
        public bool ShouldSerializenotes() => __pbn__notes != null;
        public void Resetnotes() => __pbn__notes = null;
        private string __pbn__notes;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string title
        {
            get { return __pbn__title ?? ""; }
            set { __pbn__title = value; }
        }
        public bool ShouldSerializetitle() => __pbn__title != null;
        public void Resettitle() => __pbn__title = null;
        private string __pbn__title;

        [global::ProtoBuf.ProtoMember(8)]
        public uint accountid
        {
            get { return __pbn__accountid.GetValueOrDefault(); }
            set { __pbn__accountid = value; }
        }
        public bool ShouldSerializeaccountid() => __pbn__accountid != null;
        public void Resetaccountid() => __pbn__accountid = null;
        private uint? __pbn__accountid;

        [global::ProtoBuf.ProtoMember(9)]
        public uint badgeid
        {
            get { return __pbn__badgeid.GetValueOrDefault(); }
            set { __pbn__badgeid = value; }
        }
        public bool ShouldSerializebadgeid() => __pbn__badgeid != null;
        public void Resetbadgeid() => __pbn__badgeid = null;
        private uint? __pbn__badgeid;

        [global::ProtoBuf.ProtoMember(10)]
        public uint border_color
        {
            get { return __pbn__border_color.GetValueOrDefault(); }
            set { __pbn__border_color = value; }
        }
        public bool ShouldSerializeborder_color() => __pbn__border_color != null;
        public void Resetborder_color() => __pbn__border_color = null;
        private uint? __pbn__border_color;

        [global::ProtoBuf.ProtoMember(11)]
        public ulong item_classid
        {
            get { return __pbn__item_classid.GetValueOrDefault(); }
            set { __pbn__item_classid = value; }
        }
        public bool ShouldSerializeitem_classid() => __pbn__item_classid != null;
        public void Resetitem_classid() => __pbn__item_classid = null;
        private ulong? __pbn__item_classid;

        [global::ProtoBuf.ProtoMember(12)]
        public ulong item_instanceid
        {
            get { return __pbn__item_instanceid.GetValueOrDefault(); }
            set { __pbn__item_instanceid = value; }
        }
        public bool ShouldSerializeitem_instanceid() => __pbn__item_instanceid != null;
        public void Resetitem_instanceid() => __pbn__item_instanceid = null;
        private ulong? __pbn__item_instanceid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProfileCustomization : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int customization_type
        {
            get { return __pbn__customization_type.GetValueOrDefault(); }
            set { __pbn__customization_type = value; }
        }
        public bool ShouldSerializecustomization_type() => __pbn__customization_type != null;
        public void Resetcustomization_type() => __pbn__customization_type = null;
        private int? __pbn__customization_type;

        [global::ProtoBuf.ProtoMember(2)]
        public bool large
        {
            get { return __pbn__large.GetValueOrDefault(); }
            set { __pbn__large = value; }
        }
        public bool ShouldSerializelarge() => __pbn__large != null;
        public void Resetlarge() => __pbn__large = null;
        private bool? __pbn__large;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<ProfileCustomizationSlot> slots { get; } = new global::System.Collections.Generic.List<ProfileCustomizationSlot>();

        [global::ProtoBuf.ProtoMember(4)]
        public bool active
        {
            get { return __pbn__active.GetValueOrDefault(); }
            set { __pbn__active = value; }
        }
        public bool ShouldSerializeactive() => __pbn__active != null;
        public void Resetactive() => __pbn__active = null;
        private bool? __pbn__active;

        [global::ProtoBuf.ProtoMember(5)]
        public int customization_style
        {
            get { return __pbn__customization_style.GetValueOrDefault(); }
            set { __pbn__customization_style = value; }
        }
        public bool ShouldSerializecustomization_style() => __pbn__customization_style != null;
        public void Resetcustomization_style() => __pbn__customization_style = null;
        private int? __pbn__customization_style;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProfileTheme : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string theme_id
        {
            get { return __pbn__theme_id ?? ""; }
            set { __pbn__theme_id = value; }
        }
        public bool ShouldSerializetheme_id() => __pbn__theme_id != null;
        public void Resettheme_id() => __pbn__theme_id = null;
        private string __pbn__theme_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string title
        {
            get { return __pbn__title ?? ""; }
            set { __pbn__title = value; }
        }
        public bool ShouldSerializetitle() => __pbn__title != null;
        public void Resettitle() => __pbn__title = null;
        private string __pbn__title;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPlayer_GetProfileCustomization_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ProfileCustomization> customizations { get; } = new global::System.Collections.Generic.List<ProfileCustomization>();

        [global::ProtoBuf.ProtoMember(2)]
        public uint slots_available
        {
            get { return __pbn__slots_available.GetValueOrDefault(); }
            set { __pbn__slots_available = value; }
        }
        public bool ShouldSerializeslots_available() => __pbn__slots_available != null;
        public void Resetslots_available() => __pbn__slots_available = null;
        private uint? __pbn__slots_available;

        [global::ProtoBuf.ProtoMember(3)]
        public ProfileTheme profile_theme { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPlayer_GetProfileThemesAvailable_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ProfileTheme> profile_themes { get; } = new global::System.Collections.Generic.List<ProfileTheme>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CPlayer_SetProfileTheme_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NotImplemented : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    public interface IQuest
    {
        CQuest_GetCommunityInventory_Response GetCommunityInventory(CQuest_GetCommunityInventory_Request request);
        CQuest_GetCommunityItemDefinitions_Response GetCommunityItemDefinitions(NotImplemented request);
        CQuest_ActivateProfileModifierItem_Response ActivateProfileModifierItem(CQuest_ActivateProfileModifierItem_Request request);
    }

    public interface ISummerSale2020
    {
        CSummerSale2020_ClaimItem_Response ClaimItem(CSummerSale2020_ClaimItem_Request request);
        CSummerSale2020_CanClaimItem_Response CanClaimItem(CSummerSale2020_CanClaimItem_Request request);
    }

    public partial interface IPlayer
    {
        CPlayer_GetFavoriteBadge_Response GetFavoriteBadge(NotImplemented request);
        CPlayer_SetFavoriteBadge_Response SetFavoriteBadge(NotImplemented request);
        CPlayer_GetProfileCustomization_Response GetProfileCustomization(NotImplemented request);
        CPlayer_GetProfileThemesAvailable_Response GetProfileThemesAvailable(NotImplemented request);
        CPlayer_SetProfileTheme_Response SetProfileTheme(NotImplemented request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
