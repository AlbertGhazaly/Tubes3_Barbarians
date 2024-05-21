using System;
using System.IO;
using LogicLibrary.Parser;
using KMPSpace;
namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            string directoryPath = "Sample/";
            Console.WriteLine(rootDirectory);
            //H : 103, W : 96 - data dari sample asisten
            //var bitmapParser = new BitmapParserBuilder(directoryPath, 0, 96,0, 103);  //1 *32, 2* 16, 4* 8
            var sample = new BitmapParserBuilder(directoryPath, 33, 63, 46, 47); // buat sampel banding
            var bitmapParser = new BitmapParserBuilder(directoryPath);
            bitmapParser.ParseMapAscii();
            //bitmapParser.PrintBinaryAll();
            //bitmapParser.PrintAllMap();

            sample.ParseMapAscii();
            sample.PrintBinaryAll();
            sample.PrintAllMap();
            Dictionary<int, FingerString> asciiMap = sample.AsciiMap; // Build map , isi <int,FingerString>
            FingerString banding = asciiMap[1]; // sementara bandingin dari map juga, masalah input bmp nanti aja di UI
            banding.displayData();

            //FingerString tes = new FingerString("tes", "ABABAABA");
            //FingerString testarget = new FingerString("tes", "ABCABAB ABABABAABAC");
            //Dictionary<int, FingerString> tesmap = new Dictionary<int, FingerString>();
            //tesmap.Add(1, testarget);
            KMP kmp = new KMP(bitmapParser.AsciiMap, banding);
            kmp.searchKMP();
            




        }
    }
}