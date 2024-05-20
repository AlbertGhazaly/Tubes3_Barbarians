using System;
using System.Collections.Generic;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace LogicLibrary.Parser
{
    public class BitmapParserBuilder
    {
        private int height_offset;
        private int width_offset;
        private string _directoryPath;
        private System.Text.StringBuilder _bitStringBuilder;
        private System.Text.StringBuilder _asciiStringBuilder;
        private Dictionary<int, FingerString> _asciiMap;

        public BitmapParserBuilder(string directoryPath)
        {
            _directoryPath = directoryPath;
            height_offset = 0;
            width_offset = 0;
            _bitStringBuilder = new System.Text.StringBuilder();
            _asciiStringBuilder = new System.Text.StringBuilder();
            _asciiMap = new Dictionary<int, FingerString>();
        }

        public BitmapParserBuilder(string directoryPath, int height, int width)
        {
            _directoryPath = directoryPath;
            height_offset = height;
            width_offset = width;
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
                    Console.WriteLine($"H : {image.Height - height_offset} L: {image.Width - width_offset}");
                    string bitString = ParseBits(image);
                    ConvertBitsToAscii();
                    string asciiString = _asciiStringBuilder.ToString();

                    // Tambahkan hasil print ASCII ke dalam map
                    _asciiMap[fileId] = new FingerString(Path.GetFileNameWithoutExtension(filePath), asciiString);
                    fileId++;
                }
            }
        }
     


        private string ParseBits(Image<Rgba32> image)
        {
            using (var clone = image.CloneAs<Rgba32>())
            {
                _bitStringBuilder.Clear(); // Clear existing data
                for (int y = 0; y < clone.Height - height_offset; y++)
                {
                    for (int x = 0; x < clone.Width - width_offset; x++)
                    {
                        Rgba32 pixel = clone[x, y];
                        double luminance = CalculateLuminance(pixel);

                        if (luminance > 128)
                        {
                            _bitStringBuilder.Append("1");
                        }
                        else
                        {
                            _bitStringBuilder.Append("0");
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
