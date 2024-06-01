using System;
using System.IO;
using LogicLibrary.Parser;
using System;
using System.Data.SqlClient;
namespace DBFingerBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            string sampleDirectoryPath = Path.Combine(rootDirectory, "Sample");
            Console.WriteLine(sampleDirectoryPath);
            BitmapParserBuilder bin = new BitmapParserBuilder(sampleDirectoryPath);
            bin.ParseMapAscii();

            Dictionary<int, FingerString> mapFingerString = bin.AsciiMap;




            /*Tinggal pake mapFingerString
             * FingerString itu ada 2 atribut
             * String ASCII
             * String Namafile
             * 
             * Nanti tinggal iterasi 10 fingerstring ke 1 orang yang sama dari database
             * 'Namafile' diubah aja jadi nama orang yang udah dibikin di faker
             * trus insert

             */

            /*====CONTOH PENGGUNAAN===
            foreach(var entry in mapFingerString)
            {
                FingerString fs = entry.Value;
                String ASCII = fs.AsciiString;
                String Namaorang = fs.FileName;

            }
            */

        }
    }
}
