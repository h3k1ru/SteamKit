// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_useraccount.steamclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_GetAvailableValveDiscountPromotions_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string country_code
        {
            get { return __pbn__country_code ?? ""; }
            set { __pbn__country_code = value; }
        }
        public bool ShouldSerializecountry_code() => __pbn__country_code != null;
        public void Resetcountry_code() => __pbn__country_code = null;
        private string __pbn__country_code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_GetAvailableValveDiscountPromotions_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ValveDiscountPromotionDetails> promotions { get; } = new global::System.Collections.Generic.List<ValveDiscountPromotionDetails>();

        [global::ProtoBuf.ProtoContract()]
        public partial class ValveDiscountPromotionDetails : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint promotionid
            {
                get { return __pbn__promotionid.GetValueOrDefault(); }
                set { __pbn__promotionid = value; }
            }
            public bool ShouldSerializepromotionid() => __pbn__promotionid != null;
            public void Resetpromotionid() => __pbn__promotionid = null;
            private uint? __pbn__promotionid;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string promotion_description
            {
                get { return __pbn__promotion_description ?? ""; }
                set { __pbn__promotion_description = value; }
            }
            public bool ShouldSerializepromotion_description() => __pbn__promotion_description != null;
            public void Resetpromotion_description() => __pbn__promotion_description = null;
            private string __pbn__promotion_description;

            [global::ProtoBuf.ProtoMember(3)]
            public long minimum_cart_amount
            {
                get { return __pbn__minimum_cart_amount.GetValueOrDefault(); }
                set { __pbn__minimum_cart_amount = value; }
            }
            public bool ShouldSerializeminimum_cart_amount() => __pbn__minimum_cart_amount != null;
            public void Resetminimum_cart_amount() => __pbn__minimum_cart_amount = null;
            private long? __pbn__minimum_cart_amount;

            [global::ProtoBuf.ProtoMember(4)]
            public long minimum_cart_amount_for_display
            {
                get { return __pbn__minimum_cart_amount_for_display.GetValueOrDefault(); }
                set { __pbn__minimum_cart_amount_for_display = value; }
            }
            public bool ShouldSerializeminimum_cart_amount_for_display() => __pbn__minimum_cart_amount_for_display != null;
            public void Resetminimum_cart_amount_for_display() => __pbn__minimum_cart_amount_for_display = null;
            private long? __pbn__minimum_cart_amount_for_display;

            [global::ProtoBuf.ProtoMember(5)]
            public long discount_amount
            {
                get { return __pbn__discount_amount.GetValueOrDefault(); }
                set { __pbn__discount_amount = value; }
            }
            public bool ShouldSerializediscount_amount() => __pbn__discount_amount != null;
            public void Resetdiscount_amount() => __pbn__discount_amount = null;
            private long? __pbn__discount_amount;

            [global::ProtoBuf.ProtoMember(6)]
            public int currency_code
            {
                get { return __pbn__currency_code.GetValueOrDefault(); }
                set { __pbn__currency_code = value; }
            }
            public bool ShouldSerializecurrency_code() => __pbn__currency_code != null;
            public void Resetcurrency_code() => __pbn__currency_code = null;
            private int? __pbn__currency_code;

            [global::ProtoBuf.ProtoMember(7)]
            public int available_use_count
            {
                get { return __pbn__available_use_count.GetValueOrDefault(); }
                set { __pbn__available_use_count = value; }
            }
            public bool ShouldSerializeavailable_use_count() => __pbn__available_use_count != null;
            public void Resetavailable_use_count() => __pbn__available_use_count = null;
            private int? __pbn__available_use_count;

            [global::ProtoBuf.ProtoMember(8)]
            public int promotional_discount_type
            {
                get { return __pbn__promotional_discount_type.GetValueOrDefault(); }
                set { __pbn__promotional_discount_type = value; }
            }
            public bool ShouldSerializepromotional_discount_type() => __pbn__promotional_discount_type != null;
            public void Resetpromotional_discount_type() => __pbn__promotional_discount_type = null;
            private int? __pbn__promotional_discount_type;

            [global::ProtoBuf.ProtoMember(9)]
            public int loyalty_reward_id
            {
                get { return __pbn__loyalty_reward_id.GetValueOrDefault(); }
                set { __pbn__loyalty_reward_id = value; }
            }
            public bool ShouldSerializeloyalty_reward_id() => __pbn__loyalty_reward_id != null;
            public void Resetloyalty_reward_id() => __pbn__loyalty_reward_id = null;
            private int? __pbn__loyalty_reward_id;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_GetAccountLinkStatus_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_GetAccountLinkStatus_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint pwid
        {
            get { return __pbn__pwid.GetValueOrDefault(); }
            set { __pbn__pwid = value; }
        }
        public bool ShouldSerializepwid() => __pbn__pwid != null;
        public void Resetpwid() => __pbn__pwid = null;
        private uint? __pbn__pwid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint identity_verification
        {
            get { return __pbn__identity_verification.GetValueOrDefault(); }
            set { __pbn__identity_verification = value; }
        }
        public bool ShouldSerializeidentity_verification() => __pbn__identity_verification != null;
        public void Resetidentity_verification() => __pbn__identity_verification = null;
        private uint? __pbn__identity_verification;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_CancelLicenseForApp_Request : global::ProtoBuf.IExtensible
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
    public partial class CUserAccount_CancelLicenseForApp_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_CreateFriendInviteToken_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint invite_limit
        {
            get { return __pbn__invite_limit.GetValueOrDefault(); }
            set { __pbn__invite_limit = value; }
        }
        public bool ShouldSerializeinvite_limit() => __pbn__invite_limit != null;
        public void Resetinvite_limit() => __pbn__invite_limit = null;
        private uint? __pbn__invite_limit;

        [global::ProtoBuf.ProtoMember(2)]
        public uint invite_duration
        {
            get { return __pbn__invite_duration.GetValueOrDefault(); }
            set { __pbn__invite_duration = value; }
        }
        public bool ShouldSerializeinvite_duration() => __pbn__invite_duration != null;
        public void Resetinvite_duration() => __pbn__invite_duration = null;
        private uint? __pbn__invite_duration;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string invite_note
        {
            get { return __pbn__invite_note ?? ""; }
            set { __pbn__invite_note = value; }
        }
        public bool ShouldSerializeinvite_note() => __pbn__invite_note != null;
        public void Resetinvite_note() => __pbn__invite_note = null;
        private string __pbn__invite_note;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_CreateFriendInviteToken_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string invite_token
        {
            get { return __pbn__invite_token ?? ""; }
            set { __pbn__invite_token = value; }
        }
        public bool ShouldSerializeinvite_token() => __pbn__invite_token != null;
        public void Resetinvite_token() => __pbn__invite_token = null;
        private string __pbn__invite_token;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong invite_limit
        {
            get { return __pbn__invite_limit.GetValueOrDefault(); }
            set { __pbn__invite_limit = value; }
        }
        public bool ShouldSerializeinvite_limit() => __pbn__invite_limit != null;
        public void Resetinvite_limit() => __pbn__invite_limit = null;
        private ulong? __pbn__invite_limit;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong invite_duration
        {
            get { return __pbn__invite_duration.GetValueOrDefault(); }
            set { __pbn__invite_duration = value; }
        }
        public bool ShouldSerializeinvite_duration() => __pbn__invite_duration != null;
        public void Resetinvite_duration() => __pbn__invite_duration = null;
        private ulong? __pbn__invite_duration;

        [global::ProtoBuf.ProtoMember(4, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public uint time_created
        {
            get { return __pbn__time_created.GetValueOrDefault(); }
            set { __pbn__time_created = value; }
        }
        public bool ShouldSerializetime_created() => __pbn__time_created != null;
        public void Resettime_created() => __pbn__time_created = null;
        private uint? __pbn__time_created;

        [global::ProtoBuf.ProtoMember(5)]
        public bool valid
        {
            get { return __pbn__valid.GetValueOrDefault(); }
            set { __pbn__valid = value; }
        }
        public bool ShouldSerializevalid() => __pbn__valid != null;
        public void Resetvalid() => __pbn__valid = null;
        private bool? __pbn__valid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_GetFriendInviteTokens_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_GetFriendInviteTokens_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CUserAccount_CreateFriendInviteToken_Response> tokens { get; } = new global::System.Collections.Generic.List<CUserAccount_CreateFriendInviteToken_Response>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_ViewFriendInviteToken_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string invite_token
        {
            get { return __pbn__invite_token ?? ""; }
            set { __pbn__invite_token = value; }
        }
        public bool ShouldSerializeinvite_token() => __pbn__invite_token != null;
        public void Resetinvite_token() => __pbn__invite_token = null;
        private string __pbn__invite_token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_ViewFriendInviteToken_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool valid
        {
            get { return __pbn__valid.GetValueOrDefault(); }
            set { __pbn__valid = value; }
        }
        public bool ShouldSerializevalid() => __pbn__valid != null;
        public void Resetvalid() => __pbn__valid = null;
        private bool? __pbn__valid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong invite_duration
        {
            get { return __pbn__invite_duration.GetValueOrDefault(); }
            set { __pbn__invite_duration = value; }
        }
        public bool ShouldSerializeinvite_duration() => __pbn__invite_duration != null;
        public void Resetinvite_duration() => __pbn__invite_duration = null;
        private ulong? __pbn__invite_duration;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_RedeemFriendInviteToken_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string invite_token
        {
            get { return __pbn__invite_token ?? ""; }
            set { __pbn__invite_token = value; }
        }
        public bool ShouldSerializeinvite_token() => __pbn__invite_token != null;
        public void Resetinvite_token() => __pbn__invite_token = null;
        private string __pbn__invite_token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_RedeemFriendInviteToken_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_RevokeFriendInviteToken_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string invite_token
        {
            get { return __pbn__invite_token ?? ""; }
            set { __pbn__invite_token = value; }
        }
        public bool ShouldSerializeinvite_token() => __pbn__invite_token != null;
        public void Resetinvite_token() => __pbn__invite_token = null;
        private string __pbn__invite_token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_RevokeFriendInviteToken_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_RegisterCompatTool_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint compat_tool
        {
            get { return __pbn__compat_tool.GetValueOrDefault(); }
            set { __pbn__compat_tool = value; }
        }
        public bool ShouldSerializecompat_tool() => __pbn__compat_tool != null;
        public void Resetcompat_tool() => __pbn__compat_tool = null;
        private uint? __pbn__compat_tool;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CUserAccount_RegisterCompatTool_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountLinking_GetLinkedAccountInfo_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(EInternalAccountType.k_EInternalSteamAccountType)]
        public EInternalAccountType account_type
        {
            get { return __pbn__account_type ?? EInternalAccountType.k_EInternalSteamAccountType; }
            set { __pbn__account_type = value; }
        }
        public bool ShouldSerializeaccount_type() => __pbn__account_type != null;
        public void Resetaccount_type() => __pbn__account_type = null;
        private EInternalAccountType? __pbn__account_type;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong account_id
        {
            get { return __pbn__account_id.GetValueOrDefault(); }
            set { __pbn__account_id = value; }
        }
        public bool ShouldSerializeaccount_id() => __pbn__account_id != null;
        public void Resetaccount_id() => __pbn__account_id = null;
        private ulong? __pbn__account_id;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(EExternalAccountType.k_EExternalNone)]
        public EExternalAccountType filter
        {
            get { return __pbn__filter ?? EExternalAccountType.k_EExternalNone; }
            set { __pbn__filter = value; }
        }
        public bool ShouldSerializefilter() => __pbn__filter != null;
        public void Resetfilter() => __pbn__filter = null;
        private EExternalAccountType? __pbn__filter;

        [global::ProtoBuf.ProtoMember(4)]
        public bool return_access_token
        {
            get { return __pbn__return_access_token.GetValueOrDefault(); }
            set { __pbn__return_access_token = value; }
        }
        public bool ShouldSerializereturn_access_token() => __pbn__return_access_token != null;
        public void Resetreturn_access_token() => __pbn__return_access_token = null;
        private bool? __pbn__return_access_token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CAccountLinking_GetLinkedAccountInfo_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CExternalAccountTuple_Response> external_accounts { get; } = new global::System.Collections.Generic.List<CExternalAccountTuple_Response>();

        [global::ProtoBuf.ProtoContract()]
        public partial class CExternalAccountTuple_Response : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue(EExternalAccountType.k_EExternalNone)]
            public EExternalAccountType external_type
            {
                get { return __pbn__external_type ?? EExternalAccountType.k_EExternalNone; }
                set { __pbn__external_type = value; }
            }
            public bool ShouldSerializeexternal_type() => __pbn__external_type != null;
            public void Resetexternal_type() => __pbn__external_type = null;
            private EExternalAccountType? __pbn__external_type;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string external_id
            {
                get { return __pbn__external_id ?? ""; }
                set { __pbn__external_id = value; }
            }
            public bool ShouldSerializeexternal_id() => __pbn__external_id != null;
            public void Resetexternal_id() => __pbn__external_id = null;
            private string __pbn__external_id;

            [global::ProtoBuf.ProtoMember(3)]
            [global::System.ComponentModel.DefaultValue("")]
            public string external_user_name
            {
                get { return __pbn__external_user_name ?? ""; }
                set { __pbn__external_user_name = value; }
            }
            public bool ShouldSerializeexternal_user_name() => __pbn__external_user_name != null;
            public void Resetexternal_user_name() => __pbn__external_user_name = null;
            private string __pbn__external_user_name;

            [global::ProtoBuf.ProtoMember(4)]
            [global::System.ComponentModel.DefaultValue("")]
            public string external_url
            {
                get { return __pbn__external_url ?? ""; }
                set { __pbn__external_url = value; }
            }
            public bool ShouldSerializeexternal_url() => __pbn__external_url != null;
            public void Resetexternal_url() => __pbn__external_url = null;
            private string __pbn__external_url;

            [global::ProtoBuf.ProtoMember(5)]
            [global::System.ComponentModel.DefaultValue("")]
            public string access_token
            {
                get { return __pbn__access_token ?? ""; }
                set { __pbn__access_token = value; }
            }
            public bool ShouldSerializeaccess_token() => __pbn__access_token != null;
            public void Resetaccess_token() => __pbn__access_token = null;
            private string __pbn__access_token;

            [global::ProtoBuf.ProtoMember(6)]
            [global::System.ComponentModel.DefaultValue("")]
            public string access_token_secret
            {
                get { return __pbn__access_token_secret ?? ""; }
                set { __pbn__access_token_secret = value; }
            }
            public bool ShouldSerializeaccess_token_secret() => __pbn__access_token_secret != null;
            public void Resetaccess_token_secret() => __pbn__access_token_secret = null;
            private string __pbn__access_token_secret;

            [global::ProtoBuf.ProtoMember(7)]
            public bool is_valid
            {
                get { return __pbn__is_valid.GetValueOrDefault(); }
                set { __pbn__is_valid = value; }
            }
            public bool ShouldSerializeis_valid() => __pbn__is_valid != null;
            public void Resetis_valid() => __pbn__is_valid = null;
            private bool? __pbn__is_valid;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CEmbeddedClient_AuthorizeCurrentDevice_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

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
        public string device_info
        {
            get { return __pbn__device_info ?? ""; }
            set { __pbn__device_info = value; }
        }
        public bool ShouldSerializedevice_info() => __pbn__device_info != null;
        public void Resetdevice_info() => __pbn__device_info = null;
        private string __pbn__device_info;

        [global::ProtoBuf.ProtoMember(4)]
        public uint deviceid
        {
            get { return __pbn__deviceid.GetValueOrDefault(); }
            set { __pbn__deviceid = value; }
        }
        public bool ShouldSerializedeviceid() => __pbn__deviceid != null;
        public void Resetdeviceid() => __pbn__deviceid = null;
        private uint? __pbn__deviceid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CEmbeddedClient_Token : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] client_token
        {
            get { return __pbn__client_token; }
            set { __pbn__client_token = value; }
        }
        public bool ShouldSerializeclient_token() => __pbn__client_token != null;
        public void Resetclient_token() => __pbn__client_token = null;
        private byte[] __pbn__client_token;

        [global::ProtoBuf.ProtoMember(3)]
        public uint expiry
        {
            get { return __pbn__expiry.GetValueOrDefault(); }
            set { __pbn__expiry = value; }
        }
        public bool ShouldSerializeexpiry() => __pbn__expiry != null;
        public void Resetexpiry() => __pbn__expiry = null;
        private uint? __pbn__expiry;

        [global::ProtoBuf.ProtoMember(4)]
        public uint deviceid
        {
            get { return __pbn__deviceid.GetValueOrDefault(); }
            set { __pbn__deviceid = value; }
        }
        public bool ShouldSerializedeviceid() => __pbn__deviceid != null;
        public void Resetdeviceid() => __pbn__deviceid = null;
        private uint? __pbn__deviceid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CEmbeddedClient_AuthorizeDevice_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint result
        {
            get { return __pbn__result.GetValueOrDefault(); }
            set { __pbn__result = value; }
        }
        public bool ShouldSerializeresult() => __pbn__result != null;
        public void Resetresult() => __pbn__result = null;
        private uint? __pbn__result;

        [global::ProtoBuf.ProtoMember(2)]
        public CEmbeddedClient_Token token { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EInternalAccountType
    {
        k_EInternalSteamAccountType = 1,
        k_EInternalClanType = 2,
        k_EInternalAppType = 3,
        k_EInternalBroadcastChannelType = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EExternalAccountType
    {
        k_EExternalNone = 0,
        k_EExternalSteamAccount = 1,
        k_EExternalGoogleAccount = 2,
        k_EExternalFacebookAccount = 3,
        k_EExternalTwitterAccount = 4,
        k_EExternalTwitchAccount = 5,
        k_EExternalYouTubeChannelAccount = 6,
        k_EExternalFacebookPage = 7,
    }

    public interface IUserAccount
    {
        CUserAccount_GetAvailableValveDiscountPromotions_Response GetAvailableValveDiscountPromotions(CUserAccount_GetAvailableValveDiscountPromotions_Request request);
        CUserAccount_GetAccountLinkStatus_Response GetAccountLinkStatus(CUserAccount_GetAccountLinkStatus_Request request);
        CUserAccount_CancelLicenseForApp_Response CancelLicenseForApp(CUserAccount_CancelLicenseForApp_Request request);
        CUserAccount_CreateFriendInviteToken_Response CreateFriendInviteToken(CUserAccount_CreateFriendInviteToken_Request request);
        CUserAccount_GetFriendInviteTokens_Response GetFriendInviteTokens(CUserAccount_GetFriendInviteTokens_Request request);
        CUserAccount_ViewFriendInviteToken_Response ViewFriendInviteToken(CUserAccount_ViewFriendInviteToken_Request request);
        CUserAccount_RedeemFriendInviteToken_Response RedeemFriendInviteToken(CUserAccount_RedeemFriendInviteToken_Request request);
        CUserAccount_RevokeFriendInviteToken_Response RevokeFriendInviteToken(CUserAccount_RevokeFriendInviteToken_Request request);
        CUserAccount_RegisterCompatTool_Response RegisterCompatTool(CUserAccount_RegisterCompatTool_Request request);
    }

    public interface IAccountLinking
    {
        CAccountLinking_GetLinkedAccountInfo_Response GetLinkedAccountInfo(CAccountLinking_GetLinkedAccountInfo_Request request);
    }

    public interface IEmbeddedClient
    {
        CEmbeddedClient_AuthorizeDevice_Response AuthorizeCurrentDevice(CEmbeddedClient_AuthorizeCurrentDevice_Request request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
