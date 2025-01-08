
// Get the base directory of the application
using System.Text;

string baseDirectory = AppContext.BaseDirectory;

// Navigate to the project's root folder
string? solutionPath = Directory.GetParent(baseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName;

string? projectRoot = Directory.GetParent(baseDirectory)?.Parent?.Parent?.Parent?.FullName;

if(string.IsNullOrEmpty(projectRoot) || string.IsNullOrEmpty(solutionPath))
{
    Console.WriteLine("Could not find the project root folder.");
    return;
}

// Combine the project root path with the target folder
string iconsFolder = Path.Combine(projectRoot, "Icons");

// Get the files in the "Icons" folder
var icons = Directory.GetFiles(iconsFolder);

var sb = new StringBuilder();
sb.AppendLine("using System;");
sb.AppendLine("namespace BootstrapIconsForDotNet");
sb.AppendLine("{");

sb.AppendLine("\tpublic static class Icons");
sb.AppendLine("\t{");

foreach (var icon in icons)
{
    var content = File.ReadAllText(icon);
    var fileInfo = new FileInfo(icon);
    var fileName = fileInfo.Name.Replace(".svg", "");
    fileName = fileName.Replace("-", "_").ToUpperInvariant();

    if (char.IsDigit(fileName[0])==true)
    {
        fileName = "_" + fileName;
    }
    if(content.StartsWith("<svg")==false)
    {
       continue;
    }

    if(content.EndsWith("</svg>") == false)
    {
        continue;
    }



    sb.AppendLine($"public const string {fileName} =\"\"\"\n{content}\n\"\"\";");
}

sb.AppendLine("\t}");

sb.AppendLine("}");
Console.WriteLine(icons.Count());

File.WriteAllText(Path.Combine(solutionPath, "BootstrapIconsForDotNet", "Icons.cs"), sb.ToString());
