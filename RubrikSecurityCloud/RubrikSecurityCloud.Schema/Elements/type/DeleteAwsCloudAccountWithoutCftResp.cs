// DeleteAwsCloudAccountWithoutCftResp.cs
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
    #region DeleteAwsCloudAccountWithoutCftResp
    public class DeleteAwsCloudAccountWithoutCftResp: BaseType
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeleteAwsCloudAccountWithoutCftResp";
    }

    public DeleteAwsCloudAccountWithoutCftResp Set(
        CloudAccountFeature? Feature = null,
        System.Boolean? Success = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( Success != null ) {
            this.Success = Success;
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
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success != null) {
            if (conf.Flat) {
                s += conf.Prefix + "success\n" ;
            } else {
                s += ind + "success\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (ec.Includes("feature",true))
        {
            if(this.Feature == null) {

                this.Feature = new CloudAccountFeature();

            } else {


            }
        }
        else if (this.Feature != null && ec.Excludes("feature",true))
        {
            this.Feature = null;
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (ec.Includes("success",true))
        {
            if(this.Success == null) {

                this.Success = true;

            } else {


            }
        }
        else if (this.Success != null && ec.Excludes("success",true))
        {
            this.Success = null;
        }
    }


    #endregion

    } // class DeleteAwsCloudAccountWithoutCftResp
    
    #endregion

    public static class ListDeleteAwsCloudAccountWithoutCftRespExtensions
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
            this List<DeleteAwsCloudAccountWithoutCftResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DeleteAwsCloudAccountWithoutCftResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DeleteAwsCloudAccountWithoutCftResp> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteAwsCloudAccountWithoutCftResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DeleteAwsCloudAccountWithoutCftResp> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types