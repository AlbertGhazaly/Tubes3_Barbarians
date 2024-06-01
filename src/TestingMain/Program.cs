using System;
using System.IO;
using LogicLibrary.Parser;
using KMPSpace;
using BMSpace;
using LogicLibrary.Hamming;
using LogicLibrary.AlayMatcher;

namespace TestMain
{
    class Program
    {
        static List<string> ReadFileIntoList(string filename)
        {
            try
            {
                // Read all lines from the file and return as a list of strings
                return new List<string>(File.ReadAllLines(filename));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {filename} not found.");
                return new List<string>();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading file {filename}: {ex.Message}");
                return new List<string>();
            }
        }
        static void Main(string[] args)
        {
            List<string> namaAsli = ReadFileIntoList("nama.txt");
            List<string> namaAlay = ReadFileIntoList("output.txt");
            int cnt = 0;
            for (int i =0; i<namaAsli.Count; i++){
                // AlayMatch(namaAsli[i], namaAlay[i]);
                if(AlayMatch(namaAsli[i], namaAlay[i])){
                    cnt++;
                }
            }
            Console.WriteLine($"Jumlah cocok: {cnt}");
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
            var fullsample = new BitmapParserBuilder(inputFilePath);
            fullsample.ParseMapAscii();
            Hamming ham = new Hamming(bitmapParser.AsciiMap, fullsample.AsciiMap[1],50);
            ham.searchHamming();


            //BM bm2 = new BM(tesmap, tes);
            //bm2.searchBM();
            //KMP km2 = new KMP(tesmap, tes);
            //km2.searchKMP();
        }
    }
}
