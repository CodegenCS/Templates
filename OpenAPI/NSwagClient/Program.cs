using CodegenCS;
using CodegenCS.IO;
using CodegenCS.Models.NSwagAdapter;
using NSwag;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NSwagClient;

/// <summary>
/// This console application invokes the template NSwagClient.cs 
/// (loads a model, runs the template, and saves the generated files).
/// The generated files are ignored (treated as contents instead of code) unless you use RELEASE mode (useful to test the compilation of the generated files).
/// 
/// Basically this program will load a model from file, configure template options (like namespace), run the template, and save output files.
/// 
/// CodegenCS CLI Tool (dotnet-codegencs) can also be used to invoke templates directly (instead of having a launcher program like this):
///     dotnet-codegencs template run NSwagClient.cs <OpenApiSpec.json> <Namespace> [options]
///
/// Check out template code to see the available command-line options.
/// </summary>
internal class MyTemplate
{
    protected static string GetCurrentFolder([CallerFilePath] string path = null) => Path.GetDirectoryName(path);

    // Console app entrypoint. Launching the Template Project from Visual Studio will start here.
    static void Main(string[] args)
    {
        var modelPath = Path.Combine(GetCurrentFolder(), @"..\SampleModels\petstore-openapi3.json");
        var model = (OpenApiDocument)new OpenApiDocumentAdapter().LoadFromContentAsync(File.ReadAllText(modelPath), modelPath).GetAwaiter().GetResult();
        var ctx = new CodegenContext();

        var template = new NSwagClient();
        ctx.DefaultOutputFile.RelativePath = new FileInfo(modelPath).Name.Replace(".json",".cs");

        // The method below is the Template entrypoint. CLI Tool (dotnet-codegencs) would start from this method (and do the rest)
        template.TemplateMain(ctx, model, new NSwagClient.NSwagClientOptions() { Namespace = "MyProject.NSwagClients" });

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
