// M365OrgOperationModes.cs
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
    #region M365OrgOperationModes
    public class M365OrgOperationModes: BaseType
    {
        #region members

        //      C# -> List<M365ProductOperationMode>? OperationModes
        // GraphQL -> operationModes: [M365ProductOperationMode!]! (type)
        [JsonProperty("operationModes")]
        public List<M365ProductOperationMode>? OperationModes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365OrgOperationModes";
    }

    public M365OrgOperationModes Set(
        List<M365ProductOperationMode>? OperationModes = null
    ) 
    {
        if ( OperationModes != null ) {
            this.OperationModes = OperationModes;
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
        //      C# -> List<M365ProductOperationMode>? OperationModes
        // GraphQL -> operationModes: [M365ProductOperationMode!]! (type)
        if (this.OperationModes != null) {
            var fspec = this.OperationModes.AsFieldSpec(conf.Child("operationModes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "operationModes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<M365ProductOperationMode>? OperationModes
        // GraphQL -> operationModes: [M365ProductOperationMode!]! (type)
        if (ec.Includes("operationModes",false))
        {
            if(this.OperationModes == null) {

                this.OperationModes = new List<M365ProductOperationMode>();
                this.OperationModes.ApplyExploratoryFieldSpec(ec.NewChild("operationModes"));

            } else {

                this.OperationModes.ApplyExploratoryFieldSpec(ec.NewChild("operationModes"));

            }
        }
        else if (this.OperationModes != null && ec.Excludes("operationModes",false))
        {
            this.OperationModes = null;
        }
    }


    #endregion

    } // class M365OrgOperationModes
    
    #endregion

    public static class ListM365OrgOperationModesExtensions
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
            this List<M365OrgOperationModes> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365OrgOperationModes> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365OrgOperationModes> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365OrgOperationModes());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365OrgOperationModes> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types