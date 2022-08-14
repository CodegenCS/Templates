# CodegenCS Templates

[CodegenCS](https://github.com/CodegenCS/CodegenCS/) is a Toolkit for Code Generation. This repository is the official repository for templates but you can write your own templates.  

CodegenCS templates can read from any JSON input model, but currently the only out-of-the-box model is [DatabaseSchema](https://github.com/CodegenCS/CodegenCS/tree/master/src/CodegenCS.DbSchema/DbSchema) which represents the schema of a relational database. 

## DatabaseSchema templates

[SimplePocos](./SimplePocos/SimplePocos.cs): Generates one POCO for each table. Can add attributes like [Table], [Key], [DatabaseGenerated], can override Equals() and GetHashCode(). Can generate all POCOs in a single file or each POCO in its own file

[DapperExtensionPocos](./DapperExtensionPocos/DapperExtensionPocos.cs): Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate CRUD extension methods (Insert/Update) using Dapper.

[DapperDalPocos](./DapperDalPocos/DapperDalPocos.cs): Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate a Data Access Layer class with CRUD methods (Insert/Update) using Dapper.

[DapperActiveRecordPocos](./DapperActiveRecordPocos/DapperActiveRecordPocos.cs): Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate Active Record pattern (Insert/Update methods inside the POCO) using Dapper.

# How to Use
For instructions on how to use these templates please refer to [CodegenCS repository](https://github.com/CodegenCS/CodegenCS/).  

To learn more about how to write clean and reusable templates using String Interpolation / Raw String Literals / IEnumerables please check [CodegenCS Library documentation](https://github.com/CodegenCS/CodegenCS/tree/master/src/CodegenCS).

# License
MIT License
