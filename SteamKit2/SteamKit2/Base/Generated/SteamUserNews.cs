// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: usernews.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserNews_GetUserNews_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint count
        {
            get { return __pbn__count.GetValueOrDefault(); }
            set { __pbn__count = value; }
        }
        public bool ShouldSerializecount() => __pbn__count != null;
        public void Resetcount() => __pbn__count = null;
        private uint? __pbn__count;

        [global::ProtoBuf.ProtoMember(2)]
        public uint starttime
        {
            get { return __pbn__starttime.GetValueOrDefault(); }
            set { __pbn__starttime = value; }
        }
        public bool ShouldSerializestarttime() => __pbn__starttime != null;
        public void Resetstarttime() => __pbn__starttime = null;
        private uint? __pbn__starttime;

        [global::ProtoBuf.ProtoMember(3)]
        public uint endtime
        {
            get { return __pbn__endtime.GetValueOrDefault(); }
            set { __pbn__endtime = value; }
        }
        public bool ShouldSerializeendtime() => __pbn__endtime != null;
        public void Resetendtime() => __pbn__endtime = null;
        private uint? __pbn__endtime;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string language
        {
            get { return __pbn__language ?? ""; }
            set { __pbn__language = value; }
        }
        public bool ShouldSerializelanguage() => __pbn__language != null;
        public void Resetlanguage() => __pbn__language = null;
        private string __pbn__language;

        [global::ProtoBuf.ProtoMember(5)]
        public uint filterflags
        {
            get { return __pbn__filterflags.GetValueOrDefault(); }
            set { __pbn__filterflags = value; }
        }
        public bool ShouldSerializefilterflags() => __pbn__filterflags != null;
        public void Resetfilterflags() => __pbn__filterflags = null;
        private uint? __pbn__filterflags;

        [global::ProtoBuf.ProtoMember(6)]
        public uint filterappid
        {
            get { return __pbn__filterappid.GetValueOrDefault(); }
            set { __pbn__filterappid = value; }
        }
        public bool ShouldSerializefilterappid() => __pbn__filterappid != null;
        public void Resetfilterappid() => __pbn__filterappid = null;
        private uint? __pbn__filterappid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserNews_GetUserNews_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CUserNews_Event> news { get; } = new global::System.Collections.Generic.List<CUserNews_Event>();

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<CUserNewsAchievementDisplayData> achievement_display_data { get; } = new global::System.Collections.Generic.List<CUserNewsAchievementDisplayData>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserNews_Event : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint eventtype
        {
            get { return __pbn__eventtype.GetValueOrDefault(); }
            set { __pbn__eventtype = value; }
        }
        public bool ShouldSerializeeventtype() => __pbn__eventtype != null;
        public void Reseteventtype() => __pbn__eventtype = null;
        private uint? __pbn__eventtype;

        [global::ProtoBuf.ProtoMember(2)]
        public uint eventtime
        {
            get { return __pbn__eventtime.GetValueOrDefault(); }
            set { __pbn__eventtime = value; }
        }
        public bool ShouldSerializeeventtime() => __pbn__eventtime != null;
        public void Reseteventtime() => __pbn__eventtime = null;
        private uint? __pbn__eventtime;

        [global::ProtoBuf.ProtoMember(3, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid_actor
        {
            get { return __pbn__steamid_actor.GetValueOrDefault(); }
            set { __pbn__steamid_actor = value; }
        }
        public bool ShouldSerializesteamid_actor() => __pbn__steamid_actor != null;
        public void Resetsteamid_actor() => __pbn__steamid_actor = null;
        private ulong? __pbn__steamid_actor;

        [global::ProtoBuf.ProtoMember(4, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid_target
        {
            get { return __pbn__steamid_target.GetValueOrDefault(); }
            set { __pbn__steamid_target = value; }
        }
        public bool ShouldSerializesteamid_target() => __pbn__steamid_target != null;
        public void Resetsteamid_target() => __pbn__steamid_target = null;
        private ulong? __pbn__steamid_target;

        [global::ProtoBuf.ProtoMember(5, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong gameid
        {
            get { return __pbn__gameid.GetValueOrDefault(); }
            set { __pbn__gameid = value; }
        }
        public bool ShouldSerializegameid() => __pbn__gameid != null;
        public void Resetgameid() => __pbn__gameid = null;
        private ulong? __pbn__gameid;

        [global::ProtoBuf.ProtoMember(6)]
        public uint packageid
        {
            get { return __pbn__packageid.GetValueOrDefault(); }
            set { __pbn__packageid = value; }
        }
        public bool ShouldSerializepackageid() => __pbn__packageid != null;
        public void Resetpackageid() => __pbn__packageid = null;
        private uint? __pbn__packageid;

        [global::ProtoBuf.ProtoMember(7)]
        public uint shortcutid
        {
            get { return __pbn__shortcutid.GetValueOrDefault(); }
            set { __pbn__shortcutid = value; }
        }
        public bool ShouldSerializeshortcutid() => __pbn__shortcutid != null;
        public void Resetshortcutid() => __pbn__shortcutid = null;
        private uint? __pbn__shortcutid;

        [global::ProtoBuf.ProtoMember(8)]
        public global::System.Collections.Generic.List<string> achievement_names { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(9, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong clan_eventid
        {
            get { return __pbn__clan_eventid.GetValueOrDefault(); }
            set { __pbn__clan_eventid = value; }
        }
        public bool ShouldSerializeclan_eventid() => __pbn__clan_eventid != null;
        public void Resetclan_eventid() => __pbn__clan_eventid = null;
        private ulong? __pbn__clan_eventid;

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong clan_announcementid
        {
            get { return __pbn__clan_announcementid.GetValueOrDefault(); }
            set { __pbn__clan_announcementid = value; }
        }
        public bool ShouldSerializeclan_announcementid() => __pbn__clan_announcementid != null;
        public void Resetclan_announcementid() => __pbn__clan_announcementid = null;
        private ulong? __pbn__clan_announcementid;

        [global::ProtoBuf.ProtoMember(11, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong publishedfileid
        {
            get { return __pbn__publishedfileid.GetValueOrDefault(); }
            set { __pbn__publishedfileid = value; }
        }
        public bool ShouldSerializepublishedfileid() => __pbn__publishedfileid != null;
        public void Resetpublishedfileid() => __pbn__publishedfileid = null;
        private ulong? __pbn__publishedfileid;

        [global::ProtoBuf.ProtoMember(12)]
        public uint event_last_mod_time
        {
            get { return __pbn__event_last_mod_time.GetValueOrDefault(); }
            set { __pbn__event_last_mod_time = value; }
        }
        public bool ShouldSerializeevent_last_mod_time() => __pbn__event_last_mod_time != null;
        public void Resetevent_last_mod_time() => __pbn__event_last_mod_time = null;
        private uint? __pbn__event_last_mod_time;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserNewsAchievementDisplayData : global::ProtoBuf.IExtensible
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
        public global::System.Collections.Generic.List<CUserNewsAchievementDisplayData_CAchievement> achievements { get; } = new global::System.Collections.Generic.List<CUserNewsAchievementDisplayData_CAchievement>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserNewsAchievementDisplayData_CAchievement : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename() => __pbn__name != null;
        public void Resetname() => __pbn__name = null;
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string display_name
        {
            get { return __pbn__display_name ?? ""; }
            set { __pbn__display_name = value; }
        }
        public bool ShouldSerializedisplay_name() => __pbn__display_name != null;
        public void Resetdisplay_name() => __pbn__display_name = null;
        private string __pbn__display_name;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string display_description
        {
            get { return __pbn__display_description ?? ""; }
            set { __pbn__display_description = value; }
        }
        public bool ShouldSerializedisplay_description() => __pbn__display_description != null;
        public void Resetdisplay_description() => __pbn__display_description = null;
        private string __pbn__display_description;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string icon
        {
            get { return __pbn__icon ?? ""; }
            set { __pbn__icon = value; }
        }
        public bool ShouldSerializeicon() => __pbn__icon != null;
        public void Reseticon() => __pbn__icon = null;
        private string __pbn__icon;

        [global::ProtoBuf.ProtoMember(5)]
        public float unlocked_pct
        {
            get { return __pbn__unlocked_pct.GetValueOrDefault(); }
            set { __pbn__unlocked_pct = value; }
        }
        public bool ShouldSerializeunlocked_pct() => __pbn__unlocked_pct != null;
        public void Resetunlocked_pct() => __pbn__unlocked_pct = null;
        private float? __pbn__unlocked_pct;

        [global::ProtoBuf.ProtoMember(6)]
        public bool hidden
        {
            get { return __pbn__hidden.GetValueOrDefault(); }
            set { __pbn__hidden = value; }
        }
        public bool ShouldSerializehidden() => __pbn__hidden != null;
        public void Resethidden() => __pbn__hidden = null;
        private bool? __pbn__hidden;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserNews_GetAppDetailsSpotlight_Request : global::ProtoBuf.IExtensible
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

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserNews_GetAppDetailsSpotlight_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CUserNews_GetAppDetailsSpotlight_Response_FeaturedEvent> events { get; } = new global::System.Collections.Generic.List<CUserNews_GetAppDetailsSpotlight_Response_FeaturedEvent>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserNews_GetAppDetailsSpotlight_Response_FeaturedEvent : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint event_type
        {
            get { return __pbn__event_type.GetValueOrDefault(); }
            set { __pbn__event_type = value; }
        }
        public bool ShouldSerializeevent_type() => __pbn__event_type != null;
        public void Resetevent_type() => __pbn__event_type = null;
        private uint? __pbn__event_type;

        [global::ProtoBuf.ProtoMember(2)]
        public uint event_time
        {
            get { return __pbn__event_time.GetValueOrDefault(); }
            set { __pbn__event_time = value; }
        }
        public bool ShouldSerializeevent_time() => __pbn__event_time != null;
        public void Resetevent_time() => __pbn__event_time = null;
        private uint? __pbn__event_time;

        [global::ProtoBuf.ProtoMember(3, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong clan_id
        {
            get { return __pbn__clan_id.GetValueOrDefault(); }
            set { __pbn__clan_id = value; }
        }
        public bool ShouldSerializeclan_id() => __pbn__clan_id != null;
        public void Resetclan_id() => __pbn__clan_id = null;
        private ulong? __pbn__clan_id;

        [global::ProtoBuf.ProtoMember(4, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong clan_announcementid
        {
            get { return __pbn__clan_announcementid.GetValueOrDefault(); }
            set { __pbn__clan_announcementid = value; }
        }
        public bool ShouldSerializeclan_announcementid() => __pbn__clan_announcementid != null;
        public void Resetclan_announcementid() => __pbn__clan_announcementid = null;
        private ulong? __pbn__clan_announcementid;

        [global::ProtoBuf.ProtoMember(5)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(6)]
        public uint rtime32_last_modified
        {
            get { return __pbn__rtime32_last_modified.GetValueOrDefault(); }
            set { __pbn__rtime32_last_modified = value; }
        }
        public bool ShouldSerializertime32_last_modified() => __pbn__rtime32_last_modified != null;
        public void Resetrtime32_last_modified() => __pbn__rtime32_last_modified = null;
        private uint? __pbn__rtime32_last_modified;

    }

    public interface IUserNews
    {
        CUserNews_GetUserNews_Response GetUserNews(CUserNews_GetUserNews_Request request);
        CUserNews_GetAppDetailsSpotlight_Response GetAppDetailsSpotlight(CUserNews_GetAppDetailsSpotlight_Request request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
