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

            var bitmapParser = new BitmapParserBuilder(directoryPath,0,4);
            bitmapParser.ParseMapAscii();
            //bitmapParser.PrintAllMap();
            
            Dictionary<int, FingerString> asciiMap = bitmapParser.AsciiMap; // Build map , isi <int,FingerString>
            FingerString banding = asciiMap[2]; // sementara bandingin dari map juga, masalah input bmp nanti aja di UI
            banding.displayData();




        }
    }
}