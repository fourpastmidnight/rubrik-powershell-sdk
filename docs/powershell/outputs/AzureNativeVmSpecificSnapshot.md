### AzureNativeVmSpecificSnapshot
Azure VM-specific snapshot information.

- osDiskSnapshot: AzureNativeAttachedDiskSpecificSnapshot
  - OS disk snapshot attached to the Azure VM.
- dataDiskSnapshots: list of AzureNativeAttachedDiskSpecificSnapshots
  - List of data disk snapshots attached to the Azure VM.
- isSnapshotAdeEnabled: System.Boolean
  - Specifies whether the snapshot has ADE extension enabled.
- snapshotId: System.String
  - ID of the snapshot.
