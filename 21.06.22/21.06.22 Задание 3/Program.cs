using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Compression;

namespace _21._06._22_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            Console.WriteLine(ReadAllText(path));
            string sourceFolder = "C:/Users/user/Desktop/1";
            string zipFile = "C:/Users/user/Desktop/1.zip";
            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
        }
        
        public static string ReadAllText(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                var encoding = new UTF8Encoding(true);
                var reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
        }
    }
}