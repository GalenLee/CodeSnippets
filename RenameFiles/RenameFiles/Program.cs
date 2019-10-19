using System;
using System.IO;

namespace RenameFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"C:\_projects\AzureDevOps\_Temp", "*_.txt", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var newFile = file.Substring(0, file.Length - 5);
                File.Move(file, newFile);
                Console.WriteLine(newFile);
            }
        }
    }
}
