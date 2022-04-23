using System.IO;
using System.Text;

namespace FileWrite
{
    public class Program
    {
        static void Main(string[] args)
        {
            var writePath = @"C:\Users\mehed\OneDrive\Documents\C-Sharp\DayTen\FileWrite\WriteFile.txt";
            var content = "Hello from FileWrite learning";
            File.WriteAllText(writePath, content);

            using var writer = File.OpenWrite(writePath);

            var writePath2 = @"C:\Users\mehed\OneDrive\Documents\C-Sharp\DayTen\FileWrite\WriteFile2.txt";
            var content2 = "This is not so fun learning C-Sharp";
            File.WriteAllText(writePath2, content2);
            var bytes = Encoding.ASCII.GetBytes(content2);
            writer.Write(bytes);

        }
    }
}