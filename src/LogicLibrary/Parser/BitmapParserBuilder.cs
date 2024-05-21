using System;
using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace LogicLibrary.Parser
{
    public class BitmapParserBuilder
    {
        private int left_x; private int left_y; private int right_x; private int right_y;
        private string _directoryPath;
        private System.Text.StringBuilder _bitStringBuilder;
        private System.Text.StringBuilder _asciiStringBuilder;
        private Dictionary<int, FingerString> _asciiMap;

        public BitmapParserBuilder(string directoryPath)
        {
            _directoryPath = directoryPath;
            left_x = 0;
            left_y = 0;
            right_x = 96;
            right_y = 103;
            _bitStringBuilder = new System.Text.StringBuilder();
            _asciiStringBuilder = new System.Text.StringBuilder();
            _asciiMap = new Dictionary<int, FingerString>();
        }

        public BitmapParserBuilder(string directoryPath, int leftx, int rightx,int lefty,int righty)
        {
            _directoryPath = directoryPath;
            left_x = leftx;
            left_y = lefty;
            right_x = rightx;
            right_y = righty;
            _bitStringBuilder = new System.Text.StringBuilder();
            _asciiStringBuilder = new System.Text.StringBuilder();
            _asciiMap = new Dictionary<int, FingerString>();
        }

        public System.Text.StringBuilder BitStringBuilder
        {
            get { return _bitStringBuilder; }
            set { _bitStringBuilder = value; }
        }

        public System.Text.StringBuilder AsciiStringBuilder
        {
            get { return _asciiStringBuilder; }
            set { _asciiStringBuilder = value; }
        }

        public Dictionary<int, FingerString> AsciiMap
        {
            get { return _asciiMap; }
            set { _asciiMap = value; }
        }

        public void PrintBinaryAll()
        {
            Console.WriteLine(this._directoryPath);
            string[] bmpFiles = Directory.GetFiles(_directoryPath, "*.BMP");

            foreach (string filePath in bmpFiles)
            {
                Console.WriteLine($"Processing file: {Path.GetFileName(filePath)}");
                using (Image<Rgba32> image = Image.Load<Rgba32>(filePath))
                {
                    PrintbinaryImage(image);
                }
            }
        }
        public void ParseMapAscii()
        {
            Console.WriteLine(this._directoryPath);
            string[] bmpFiles = Directory.GetFiles(_directoryPath, "*.BMP");
            int fileId = 1; // Nomor identifikasi file

            foreach (string filePath in bmpFiles)
            {
                Console.WriteLine($"Processing file: {Path.GetFileName(filePath)}");
                using (Image<Rgba32> image = Image.Load<Rgba32>(filePath))
                {
                    Console.WriteLine($"H : {right_y - left_y} L: {right_x - left_x}");
                    string bitString = ParseBits(image);
                    ConvertBitsToAscii();
                    string asciiString = _asciiStringBuilder.ToString();

                    // Tambahkan hasil print ASCII ke dalam map
                    _asciiMap[fileId] = new FingerString(Path.GetFileNameWithoutExtension(filePath), asciiString);
                    fileId++;
                }
            }
        }


        private void PrintbinaryImage(Image<Rgba32> image) // buat milih pixel yg bagus
        {
            for (int x = left_x; x < right_x; x++)
            {
                Console.Write(x % 10);
            }
            Console.WriteLine();
            using (var clone = image.CloneAs<Rgba32>())
            {
               
                for (int y = left_y ; y < right_y; y++)
                {
                    Console.Write($"{y} ");
                    for (int x = left_x; x <  right_x; x++)
                    {
                        Rgba32 pixel = clone[x, y];
                        double luminance = CalculateLuminance(pixel);

                        if (luminance > 128)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("1");
                        }
                    }
                    Console.WriteLine();
                    
                    
                }

            }
        }
        private string ParseBits(Image<Rgba32> image)
        {
            using (var clone = image.CloneAs<Rgba32>())
            {
                _bitStringBuilder.Clear(); // Clear existing data
                for (int y = left_y; y <  right_y; y++)
                {
                    for (int x = left_x; x <  right_x; x++)
                    {
                        Rgba32 pixel = clone[x, y];
                        double luminance = CalculateLuminance(pixel);

                        if (luminance > 128)
                        {
                            _bitStringBuilder.Append("0");
                        }
                        else
                        {
                            _bitStringBuilder.Append("1");
                        }
                    }
                }

                return _bitStringBuilder.ToString();
            }
        }

        private void ConvertBitsToAscii()
        {
            _asciiStringBuilder.Clear(); // Clear existing data
            for (int i = 0; i < _bitStringBuilder.Length; i += 8)
            {
                string byteString = _bitStringBuilder.ToString().Substring(i, Math.Min(8, _bitStringBuilder.Length - i));
                if (byteString.Length < 8)
                {
                    byteString = byteString.PadRight(8, '0');
                }
                int asciiValue = Convert.ToInt32(byteString, 2);
                _asciiStringBuilder.Append((char)asciiValue);
            }
        }

        private double CalculateLuminance(Rgba32 color)
        {
            return 0.299 * color.R + 0.587 * color.G + 0.114 * color.B;
        }
        public void PrintAllMap()
        {
            Console.WriteLine("Printing ASCII Map:");
            foreach (var entry in _asciiMap)
            {
                Console.Write($"Key : {entry.Key}  | ");
                entry.Value.displayData();
                Console.WriteLine();
            }
        }
    }

    
}
