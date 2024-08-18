using CodegenCS;
using CodegenCS.IO;
using System.Runtime.CompilerServices;

namespace CodeGenerator;

internal class Program
{
    private static string GetDirectory([CallerFilePath] string sourceFilePath = "") => new FileInfo(sourceFilePath).Directory!.FullName;

    static void Main(string[] args)
    {
        Console.WriteLine("Generating files...");
        var context = new CodegenContext();
        new GeneratorTemplate().Main(context);
        context.SaveToFolder(Path.Combine(GetDirectory(), @"..\OneOf.ToTupleExtensions"));
        foreach (var file in context.OutputFiles)
            Console.WriteLine($"Generated {file.RelativePath}");
    }
}
