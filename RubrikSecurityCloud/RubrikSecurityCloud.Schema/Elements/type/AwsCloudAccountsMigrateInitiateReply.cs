// AwsCloudAccountsMigrateInitiateReply.cs
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
    #region AwsCloudAccountsMigrateInitiateReply
    public class AwsCloudAccountsMigrateInitiateReply: BaseType
    {
        #region members

        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        [JsonProperty("cloudFormationUrl")]
        public System.String? CloudFormationUrl { get; set; }

        //      C# -> System.String? StackName
        // GraphQL -> stackName: String! (scalar)
        [JsonProperty("stackName")]
        public System.String? StackName { get; set; }

        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        [JsonProperty("templateUrl")]
        public System.String? TemplateUrl { get; set; }

        //      C# -> List<AwsCloudAccount>? EligibleAwsAccounts
        // GraphQL -> eligibleAwsAccounts: [AwsCloudAccount!]! (type)
        [JsonProperty("eligibleAwsAccounts")]
        public List<AwsCloudAccount>? EligibleAwsAccounts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsCloudAccountsMigrateInitiateReply";
    }

    public AwsCloudAccountsMigrateInitiateReply Set(
        System.String? CloudFormationUrl = null,
        System.String? StackName = null,
        System.String? TemplateUrl = null,
        List<AwsCloudAccount>? EligibleAwsAccounts = null
    ) 
    {
        if ( CloudFormationUrl != null ) {
            this.CloudFormationUrl = CloudFormationUrl;
        }
        if ( StackName != null ) {
            this.StackName = StackName;
        }
        if ( TemplateUrl != null ) {
            this.TemplateUrl = TemplateUrl;
        }
        if ( EligibleAwsAccounts != null ) {
            this.EligibleAwsAccounts = EligibleAwsAccounts;
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
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudFormationUrl\n" ;
            } else {
                s += ind + "cloudFormationUrl\n" ;
            }
        }
        //      C# -> System.String? StackName
        // GraphQL -> stackName: String! (scalar)
        if (this.StackName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stackName\n" ;
            } else {
                s += ind + "stackName\n" ;
            }
        }
        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        if (this.TemplateUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "templateUrl\n" ;
            } else {
                s += ind + "templateUrl\n" ;
            }
        }
        //      C# -> List<AwsCloudAccount>? EligibleAwsAccounts
        // GraphQL -> eligibleAwsAccounts: [AwsCloudAccount!]! (type)
        if (this.EligibleAwsAccounts != null) {
            var fspec = this.EligibleAwsAccounts.AsFieldSpec(conf.Child("eligibleAwsAccounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "eligibleAwsAccounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (ec.Includes("cloudFormationUrl",true))
        {
            if(this.CloudFormationUrl == null) {

                this.CloudFormationUrl = "FETCH";

            } else {


            }
        }
        else if (this.CloudFormationUrl != null && ec.Excludes("cloudFormationUrl",true))
        {
            this.CloudFormationUrl = null;
        }
        //      C# -> System.String? StackName
        // GraphQL -> stackName: String! (scalar)
        if (ec.Includes("stackName",true))
        {
            if(this.StackName == null) {

                this.StackName = "FETCH";

            } else {


            }
        }
        else if (this.StackName != null && ec.Excludes("stackName",true))
        {
            this.StackName = null;
        }
        //      C# -> System.String? TemplateUrl
        // GraphQL -> templateUrl: String! (scalar)
        if (ec.Includes("templateUrl",true))
        {
            if(this.TemplateUrl == null) {

                this.TemplateUrl = "FETCH";

            } else {


            }
        }
        else if (this.TemplateUrl != null && ec.Excludes("templateUrl",true))
        {
            this.TemplateUrl = null;
        }
        //      C# -> List<AwsCloudAccount>? EligibleAwsAccounts
        // GraphQL -> eligibleAwsAccounts: [AwsCloudAccount!]! (type)
        if (ec.Includes("eligibleAwsAccounts",false))
        {
            if(this.EligibleAwsAccounts == null) {

                this.EligibleAwsAccounts = new List<AwsCloudAccount>();
                this.EligibleAwsAccounts.ApplyExploratoryFieldSpec(ec.NewChild("eligibleAwsAccounts"));

            } else {

                this.EligibleAwsAccounts.ApplyExploratoryFieldSpec(ec.NewChild("eligibleAwsAccounts"));

            }
        }
        else if (this.EligibleAwsAccounts != null && ec.Excludes("eligibleAwsAccounts",false))
        {
            this.EligibleAwsAccounts = null;
        }
    }


    #endregion

    } // class AwsCloudAccountsMigrateInitiateReply
    
    #endregion

    public static class ListAwsCloudAccountsMigrateInitiateReplyExtensions
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
            this List<AwsCloudAccountsMigrateInitiateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsCloudAccountsMigrateInitiateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountsMigrateInitiateReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountsMigrateInitiateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCloudAccountsMigrateInitiateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types