using System;
using System.IO;
using LogicLibrary.Parser;
using KMPSpace;
using BMSpace;

namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(rootDirectory);
            string sampleDirectoryPath = Path.Combine(rootDirectory, "Sample");
            string inputDirectoryPath = Path.Combine(rootDirectory, "Input");
            /* Folder input waktu debugging disini
             * 
             * ..\src\TestingMain\bin\Debug\net8.0\Input  
             *  
             */
            string inputFilePath = Path.Combine(inputDirectoryPath, "2__F_Right_thumb_finger_Obl.BMP");

      
             
         
            var bitmapParser = new BitmapParserBuilder(sampleDirectoryPath); //Kumpulan data Sample .BMP dari socofing
            bitmapParser.ParseMapAscii();
            //bitmapParser.PrintBinaryAll();
            //bitmapParser.PrintAllMap();

            var sample = new BitmapParserBuilder(inputFilePath, 32, 1); //fix 32 * 1 biar gampang matchingny
            sample.ParseMapAscii();
            //sample.PrintBinaryAll();
            //sample.PrintAllMap();

   
            FingerString banding = sample.AsciiMap[1]; // sementara bandingin dari map juga, masalah input bmp nanti aja di UI
            banding.displayData();

   
            Dictionary<int, FingerString> tesmap = new Dictionary<int, FingerString>();
            KMP kmp = new KMP(bitmapParser.AsciiMap, banding);
            kmp.searchKMP();
            BM bm = new BM(bitmapParser.AsciiMap, banding);
            bm.searchBM();


            //BM bm2 = new BM(tesmap, tes);
            //bm2.searchBM();
            //KMP km2 = new KMP(tesmap, tes);
            //km2.searchKMP();
        }
    }
}
