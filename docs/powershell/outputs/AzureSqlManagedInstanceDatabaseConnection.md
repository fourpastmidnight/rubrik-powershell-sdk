### AzureSqlManagedInstanceDatabaseConnection
Paginated list of AzureSqlManagedInstanceDatabase objects. Each page of the results includes at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- edges: list of AzureSqlManagedInstanceDatabaseEdges
  - List of AzureSqlManagedInstanceDatabase objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: list of AzureSqlManagedInstanceDatabases
  - List of AzureSqlManagedInstanceDatabase objects.
- pageInfo: PageInfo
  - General information about this result page.
- count: System.Int32
  - Total number of AzureSqlManagedInstanceDatabase objects matching the request arguments.
