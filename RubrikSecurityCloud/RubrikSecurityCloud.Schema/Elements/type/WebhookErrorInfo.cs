// WebhookErrorInfo.cs
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
    #region WebhookErrorInfo
    public class WebhookErrorInfo: BaseType
    {
        #region members

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Int32? StatusCode
        // GraphQL -> statusCode: Int! (scalar)
        [JsonProperty("statusCode")]
        public System.Int32? StatusCode { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WebhookErrorInfo";
    }

    public WebhookErrorInfo Set(
        System.String? ErrorMessage = null,
        System.Int32? StatusCode = null
    ) 
    {
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( StatusCode != null ) {
            this.StatusCode = StatusCode;
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
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.Int32? StatusCode
        // GraphQL -> statusCode: Int! (scalar)
        if (this.StatusCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusCode\n" ;
            } else {
                s += ind + "statusCode\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.Int32? StatusCode
        // GraphQL -> statusCode: Int! (scalar)
        if (ec.Includes("statusCode",true))
        {
            if(this.StatusCode == null) {

                this.StatusCode = Int32.MinValue;

            } else {


            }
        }
        else if (this.StatusCode != null && ec.Excludes("statusCode",true))
        {
            this.StatusCode = null;
        }
    }


    #endregion

    } // class WebhookErrorInfo
    
    #endregion

    public static class ListWebhookErrorInfoExtensions
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
            this List<WebhookErrorInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WebhookErrorInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WebhookErrorInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WebhookErrorInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WebhookErrorInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types