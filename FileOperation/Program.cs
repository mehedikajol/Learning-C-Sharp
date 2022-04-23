using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var filepath = @"C:\Users\mehed\OneDrive\Documents\C-Sharp\DayNine\FileOperation\Sample.txt";
            var isExist = File.Exists(filepath);

            if (isExist)
            {
                var text = File.ReadAllText(filepath);
                Console.WriteLine(text);

                Console.WriteLine();

                var lines = File.ReadAllLines(filepath);
                foreach(var line in lines)
                    Console.WriteLine($"==={line}===");
            }
        }
    }
}
