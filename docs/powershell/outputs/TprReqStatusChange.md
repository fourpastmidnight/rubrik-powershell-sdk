### TprReqStatusChange
Change to the status of a TPR request.

- authorId: System.String
  - ID of the user making the change.
- authorName: System.String
  - Name of the user making the change.
- timestamp: DateTime
  - Time at which the change occurred.
- comment: System.String
  - Comment to include with the change.
- author: UserSummary
  - Summary of the author of the change request.
- changedPolicies: list of System.Strings
  - The policies that were approved, if applicable.
- operation: TprReqOperation
  - Operation performed on the request.
