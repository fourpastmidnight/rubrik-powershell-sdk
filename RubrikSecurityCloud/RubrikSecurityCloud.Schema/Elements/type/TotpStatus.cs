// TotpStatus.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region TotpStatus
    public class TotpStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.Boolean? IsEnforced
        // GraphQL -> isEnforced: Boolean! (scalar)
        [JsonProperty("isEnforced")]
        public System.Boolean? IsEnforced { get; set; }

        //      C# -> System.Boolean? IsEnforcedUserLevel
        // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
        [JsonProperty("isEnforcedUserLevel")]
        public System.Boolean? IsEnforcedUserLevel { get; set; }

        //      C# -> System.Boolean? IsSupported
        // GraphQL -> isSupported: Boolean! (scalar)
        [JsonProperty("isSupported")]
        public System.Boolean? IsSupported { get; set; }

        //      C# -> DateTime? TotpConfigUpdateAt
        // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
        [JsonProperty("totpConfigUpdateAt")]
        public DateTime? TotpConfigUpdateAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TotpStatus";
    }

    public TotpStatus Set(
        System.Boolean? IsEnabled = null,
        System.Boolean? IsEnforced = null,
        System.Boolean? IsEnforcedUserLevel = null,
        System.Boolean? IsSupported = null,
        DateTime? TotpConfigUpdateAt = null
    ) 
    {
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( IsEnforced != null ) {
            this.IsEnforced = IsEnforced;
        }
        if ( IsEnforcedUserLevel != null ) {
            this.IsEnforcedUserLevel = IsEnforcedUserLevel;
        }
        if ( IsSupported != null ) {
            this.IsSupported = IsSupported;
        }
        if ( TotpConfigUpdateAt != null ) {
            this.TotpConfigUpdateAt = TotpConfigUpdateAt;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnabled\n" ;
            } else {
                s += ind + "isEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnforced
        // GraphQL -> isEnforced: Boolean! (scalar)
        if (this.IsEnforced != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnforced\n" ;
            } else {
                s += ind + "isEnforced\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnforcedUserLevel
        // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
        if (this.IsEnforcedUserLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnforcedUserLevel\n" ;
            } else {
                s += ind + "isEnforcedUserLevel\n" ;
            }
        }
        //      C# -> System.Boolean? IsSupported
        // GraphQL -> isSupported: Boolean! (scalar)
        if (this.IsSupported != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSupported\n" ;
            } else {
                s += ind + "isSupported\n" ;
            }
        }
        //      C# -> DateTime? TotpConfigUpdateAt
        // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
        if (this.TotpConfigUpdateAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totpConfigUpdateAt\n" ;
            } else {
                s += ind + "totpConfigUpdateAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (ec.Includes("isEnabled",true))
        {
            if(this.IsEnabled == null) {

                this.IsEnabled = true;

            } else {


            }
        }
        else if (this.IsEnabled != null && ec.Excludes("isEnabled",true))
        {
            this.IsEnabled = null;
        }
        //      C# -> System.Boolean? IsEnforced
        // GraphQL -> isEnforced: Boolean! (scalar)
        if (ec.Includes("isEnforced",true))
        {
            if(this.IsEnforced == null) {

                this.IsEnforced = true;

            } else {


            }
        }
        else if (this.IsEnforced != null && ec.Excludes("isEnforced",true))
        {
            this.IsEnforced = null;
        }
        //      C# -> System.Boolean? IsEnforcedUserLevel
        // GraphQL -> isEnforcedUserLevel: Boolean! (scalar)
        if (ec.Includes("isEnforcedUserLevel",true))
        {
            if(this.IsEnforcedUserLevel == null) {

                this.IsEnforcedUserLevel = true;

            } else {


            }
        }
        else if (this.IsEnforcedUserLevel != null && ec.Excludes("isEnforcedUserLevel",true))
        {
            this.IsEnforcedUserLevel = null;
        }
        //      C# -> System.Boolean? IsSupported
        // GraphQL -> isSupported: Boolean! (scalar)
        if (ec.Includes("isSupported",true))
        {
            if(this.IsSupported == null) {

                this.IsSupported = true;

            } else {


            }
        }
        else if (this.IsSupported != null && ec.Excludes("isSupported",true))
        {
            this.IsSupported = null;
        }
        //      C# -> DateTime? TotpConfigUpdateAt
        // GraphQL -> totpConfigUpdateAt: DateTime (scalar)
        if (ec.Includes("totpConfigUpdateAt",true))
        {
            if(this.TotpConfigUpdateAt == null) {

                this.TotpConfigUpdateAt = new DateTime();

            } else {


            }
        }
        else if (this.TotpConfigUpdateAt != null && ec.Excludes("totpConfigUpdateAt",true))
        {
            this.TotpConfigUpdateAt = null;
        }
    }


    #endregion

    } // class TotpStatus
    
    #endregion

    public static class ListTotpStatusExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<TotpStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TotpStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TotpStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TotpStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TotpStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types