﻿using System;
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
            var deleteFilePath = @"C:\Users\mehed\OneDrive\Documents\C-Sharp\DayNine\FileOperation\Delete.txt";
            var isDeleteExist = File.Exists(deleteFilePath);
            File.Create(@"C:\Users\mehed\OneDrive\Documents\C-Sharp\DayNine\FileOperation\NewFile.txt");

            if (isExist)
            {
                var text = File.ReadAllText(filepath);
                Console.WriteLine(text);

                Console.WriteLine();

                var lines = File.ReadAllLines(filepath);
                foreach (var line in lines)
                    Console.WriteLine($"==={line}===");

                Console.WriteLine();
            }

            if (isDeleteExist)
                File.Delete(deleteFilePath);
            else
                Console.WriteLine("File does not exist to be deleted!");

            var fileInfo = new FileInfo(filepath);
            if (fileInfo.Exists)
            {
                var text = fileInfo.Open(FileMode.Open);
                Console.WriteLine(text);
            }

            /*try
            {
                File.Delete(deleteFilePath);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                Console.WriteLine("Operation done!");
            }*/
        }
    }
}
