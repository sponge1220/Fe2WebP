// See https://aka.ms/new-console-template for more information

using ImageMagick;

Console.WriteLine("sourceDir:");
var directoryPath = Console.ReadLine();

if (directoryPath != null)
{
    ConvertPngToWebpInDirectory(directoryPath);
    UpdateImageReferences(directoryPath);
}

return;

static void ConvertPngToWebpInDirectory(string directoryPath)
{
    var imageFiles = Directory.EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories)
        .Where(file => file.EndsWith(".png") || file.EndsWith(".jpg") || file.EndsWith(".jpeg"));
    foreach (var file in imageFiles)
    {
        var webpPath = Path.ChangeExtension(file, ".webp");
        using (var image = new MagickImage(file))
        {
            image.Write(webpPath);
            Console.WriteLine($"success convert：{file} to {webpPath}");
        }
        // delete original file after conversion is complete
        File.Delete(file);
    }
}

static void UpdateImageReferences(string directoryPath)
{
    var htmlAndJsFiles = Directory.EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories)
        .Where(file => file.EndsWith(".html") || 
                       file.EndsWith(".js") || 
                       file.EndsWith(".jsx") || 
                       file.EndsWith(".tsx") || 
                       file.EndsWith(".storyJson") || 
                       file.EndsWith(".scss")
        );

    foreach (var file in htmlAndJsFiles)
    {
        var content = File.ReadAllText(file);
        var updatedContent = content.Replace(".png", ".webp")
            .Replace(".jpg", ".webp")
            .Replace(".jpeg", ".webp");
        File.WriteAllText(file, updatedContent);
        Console.WriteLine($"success convert references：{file}");
    }
}