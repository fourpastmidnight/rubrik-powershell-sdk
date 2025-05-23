### ActiveDirectoryDomainControllerConnection
Paginated list of ActiveDirectoryDomainController objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of ActiveDirectoryDomainControllerEdges
  - List of ActiveDirectoryDomainController objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of ActiveDirectoryDomainControllers
  - List of ActiveDirectoryDomainController objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of ActiveDirectoryDomainController objects matching the request arguments.
