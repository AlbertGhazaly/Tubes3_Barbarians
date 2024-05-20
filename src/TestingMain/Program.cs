using System;
using System.IO;
using LogicLibrary.Parser;
namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            string directoryPath = "Sample/";
            Console.WriteLine(rootDirectory);

            // Instantiate and use the BitmapParser class
            var bitmapParser = new BitmapParser(directoryPath);
            bitmapParser.ParseAllAndPrintASCII();


        }
    }
}