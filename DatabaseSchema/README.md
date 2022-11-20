**CodegenCS is a Toolkit for doing Code Generation using plain C#**.

Before anything else, don't forget to read read the [Main Project Page](https://github.com/CodegenCS/CodegenCS/) to learn the basics (basic idea, basic features, and major components).

This page is only about **CodegenCS Sample Templates based on DatabaseSchema**:

# [SimplePocos](./SimplePocos/SimplePocos.cs)

Generates one POCO for each table. 

- Can add attributes like [Table], [Key], [DatabaseGenerated]
- Can override Equals() and GetHashCode()
- Can generate all POCOs in a single file or each POCO in its own file

# [DapperExtensionPocos](./DapperExtensionPocos/DapperExtensionPocos.cs)

Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate **CRUD static extension methods** (Insert/Update) using Dapper.

# [DapperDalPocos](./DapperDalPocos/DapperDalPocos.cs)

Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate a **Data Access Layer class with CRUD methods** (Insert/Update) using Dapper.

# [DapperActiveRecordPocos](./DapperActiveRecordPocos/DapperActiveRecordPocos.cs)

Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate **CRUD using Active Record pattern** (Insert/Update methods inside the POCO) using Dapper.
