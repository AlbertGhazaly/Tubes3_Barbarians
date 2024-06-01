using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Parser
{
    public class FingerString
    {
        public string FileName { get; set; }
        public string AsciiString { get; set; }

    
        public FingerString(string filename) { 
            FileName = filename;    
            AsciiString = filename;
        }
        public FingerString(string fileName, string asciiString)
        {
            FileName = fileName;
            AsciiString = asciiString;
        }
        public void displayData()
        {   
            Console.WriteLine($" Filename : {FileName} ");
            Console.WriteLine($" ASCII : {AsciiString} ");
            Console.WriteLine($"Banyaknya Char : {AsciiString.Length}");
        }
    }
}
