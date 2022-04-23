using System;
using System.IO;

namespace DirectoryOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory(); 
            Console.WriteLine(currentDirectory);

            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
            var filepath = directoryInfo.FullName;
            var filepathP = directoryInfo.Parent.FullName;
            var filepathPP = directoryInfo.Parent.Parent.FullName;
            var filepathPPP = directoryInfo.Parent.Parent.Parent.FullName;
            var fileName = filepathPPP + @"\newText.txt";
            var newFileName = Path.Combine(filepathPPP, "newFile.txt");

            Console.WriteLine(filepath);
            Console.WriteLine(filepathP);
            Console.WriteLine(filepathPP);
            Console.WriteLine(filepathPPP);

            File.WriteAllText(fileName, "Hello from Directory Operation");
            File.WriteAllText(newFileName, "Hello from Path.Combine file");
            Console.WriteLine();

            var files = directoryInfo.Parent.Parent.Parent.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine($"Name: {file}, Size: {file.Length}, {file.GetHashCode()}");
            }
        }
    }
}


