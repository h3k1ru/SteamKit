// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_store.steamclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Unified.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CStore_GetLocalizedNameForTags_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string language
        {
            get { return __pbn__language ?? ""; }
            set { __pbn__language = value; }
        }
        public bool ShouldSerializelanguage() => __pbn__language != null;
        public void Resetlanguage() => __pbn__language = null;
        private string __pbn__language;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<uint> tagids { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStore_GetLocalizedNameForTags_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Tag> tags { get; } = new global::System.Collections.Generic.List<Tag>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Tag : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint tagid
            {
                get { return __pbn__tagid.GetValueOrDefault(); }
                set { __pbn__tagid = value; }
            }
            public bool ShouldSerializetagid() => __pbn__tagid != null;
            public void Resettagid() => __pbn__tagid = null;
            private uint? __pbn__tagid;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string english_name
            {
                get { return __pbn__english_name ?? ""; }
                set { __pbn__english_name = value; }
            }
            public bool ShouldSerializeenglish_name() => __pbn__english_name != null;
            public void Resetenglish_name() => __pbn__english_name = null;
            private string __pbn__english_name;

            [global::ProtoBuf.ProtoMember(3)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get { return __pbn__name ?? ""; }
                set { __pbn__name = value; }
            }
            public bool ShouldSerializename() => __pbn__name != null;
            public void Resetname() => __pbn__name = null;
            private string __pbn__name;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStore_GetStorePreferences_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStore_UserPreferences : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint primary_language
        {
            get { return __pbn__primary_language.GetValueOrDefault(); }
            set { __pbn__primary_language = value; }
        }
        public bool ShouldSerializeprimary_language() => __pbn__primary_language != null;
        public void Resetprimary_language() => __pbn__primary_language = null;
        private uint? __pbn__primary_language;

        [global::ProtoBuf.ProtoMember(2)]
        public uint secondary_languages
        {
            get { return __pbn__secondary_languages.GetValueOrDefault(); }
            set { __pbn__secondary_languages = value; }
        }
        public bool ShouldSerializesecondary_languages() => __pbn__secondary_languages != null;
        public void Resetsecondary_languages() => __pbn__secondary_languages = null;
        private uint? __pbn__secondary_languages;

        [global::ProtoBuf.ProtoMember(3)]
        public bool platform_windows
        {
            get { return __pbn__platform_windows.GetValueOrDefault(); }
            set { __pbn__platform_windows = value; }
        }
        public bool ShouldSerializeplatform_windows() => __pbn__platform_windows != null;
        public void Resetplatform_windows() => __pbn__platform_windows = null;
        private bool? __pbn__platform_windows;

        [global::ProtoBuf.ProtoMember(4)]
        public bool platform_mac
        {
            get { return __pbn__platform_mac.GetValueOrDefault(); }
            set { __pbn__platform_mac = value; }
        }
        public bool ShouldSerializeplatform_mac() => __pbn__platform_mac != null;
        public void Resetplatform_mac() => __pbn__platform_mac = null;
        private bool? __pbn__platform_mac;

        [global::ProtoBuf.ProtoMember(5)]
        public bool platform_linux
        {
            get { return __pbn__platform_linux.GetValueOrDefault(); }
            set { __pbn__platform_linux = value; }
        }
        public bool ShouldSerializeplatform_linux() => __pbn__platform_linux != null;
        public void Resetplatform_linux() => __pbn__platform_linux = null;
        private bool? __pbn__platform_linux;

        [global::ProtoBuf.ProtoMember(6)]
        public bool hide_adult_content_violence
        {
            get { return __pbn__hide_adult_content_violence.GetValueOrDefault(); }
            set { __pbn__hide_adult_content_violence = value; }
        }
        public bool ShouldSerializehide_adult_content_violence() => __pbn__hide_adult_content_violence != null;
        public void Resethide_adult_content_violence() => __pbn__hide_adult_content_violence = null;
        private bool? __pbn__hide_adult_content_violence;

        [global::ProtoBuf.ProtoMember(7)]
        public bool hide_adult_content_sex
        {
            get { return __pbn__hide_adult_content_sex.GetValueOrDefault(); }
            set { __pbn__hide_adult_content_sex = value; }
        }
        public bool ShouldSerializehide_adult_content_sex() => __pbn__hide_adult_content_sex != null;
        public void Resethide_adult_content_sex() => __pbn__hide_adult_content_sex = null;
        private bool? __pbn__hide_adult_content_sex;

        [global::ProtoBuf.ProtoMember(8)]
        public uint timestamp_updated
        {
            get { return __pbn__timestamp_updated.GetValueOrDefault(); }
            set { __pbn__timestamp_updated = value; }
        }
        public bool ShouldSerializetimestamp_updated() => __pbn__timestamp_updated != null;
        public void Resettimestamp_updated() => __pbn__timestamp_updated = null;
        private uint? __pbn__timestamp_updated;

        [global::ProtoBuf.ProtoMember(9)]
        public bool hide_store_broadcast
        {
            get { return __pbn__hide_store_broadcast.GetValueOrDefault(); }
            set { __pbn__hide_store_broadcast = value; }
        }
        public bool ShouldSerializehide_store_broadcast() => __pbn__hide_store_broadcast != null;
        public void Resethide_store_broadcast() => __pbn__hide_store_broadcast = null;
        private bool? __pbn__hide_store_broadcast;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(EUserReviewScorePreference.k_EUserReviewScorePreference_Unset)]
        public EUserReviewScorePreference review_score_preference
        {
            get { return __pbn__review_score_preference ?? EUserReviewScorePreference.k_EUserReviewScorePreference_Unset; }
            set { __pbn__review_score_preference = value; }
        }
        public bool ShouldSerializereview_score_preference() => __pbn__review_score_preference != null;
        public void Resetreview_score_preference() => __pbn__review_score_preference = null;
        private EUserReviewScorePreference? __pbn__review_score_preference;

        [global::ProtoBuf.ProtoMember(11)]
        public int timestamp_content_descriptor_preferences_updated
        {
            get { return __pbn__timestamp_content_descriptor_preferences_updated.GetValueOrDefault(); }
            set { __pbn__timestamp_content_descriptor_preferences_updated = value; }
        }
        public bool ShouldSerializetimestamp_content_descriptor_preferences_updated() => __pbn__timestamp_content_descriptor_preferences_updated != null;
        public void Resettimestamp_content_descriptor_preferences_updated() => __pbn__timestamp_content_descriptor_preferences_updated = null;
        private int? __pbn__timestamp_content_descriptor_preferences_updated;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStore_UserTagPreferences : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Tag> tags_to_exclude { get; } = new global::System.Collections.Generic.List<Tag>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Tag : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint tagid
            {
                get { return __pbn__tagid.GetValueOrDefault(); }
                set { __pbn__tagid = value; }
            }
            public bool ShouldSerializetagid() => __pbn__tagid != null;
            public void Resettagid() => __pbn__tagid = null;
            private uint? __pbn__tagid;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get { return __pbn__name ?? ""; }
                set { __pbn__name = value; }
            }
            public bool ShouldSerializename() => __pbn__name != null;
            public void Resetname() => __pbn__name = null;
            private string __pbn__name;

            [global::ProtoBuf.ProtoMember(3)]
            public uint timestamp_added
            {
                get { return __pbn__timestamp_added.GetValueOrDefault(); }
                set { __pbn__timestamp_added = value; }
            }
            public bool ShouldSerializetimestamp_added() => __pbn__timestamp_added != null;
            public void Resettimestamp_added() => __pbn__timestamp_added = null;
            private uint? __pbn__timestamp_added;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStore_UserContentDescriptorPreferences : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ContentDescriptor> content_descriptors_to_exclude { get; } = new global::System.Collections.Generic.List<ContentDescriptor>();

        [global::ProtoBuf.ProtoContract()]
        public partial class ContentDescriptor : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint content_descriptorid
            {
                get { return __pbn__content_descriptorid.GetValueOrDefault(); }
                set { __pbn__content_descriptorid = value; }
            }
            public bool ShouldSerializecontent_descriptorid() => __pbn__content_descriptorid != null;
            public void Resetcontent_descriptorid() => __pbn__content_descriptorid = null;
            private uint? __pbn__content_descriptorid;

            [global::ProtoBuf.ProtoMember(2)]
            public uint timestamp_added
            {
                get { return __pbn__timestamp_added.GetValueOrDefault(); }
                set { __pbn__timestamp_added = value; }
            }
            public bool ShouldSerializetimestamp_added() => __pbn__timestamp_added != null;
            public void Resettimestamp_added() => __pbn__timestamp_added = null;
            private uint? __pbn__timestamp_added;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStore_GetStorePreferences_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CStore_UserPreferences preferences { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public CStore_UserTagPreferences tag_preferences { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public CStore_UserContentDescriptorPreferences content_descriptor_preferences { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CStore_StorePreferencesChanged_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CStore_UserPreferences preferences { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public CStore_UserTagPreferences tag_preferences { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public CStore_UserContentDescriptorPreferences content_descriptor_preferences { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EUserReviewScorePreference
    {
        k_EUserReviewScorePreference_Unset = 0,
        k_EUserReviewScorePreference_IncludeAll = 1,
        k_EUserReviewScorePreference_ExcludeBombs = 2,
    }

    public interface IStore
    {
        CStore_GetLocalizedNameForTags_Response GetLocalizedNameForTags(CStore_GetLocalizedNameForTags_Request request);
        CStore_GetStorePreferences_Response GetStorePreferences(CStore_GetStorePreferences_Request request);
    }

    public interface IStoreClient
    {
        NoResponse NotifyStorePreferencesChanged(CStore_StorePreferencesChanged_Notification request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
