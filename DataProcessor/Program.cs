using DataProcessor;
using static System.Console;

//Command line validation ommited for brevity
var command = args[0];


/* command --file in Debug properties
 *  --file c:\psdata\in\data1.txt or "commandLineArgs": "--file c:\\psdata\\in\\data1.txt"
 * 
 * commad --dir in Debug properties
 * --dir c:\psdata\in TEXT or "commandLineArgs": "--dir c:\\psdata\\in TEXT"
 */
if (command == "--file")
{
    var filePath = args[1];

    //Check if path is absolute
    if (!Path.IsPathFullyQualified(filePath))
    {
        WriteLine($"ERROR: path '{filePath}' must be fully qualified.");
        ReadLine();
        return;
    }
    WriteLine($"Single file {filePath} selected");
    ProcessSigleFile(filePath);

}
else if (command == "--dir")
{
    var directoryPath = args[1];
    var fileType = args[2];
    WriteLine($"Directory {directoryPath} selected for {fileType} files");
    ProcessDirectory(directoryPath, fileType);
}
else
{
    Write("Invalid command line options");
}
WriteLine("Press enter to quit.");
ReadLine();

static void ProcessSigleFile(string filePath)
{
    var fileProcessor = new FileProcessor(filePath);
    fileProcessor.Process();
}
static void ProcessDirectory(string directoryPath, string fileType)
{
    switch (fileType)
    {
        case "TEXT":
            string[] textFiles = Directory.GetFiles(directoryPath, "*.txt");
            foreach (var textFilePath in textFiles)
            {
                var fileProcessor = new FileProcessor(textFilePath);
                fileProcessor.Process();
            }
            break;
        default:
            WriteLine($"ERROR: {fileType} is not supported");
            return;
    }
}