// New-RscQueryM365.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 11
    /// operations in the 'Microsoft 365' API domain:
    /// BackupStorageLicenseUsage, BackupStorageObjectRestorePoints, DayToDayModeStats, DirectoryObjectAttributes, LicenseEntitlement, OnboardingModeBackupStats, OnboardingModeStats, OrgBackupLocations, OrgOperationModes, Regions, or SearchBackupStorageObjectRestorePoints.
    /// </summary>
    /// <description>
    /// New-RscQueryM365 creates a new
    /// query object for operations
    /// in the 'Microsoft 365' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 11 operations
    /// in the 'Microsoft 365' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: BackupStorageLicenseUsage, BackupStorageObjectRestorePoints, DayToDayModeStats, DirectoryObjectAttributes, LicenseEntitlement, OnboardingModeBackupStats, OnboardingModeStats, OrgBackupLocations, OrgOperationModes, Regions, or SearchBackupStorageObjectRestorePoints.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryM365 -BackupStorageLicenseUsage).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQueryM365 -BackupStorageLicenseUsage).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the BackupStorageLicenseUsage operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: BackupStorageLicenseUsage
    /// 
    /// $query = New-RscQueryM365 -Operation BackupStorageLicenseUsage
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: M365BackupStorageLicenseUsage
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the BackupStorageObjectRestorePoints operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: BackupStorageObjectRestorePoints
    /// 
    /// $query = New-RscQueryM365 -Operation BackupStorageObjectRestorePoints
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # REQUIRED
    /// $query.Var.m365BackupStorageObjectRestorePointsInput = @{
    /// 	# REQUIRED
    /// 	objectId = $someString
    /// 	# REQUIRED
    /// 	rangeFilter = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	restorePointTagType = @(
    /// 		$someRestorePointTagType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RestorePointTagType]) for enum values.
    /// 	)
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: M365BackupStorageRestorePointConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DayToDayModeStats operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: DayToDayModeStats
    /// 
    /// $query = New-RscQueryM365 -Operation DayToDayModeStats
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # REQUIRED
    /// $query.Var.dashboardWorkloadType = $someM365DashboardWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.M365DashboardWorkloadType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DayToDayModeStats
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DirectoryObjectAttributes operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: DirectoryObjectAttributes
    /// 
    /// $query = New-RscQueryM365 -Operation DirectoryObjectAttributes
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	orgId = $someString
    /// 	# REQUIRED
    /// 	objectType = $someDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DirectoryObjectType]) for enum values.
    /// 	# REQUIRED
    /// 	attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
    /// 	# OPTIONAL
    /// 	searchTextPrefix = $someString
    /// 	# REQUIRED
    /// 	maxResults = $someInt
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ListO365DirectoryObjectAttributesResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the LicenseEntitlement operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: LicenseEntitlement
    /// 
    /// $query = New-RscQueryM365 -Operation LicenseEntitlement
    /// 
    /// # OPTIONAL
    /// $query.Var.orgID = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: M365LicenseEntitlementReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OnboardingModeBackupStats operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: OnboardingModeBackupStats
    /// 
    /// $query = New-RscQueryM365 -Operation OnboardingModeBackupStats
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # REQUIRED
    /// $query.Var.dashboardWorkloadType = $someM365DashboardWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.M365DashboardWorkloadType]) for enum values.
    /// # REQUIRED
    /// $query.Var.backupStatsTimeRange = $someBackupStatsTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BackupStatsTimeRange]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OnboardingModeBackupStats
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OnboardingModeStats operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: OnboardingModeStats
    /// 
    /// $query = New-RscQueryM365 -Operation OnboardingModeStats
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// # REQUIRED
    /// $query.Var.dashboardWorkloadType = $someM365DashboardWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.M365DashboardWorkloadType]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: OnboardingModeStats
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OrgBackupLocations operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: OrgBackupLocations
    /// 
    /// $query = New-RscQueryM365 -Operation OrgBackupLocations
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: M365OrgBackupLocations
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the OrgOperationModes operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: OrgOperationModes
    /// 
    /// $query = New-RscQueryM365 -Operation OrgOperationModes
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: M365OrgOperationModes
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Regions operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: Regions
    /// 
    /// $query = New-RscQueryM365 -Operation Regions
    /// 
    /// # REQUIRED
    /// $query.Var.orgId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: M365RegionsResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SearchBackupStorageObjectRestorePoints operation
    /// of the 'Microsoft 365' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    M365
    /// # API Operation: SearchBackupStorageObjectRestorePoints
    /// 
    /// $query = New-RscQueryM365 -Operation SearchBackupStorageObjectRestorePoints
    /// 
    /// # REQUIRED
    /// $query.Var.searchM365BackupStorageObjectRestorePointsInput = @{
    /// 	# REQUIRED
    /// 	objectId = $someString
    /// 	# REQUIRED
    /// 	rangeFilter = @{
    /// 		# OPTIONAL
    /// 		fromTime = $someDateTime
    /// 		# OPTIONAL
    /// 		untilTime = $someDateTime
    /// 	}
    /// 	# OPTIONAL
    /// 	restorePointTagType = $someRestorePointTagType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RestorePointTagType]) for enum values.
    /// 	# OPTIONAL
    /// 	restorePointPreferenceType = $someRestorePointPreferenceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RestorePointPreferenceType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SearchM365BackupStorageObjectRestorePointsResp
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryM365",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQueryM365 : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "BackupStorageLicenseUsage",
                "BackupStorageObjectRestorePoints",
                "DayToDayModeStats",
                "DirectoryObjectAttributes",
                "LicenseEntitlement",
                "OnboardingModeBackupStats",
                "OnboardingModeStats",
                "OrgBackupLocations",
                "OrgOperationModes",
                "Regions",
                "SearchBackupStorageObjectRestorePoints",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "BackupStorageLicenseUsage":
                        this.ProcessRecord_BackupStorageLicenseUsage();
                        break;
                    case "BackupStorageObjectRestorePoints":
                        this.ProcessRecord_BackupStorageObjectRestorePoints();
                        break;
                    case "DayToDayModeStats":
                        this.ProcessRecord_DayToDayModeStats();
                        break;
                    case "DirectoryObjectAttributes":
                        this.ProcessRecord_DirectoryObjectAttributes();
                        break;
                    case "LicenseEntitlement":
                        this.ProcessRecord_LicenseEntitlement();
                        break;
                    case "OnboardingModeBackupStats":
                        this.ProcessRecord_OnboardingModeBackupStats();
                        break;
                    case "OnboardingModeStats":
                        this.ProcessRecord_OnboardingModeStats();
                        break;
                    case "OrgBackupLocations":
                        this.ProcessRecord_OrgBackupLocations();
                        break;
                    case "OrgOperationModes":
                        this.ProcessRecord_OrgOperationModes();
                        break;
                    case "Regions":
                        this.ProcessRecord_Regions();
                        break;
                    case "SearchBackupStorageObjectRestorePoints":
                        this.ProcessRecord_SearchBackupStorageObjectRestorePoints();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // m365BackupStorageLicenseUsage.
        internal void ProcessRecord_BackupStorageLicenseUsage()
        {
            this._logger.name += " -BackupStorageLicenseUsage";
            // Create new graphql operation m365BackupStorageLicenseUsage
            InitQueryM365BackupStorageLicenseUsage();
        }

        // This parameter set invokes a single graphql operation:
        // m365BackupStorageObjectRestorePoints.
        internal void ProcessRecord_BackupStorageObjectRestorePoints()
        {
            this._logger.name += " -BackupStorageObjectRestorePoints";
            // Create new graphql operation m365BackupStorageObjectRestorePoints
            InitQueryM365BackupStorageObjectRestorePoints();
        }

        // This parameter set invokes a single graphql operation:
        // m365DayToDayModeStats.
        internal void ProcessRecord_DayToDayModeStats()
        {
            this._logger.name += " -DayToDayModeStats";
            // Create new graphql operation m365DayToDayModeStats
            InitQueryM365DayToDayModeStats();
        }

        // This parameter set invokes a single graphql operation:
        // m365DirectoryObjectAttributes.
        internal void ProcessRecord_DirectoryObjectAttributes()
        {
            this._logger.name += " -DirectoryObjectAttributes";
            // Create new graphql operation m365DirectoryObjectAttributes
            InitQueryM365DirectoryObjectAttributes();
        }

        // This parameter set invokes a single graphql operation:
        // m365LicenseEntitlement.
        internal void ProcessRecord_LicenseEntitlement()
        {
            this._logger.name += " -LicenseEntitlement";
            // Create new graphql operation m365LicenseEntitlement
            InitQueryM365LicenseEntitlement();
        }

        // This parameter set invokes a single graphql operation:
        // m365OnboardingModeBackupStats.
        internal void ProcessRecord_OnboardingModeBackupStats()
        {
            this._logger.name += " -OnboardingModeBackupStats";
            // Create new graphql operation m365OnboardingModeBackupStats
            InitQueryM365OnboardingModeBackupStats();
        }

        // This parameter set invokes a single graphql operation:
        // m365OnboardingModeStats.
        internal void ProcessRecord_OnboardingModeStats()
        {
            this._logger.name += " -OnboardingModeStats";
            // Create new graphql operation m365OnboardingModeStats
            InitQueryM365OnboardingModeStats();
        }

        // This parameter set invokes a single graphql operation:
        // m365OrgBackupLocations.
        internal void ProcessRecord_OrgBackupLocations()
        {
            this._logger.name += " -OrgBackupLocations";
            // Create new graphql operation m365OrgBackupLocations
            InitQueryM365OrgBackupLocations();
        }

        // This parameter set invokes a single graphql operation:
        // m365OrgOperationModes.
        internal void ProcessRecord_OrgOperationModes()
        {
            this._logger.name += " -OrgOperationModes";
            // Create new graphql operation m365OrgOperationModes
            InitQueryM365OrgOperationModes();
        }

        // This parameter set invokes a single graphql operation:
        // m365Regions.
        internal void ProcessRecord_Regions()
        {
            this._logger.name += " -Regions";
            // Create new graphql operation m365Regions
            InitQueryM365Regions();
        }

        // This parameter set invokes a single graphql operation:
        // searchM365BackupStorageObjectRestorePoints.
        internal void ProcessRecord_SearchBackupStorageObjectRestorePoints()
        {
            this._logger.name += " -SearchBackupStorageObjectRestorePoints";
            // Create new graphql operation searchM365BackupStorageObjectRestorePoints
            InitQuerySearchM365BackupStorageObjectRestorePoints();
        }


        // Create new GraphQL Query:
        // m365BackupStorageLicenseUsage: M365BackupStorageLicenseUsage!
        internal void InitQueryM365BackupStorageLicenseUsage()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365BackupStorageLicenseUsage",
                "",
                "M365BackupStorageLicenseUsage",
                Query.M365BackupStorageLicenseUsage,
                Query.M365BackupStorageLicenseUsageFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // m365BackupStorageObjectRestorePoints(first: Int, after: String, m365BackupStorageObjectRestorePointsInput: M365BackupStorageObjectRestorePointsInput!): M365BackupStorageRestorePointConnection!
        internal void InitQueryM365BackupStorageObjectRestorePoints()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("m365BackupStorageObjectRestorePointsInput", "M365BackupStorageObjectRestorePointsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365BackupStorageObjectRestorePoints",
                "($first: Int,$after: String,$m365BackupStorageObjectRestorePointsInput: M365BackupStorageObjectRestorePointsInput!)",
                "M365BackupStorageRestorePointConnection",
                Query.M365BackupStorageObjectRestorePoints,
                Query.M365BackupStorageObjectRestorePointsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# REQUIRED
$query.Var.m365BackupStorageObjectRestorePointsInput = @{
	# REQUIRED
	objectId = $someString
	# REQUIRED
	rangeFilter = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	restorePointTagType = @(
		$someRestorePointTagType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RestorePointTagType]) for enum values.
	)
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // m365DayToDayModeStats(orgId: UUID!, dashboardWorkloadType: M365DashboardWorkloadType!): DayToDayModeStats!
        internal void InitQueryM365DayToDayModeStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("dashboardWorkloadType", "M365DashboardWorkloadType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365DayToDayModeStats",
                "($orgId: UUID!,$dashboardWorkloadType: M365DashboardWorkloadType!)",
                "DayToDayModeStats",
                Query.M365DayToDayModeStats,
                Query.M365DayToDayModeStatsFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString
# REQUIRED
$query.Var.dashboardWorkloadType = $someM365DashboardWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.M365DashboardWorkloadType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // m365DirectoryObjectAttributes(input: ListM365DirectoryObjectAttributesInput!): ListO365DirectoryObjectAttributesResp!
        internal void InitQueryM365DirectoryObjectAttributes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ListM365DirectoryObjectAttributesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365DirectoryObjectAttributes",
                "($input: ListM365DirectoryObjectAttributesInput!)",
                "ListO365DirectoryObjectAttributesResp",
                Query.M365DirectoryObjectAttributes,
                Query.M365DirectoryObjectAttributesFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	orgId = $someString
	# REQUIRED
	objectType = $someDirectoryObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DirectoryObjectType]) for enum values.
	# REQUIRED
	attributeType = $someAttributeType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AttributeType]) for enum values.
	# OPTIONAL
	searchTextPrefix = $someString
	# REQUIRED
	maxResults = $someInt
}"
            );
        }

        // Create new GraphQL Query:
        // m365LicenseEntitlement(orgID: UUID): M365LicenseEntitlementReply!
        internal void InitQueryM365LicenseEntitlement()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgID", "UUID"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365LicenseEntitlement",
                "($orgID: UUID)",
                "M365LicenseEntitlementReply",
                Query.M365LicenseEntitlement,
                Query.M365LicenseEntitlementFieldSpec,
                @"# OPTIONAL
$query.Var.orgID = $someString"
            );
        }

        // Create new GraphQL Query:
        // m365OnboardingModeBackupStats(orgId: UUID!, dashboardWorkloadType: M365DashboardWorkloadType!, backupStatsTimeRange: BackupStatsTimeRange!): OnboardingModeBackupStats!
        internal void InitQueryM365OnboardingModeBackupStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("dashboardWorkloadType", "M365DashboardWorkloadType!"),
                Tuple.Create("backupStatsTimeRange", "BackupStatsTimeRange!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365OnboardingModeBackupStats",
                "($orgId: UUID!,$dashboardWorkloadType: M365DashboardWorkloadType!,$backupStatsTimeRange: BackupStatsTimeRange!)",
                "OnboardingModeBackupStats",
                Query.M365OnboardingModeBackupStats,
                Query.M365OnboardingModeBackupStatsFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString
# REQUIRED
$query.Var.dashboardWorkloadType = $someM365DashboardWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.M365DashboardWorkloadType]) for enum values.
# REQUIRED
$query.Var.backupStatsTimeRange = $someBackupStatsTimeRange # Call [Enum]::GetValues([RubrikSecurityCloud.Types.BackupStatsTimeRange]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // m365OnboardingModeStats(orgId: UUID!, dashboardWorkloadType: M365DashboardWorkloadType!): OnboardingModeStats!
        internal void InitQueryM365OnboardingModeStats()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
                Tuple.Create("dashboardWorkloadType", "M365DashboardWorkloadType!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365OnboardingModeStats",
                "($orgId: UUID!,$dashboardWorkloadType: M365DashboardWorkloadType!)",
                "OnboardingModeStats",
                Query.M365OnboardingModeStats,
                Query.M365OnboardingModeStatsFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString
# REQUIRED
$query.Var.dashboardWorkloadType = $someM365DashboardWorkloadType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.M365DashboardWorkloadType]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // m365OrgBackupLocations(orgId: UUID!): M365OrgBackupLocations!
        internal void InitQueryM365OrgBackupLocations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365OrgBackupLocations",
                "($orgId: UUID!)",
                "M365OrgBackupLocations",
                Query.M365OrgBackupLocations,
                Query.M365OrgBackupLocationsFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // m365OrgOperationModes(orgId: UUID!): M365OrgOperationModes!
        internal void InitQueryM365OrgOperationModes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365OrgOperationModes",
                "($orgId: UUID!)",
                "M365OrgOperationModes",
                Query.M365OrgOperationModes,
                Query.M365OrgOperationModesFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // m365Regions(orgId: UUID!): M365RegionsResp!
        internal void InitQueryM365Regions()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("orgId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryM365Regions",
                "($orgId: UUID!)",
                "M365RegionsResp",
                Query.M365Regions,
                Query.M365RegionsFieldSpec,
                @"# REQUIRED
$query.Var.orgId = $someString"
            );
        }

        // Create new GraphQL Query:
        // searchM365BackupStorageObjectRestorePoints(searchM365BackupStorageObjectRestorePointsInput: M365BackupStorageObjectSearchRestorePointsInput!): SearchM365BackupStorageObjectRestorePointsResp!
        internal void InitQuerySearchM365BackupStorageObjectRestorePoints()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("searchM365BackupStorageObjectRestorePointsInput", "M365BackupStorageObjectSearchRestorePointsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySearchM365BackupStorageObjectRestorePoints",
                "($searchM365BackupStorageObjectRestorePointsInput: M365BackupStorageObjectSearchRestorePointsInput!)",
                "SearchM365BackupStorageObjectRestorePointsResp",
                Query.SearchM365BackupStorageObjectRestorePoints,
                Query.SearchM365BackupStorageObjectRestorePointsFieldSpec,
                @"# REQUIRED
$query.Var.searchM365BackupStorageObjectRestorePointsInput = @{
	# REQUIRED
	objectId = $someString
	# REQUIRED
	rangeFilter = @{
		# OPTIONAL
		fromTime = $someDateTime
		# OPTIONAL
		untilTime = $someDateTime
	}
	# OPTIONAL
	restorePointTagType = $someRestorePointTagType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RestorePointTagType]) for enum values.
	# OPTIONAL
	restorePointPreferenceType = $someRestorePointPreferenceType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RestorePointPreferenceType]) for enum values.
}"
            );
        }


    } // class New_RscQueryM365
}