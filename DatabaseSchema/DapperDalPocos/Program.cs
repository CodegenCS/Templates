using System.IO;
using System.Runtime.CompilerServices;
using CodegenCS;
using CodegenCS.Models.DbSchema;
using CodegenCS.Runtime;
using CodegenCS.IO;
using Newtonsoft.Json;
using System.Linq;

/// <summary>
/// This console application invokes the template DapperDalPocos.cs 
/// (loads a model, runs the template, and saves the generated files).
/// The generated files are ignored (treated as contents instead of code) unless you use RELEASE mode (useful to test the compilation of the generated files).
/// 
/// Basically this program will load a model from file, configure template options (like namespace), run the template, and save output files.
/// 
/// CodegenCS CLI Tool (dotnet-codegencs) can be used to extract/refresh a database model:
///     dotnet-codegencs model dbschema extract mssql "Server=MYSERVER; Database=AdventureWorks; User Id=myUsername;Password=MyPassword" AdventureWorks.json
///     dotnet-codegencs model dbschema extract mssql "Server=(local)\SQLEXPRESS; Database=AdventureWorks; Integrated Security=True" AdventureWorks.json
///     dotnet-codegencs model dbschema extract postgresql "Host=localhost; Database=Adventureworks; Username=postgres; Password=MyPassword" AdventureWorks.json
// 
/// CodegenCS CLI Tool (dotnet-codegencs) can also be used to invoke templates directly (instead of having a launcher program like this):
///     dotnet-codegencs template run DapperDalPocos.cs <DbSchema.json> <Namespace> [options]
///
/// Check out template code to see the available command-line options.
/// </summary>
internal class MyTemplate
{
    protected static string GetCurrentFolder([CallerFilePath] string path = null) => Path.GetDirectoryName(path);
    protected static string GetExePath([CallerFilePath] string path = null) => path;

    // Console app entrypoint. Launching the project from Visual Studio will start here.
    static void Main(string[] args)
    {
        var modelPath = Path.Combine(GetCurrentFolder(), @"..\SampleModels\AdventureWorksSchema.json");
        var model = JsonConvert.DeserializeObject<DatabaseSchema>(File.ReadAllText(modelPath));
        var ctx = new CodegenContext("DapperDalPocos.generated.cs");
        
        var templateOptions = new DapperPOCOGenerator.DapperPOCOGeneratorOptions()
        {
            Namespace = "MyNamespace",
            //CrudClass = "DataAccessLayer",
            //CrudFile = "DataAccessLayer.cs",
            //CrudNamespace = "MyNamespace.Crud",
        };

        //ctx.DefaultOutputFile.RelativePath = "MyPocos.cs"; templateOptions.SingleFile = true;  // generate everything in a single file

        var template = new DapperPOCOGenerator(new ColoredConsoleLogger(), templateOptions);

        // The method below is the Template entrypoint. CLI Tool (dotnet-codegencs) would start from this method (and do the rest)
        template.Render(ctx, model);

        if (ctx.OutputFiles.Count > 0 && ctx.Errors.Count == 0)
        {
            // Before saving the generated files we delete the previously generated files (to avoid conflicts)
            string outputFolder = Path.Combine(GetCurrentFolder(), @"Output\");
            if (Directory.Exists(outputFolder))
                Directory.GetFiles(outputFolder, "*.generated.cs", SearchOption.AllDirectories).ToList().ForEach(path => File.Delete(path));
            ctx.SaveToFolder(outputFolder);
        }
    }
}
