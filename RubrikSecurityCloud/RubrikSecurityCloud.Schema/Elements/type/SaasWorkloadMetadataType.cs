// SaasWorkloadMetadataType.cs
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
    #region SaasWorkloadMetadataType
    public class SaasWorkloadMetadataType: BaseType
    {
        #region members

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> SaasWorkloadField? FilterField
        // GraphQL -> filterField: SaasWorkloadField (type)
        [JsonProperty("filterField")]
        public SaasWorkloadField? FilterField { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasWorkloadMetadataType";
    }

    public SaasWorkloadMetadataType Set(
        System.String? AppItemTypeToken = null,
        System.String? Name = null,
        SaasWorkloadField? FilterField = null
    ) 
    {
        if ( AppItemTypeToken != null ) {
            this.AppItemTypeToken = AppItemTypeToken;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( FilterField != null ) {
            this.FilterField = FilterField;
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
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appItemTypeToken\n" ;
            } else {
                s += ind + "appItemTypeToken\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> SaasWorkloadField? FilterField
        // GraphQL -> filterField: SaasWorkloadField (type)
        if (this.FilterField != null) {
            var fspec = this.FilterField.AsFieldSpec(conf.Child("filterField"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filterField" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (ec.Includes("appItemTypeToken",true))
        {
            if(this.AppItemTypeToken == null) {

                this.AppItemTypeToken = "FETCH";

            } else {


            }
        }
        else if (this.AppItemTypeToken != null && ec.Excludes("appItemTypeToken",true))
        {
            this.AppItemTypeToken = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> SaasWorkloadField? FilterField
        // GraphQL -> filterField: SaasWorkloadField (type)
        if (ec.Includes("filterField",false))
        {
            if(this.FilterField == null) {

                this.FilterField = new SaasWorkloadField();
                this.FilterField.ApplyExploratoryFieldSpec(ec.NewChild("filterField"));

            } else {

                this.FilterField.ApplyExploratoryFieldSpec(ec.NewChild("filterField"));

            }
        }
        else if (this.FilterField != null && ec.Excludes("filterField",false))
        {
            this.FilterField = null;
        }
    }


    #endregion

    } // class SaasWorkloadMetadataType
    
    #endregion

    public static class ListSaasWorkloadMetadataTypeExtensions
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
            this List<SaasWorkloadMetadataType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SaasWorkloadMetadataType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SaasWorkloadMetadataType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasWorkloadMetadataType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SaasWorkloadMetadataType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types