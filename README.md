**CodegenCS is a Toolkit for doing Code Generation using plain C#**.

Before anything else, don't forget to read read the [Main Project Page](https://github.com/CodegenCS/CodegenCS/) to learn the basics (basic idea, basic features, and major components).

This page is only about **CodegenCS Sample Templates**:
- If you are **writing a template** (code generator) and want to learn more about CodegenCS features (and internals) then check out the [CodegenCS Core Library](https://github.com/CodegenCS/CodegenCS/tree/master/src/Core/CodegenCS) documentation.
- If you want to **compile and run templates** or **reverse-engineer a database schema** check out the [`dotnet-codegencs documentation`](https://github.com/CodegenCS/CodegenCS/tree/master/src/dotnet-codegencs)
- If you want to **browse the sample templates** (POCO Generators, DAL generators, etc) this is the right place.


# CodegenCS Templates

This is the official repository for out-of-the-box templates. You can fork and modify these templates or you can create your own.

For instructions on how to use the templates below please refer to [dotnet-codegencs documentation](https://github.com/CodegenCS/CodegenCS/tree/master/src/dotnet-codegencs).

To learn more about how to modify the templates (and learn how to write clean and reusable templates using String Interpolation / Raw String Literals / IEnumerables) please check [CodegenCS Library documentation](https://github.com/CodegenCS/CodegenCS/tree/master/src/Core/CodegenCS).


# DatabaseSchema templates

[SimplePocos](./SimplePocos/SimplePocos.cs): Generates one POCO for each table. Can add attributes like [Table], [Key], [DatabaseGenerated], can override Equals() and GetHashCode(). Can generate all POCOs in a single file or each POCO in its own file

[DapperExtensionPocos](./DapperExtensionPocos/DapperExtensionPocos.cs): Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate CRUD extension methods (Insert/Update) using Dapper.

[DapperDalPocos](./DapperDalPocos/DapperDalPocos.cs): Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate a Data Access Layer class with CRUD methods (Insert/Update) using Dapper.

[DapperActiveRecordPocos](./DapperActiveRecordPocos/DapperActiveRecordPocos.cs): Same as [SimplePocos](./SimplePocos/SimplePocos.cs), but will also generate Active Record pattern (Insert/Update methods inside the POCO) using Dapper.


# License
MIT License
