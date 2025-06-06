// TprRequestedChangeManagedObjectEntry.cs
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
    #region TprRequestedChangeManagedObjectEntry
    public class TprRequestedChangeManagedObjectEntry: BaseType
    {
        #region members

        //      C# -> List<TprPolicyObject>? NewValue
        // GraphQL -> newValue: [TprPolicyObject!]! (type)
        [JsonProperty("newValue")]
        public List<TprPolicyObject>? NewValue { get; set; }

        //      C# -> List<TprPolicyObject>? OldValue
        // GraphQL -> oldValue: [TprPolicyObject!]! (type)
        [JsonProperty("oldValue")]
        public List<TprPolicyObject>? OldValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestedChangeManagedObjectEntry";
    }

    public TprRequestedChangeManagedObjectEntry Set(
        List<TprPolicyObject>? NewValue = null,
        List<TprPolicyObject>? OldValue = null
    ) 
    {
        if ( NewValue != null ) {
            this.NewValue = NewValue;
        }
        if ( OldValue != null ) {
            this.OldValue = OldValue;
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
        //      C# -> List<TprPolicyObject>? NewValue
        // GraphQL -> newValue: [TprPolicyObject!]! (type)
        if (this.NewValue != null) {
            var fspec = this.NewValue.AsFieldSpec(conf.Child("newValue"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newValue" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TprPolicyObject>? OldValue
        // GraphQL -> oldValue: [TprPolicyObject!]! (type)
        if (this.OldValue != null) {
            var fspec = this.OldValue.AsFieldSpec(conf.Child("oldValue"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldValue" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<TprPolicyObject>? NewValue
        // GraphQL -> newValue: [TprPolicyObject!]! (type)
        if (ec.Includes("newValue",false))
        {
            if(this.NewValue == null) {

                this.NewValue = new List<TprPolicyObject>();
                this.NewValue.ApplyExploratoryFieldSpec(ec.NewChild("newValue"));

            } else {

                this.NewValue.ApplyExploratoryFieldSpec(ec.NewChild("newValue"));

            }
        }
        else if (this.NewValue != null && ec.Excludes("newValue",false))
        {
            this.NewValue = null;
        }
        //      C# -> List<TprPolicyObject>? OldValue
        // GraphQL -> oldValue: [TprPolicyObject!]! (type)
        if (ec.Includes("oldValue",false))
        {
            if(this.OldValue == null) {

                this.OldValue = new List<TprPolicyObject>();
                this.OldValue.ApplyExploratoryFieldSpec(ec.NewChild("oldValue"));

            } else {

                this.OldValue.ApplyExploratoryFieldSpec(ec.NewChild("oldValue"));

            }
        }
        else if (this.OldValue != null && ec.Excludes("oldValue",false))
        {
            this.OldValue = null;
        }
    }


    #endregion

    } // class TprRequestedChangeManagedObjectEntry
    
    #endregion

    public static class ListTprRequestedChangeManagedObjectEntryExtensions
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
            this List<TprRequestedChangeManagedObjectEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprRequestedChangeManagedObjectEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestedChangeManagedObjectEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestedChangeManagedObjectEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprRequestedChangeManagedObjectEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types