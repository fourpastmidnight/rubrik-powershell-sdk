// GcpCloudAccountProjectDeleteStatus.cs
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
    #region GcpCloudAccountProjectDeleteStatus
    public class GcpCloudAccountProjectDeleteStatus: BaseType
    {
        #region members

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.String? ProjectUuid
        // GraphQL -> projectUuid: String! (scalar)
        [JsonProperty("projectUuid")]
        public System.String? ProjectUuid { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }

        //      C# -> List<FeatureDeleteStatus>? FeaturesStatus
        // GraphQL -> featuresStatus: [FeatureDeleteStatus!]! (type)
        [JsonProperty("featuresStatus")]
        public List<FeatureDeleteStatus>? FeaturesStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountProjectDeleteStatus";
    }

    public GcpCloudAccountProjectDeleteStatus Set(
        System.String? Error = null,
        System.String? ProjectUuid = null,
        System.Boolean? Success = null,
        List<FeatureDeleteStatus>? FeaturesStatus = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( ProjectUuid != null ) {
            this.ProjectUuid = ProjectUuid;
        }
        if ( Success != null ) {
            this.Success = Success;
        }
        if ( FeaturesStatus != null ) {
            this.FeaturesStatus = FeaturesStatus;
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
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.String? ProjectUuid
        // GraphQL -> projectUuid: String! (scalar)
        if (this.ProjectUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "projectUuid\n" ;
            } else {
                s += ind + "projectUuid\n" ;
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
        //      C# -> List<FeatureDeleteStatus>? FeaturesStatus
        // GraphQL -> featuresStatus: [FeatureDeleteStatus!]! (type)
        if (this.FeaturesStatus != null) {
            var fspec = this.FeaturesStatus.AsFieldSpec(conf.Child("featuresStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featuresStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.String? ProjectUuid
        // GraphQL -> projectUuid: String! (scalar)
        if (ec.Includes("projectUuid",true))
        {
            if(this.ProjectUuid == null) {

                this.ProjectUuid = "FETCH";

            } else {


            }
        }
        else if (this.ProjectUuid != null && ec.Excludes("projectUuid",true))
        {
            this.ProjectUuid = null;
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
        //      C# -> List<FeatureDeleteStatus>? FeaturesStatus
        // GraphQL -> featuresStatus: [FeatureDeleteStatus!]! (type)
        if (ec.Includes("featuresStatus",false))
        {
            if(this.FeaturesStatus == null) {

                this.FeaturesStatus = new List<FeatureDeleteStatus>();
                this.FeaturesStatus.ApplyExploratoryFieldSpec(ec.NewChild("featuresStatus"));

            } else {

                this.FeaturesStatus.ApplyExploratoryFieldSpec(ec.NewChild("featuresStatus"));

            }
        }
        else if (this.FeaturesStatus != null && ec.Excludes("featuresStatus",false))
        {
            this.FeaturesStatus = null;
        }
    }


    #endregion

    } // class GcpCloudAccountProjectDeleteStatus
    
    #endregion

    public static class ListGcpCloudAccountProjectDeleteStatusExtensions
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
            this List<GcpCloudAccountProjectDeleteStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpCloudAccountProjectDeleteStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountProjectDeleteStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountProjectDeleteStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountProjectDeleteStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types