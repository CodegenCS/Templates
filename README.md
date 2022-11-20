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

[DatabaseSchema](https://github.com/CodegenCS/CodegenCS/tree/master/src/Models/CodegenCS.DbSchema/DbSchema) is our out-of-the-box template that represents the **schema of a relational database**.  

Currently it has tools to extract the model from a Microsoft SQL Server (MSSQL) or PostgreSQL.

Check out the [available DatabaseSchema Templates](./DatabaseSchema) which generate output based on a database schema.

# OpenAPI templates

[OpenAPI (Swagger) templates](https://github.com/CodegenCS/CodegenCS/tree/master/src/Models/CodegenCS.Models.NSwagAdapter) are read [using NSwag](https://github.com/RicoSuter/NSwag/) and can be used to generate templates based on OpenAPI (REST API) model.

Check out the [available OpenAPI Templates](./OpenAPI) which generate output based on a OpenAPI (Swagger) model.


# License
MIT License
