using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Barbarians.Parser
{
    public class BitmapParserBuilder
    {
        private int left_x;
        private int left_y;
        private int right_x;
        private int right_y;
        private string _directoryPath;
        private System.Text.StringBuilder _bitStringBuilder;
        private System.Text.StringBuilder _asciiStringBuilder;
        private Dictionary<int, FingerString> _asciiMap;

        public BitmapParserBuilder(string directoryPath)
        {
            _directoryPath = directoryPath;
            left_x = 0;
            left_y = 0;

            // Initialize the size of the first image in the directory or file
            InitializeImageSize(directoryPath);

            _bitStringBuilder = new System.Text.StringBuilder();
            _asciiStringBuilder = new System.Text.StringBuilder();
            _asciiMap = new Dictionary<int, FingerString>();
            Console.WriteLine($"H : {right_y - left_y} L: {right_x - left_x}");
        }

        public BitmapParserBuilder(string directoryPath, int offsetX, int offsetY)
        {
            _directoryPath = directoryPath;

            InitializeImageSize(directoryPath);
            // Sample always taken as height / 2 and width divided by 2
            left_x = right_x / 2;
            left_y = right_y / 2;
            int startbit = right_x * (left_y - 1) + left_x;
            Console.WriteLine($"Sample must be multiple of 8 bits!, now taken from bit number-{startbit} bit or {right_x} * {left_y - 1} + {left_x}");
            // Handling if the input image starts from a non-multiple of 8
            if (startbit % 8 != 0)
            {
                Console.WriteLine("not a multiple of 8 bits!, will not succeed");
                Console.WriteLine($"must shift {startbit % 8} bits");
                left_x -= startbit % 8;
            }
            right_x = left_x + offsetX;
            right_y = left_y + offsetY;
            Console.WriteLine($"Pixels taken from Width {left_x} to {right_x} and Height from {left_y} to {right_y - 1}");

            _bitStringBuilder = new System.Text.StringBuilder();
            _asciiStringBuilder = new System.Text.StringBuilder();
            _asciiMap = new Dictionary<int, FingerString>();
            Console.WriteLine($"H : {right_y - left_y} L: {right_x - left_x}");
        }

        private void InitializeImageSize(string path)
        {
            if (File.Exists(path))
            {
                // The path is a single file
                using (Bitmap bitmap = new Bitmap(path))
                {
                    right_x = bitmap.Width;
                    right_y = bitmap.Height;
                }
            }
            else if (Directory.Exists(path))
            {
                // The path is a directory
                string[] bmpFiles = Directory.GetFiles(path, "*.BMP");
                if (bmpFiles.Length > 0)
                {
                    using (Bitmap bitmap = new Bitmap(bmpFiles[0]))
                    {
                        right_x = bitmap.Width;
                        right_y = bitmap.Height;
                    }
                }
                else
                {
                    throw new FileNotFoundException("No BMP files found in the specified directory.");
                }
            }
            else
            {
                throw new FileNotFoundException("The specified path is neither a valid file nor a directory.");
            }
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

        public FingerString getFirstFingerString()
        {
            return this.AsciiMap[1];
        }

        public void PrintBinaryAll()
        {
            Console.WriteLine(this._directoryPath);

            if (File.Exists(_directoryPath))
            {
                // Process single file
                ProcessSingleFile(_directoryPath);
            }
            else
            {
                // Process directory
                string[] bmpFiles = Directory.GetFiles(_directoryPath, "*.BMP");

                foreach (string filePath in bmpFiles)
                {
                    //Console.WriteLine($"Processing file: {Path.GetFileName(filePath)}");
                    using (Bitmap bitmap = new Bitmap(filePath))
                    {
                        PrintbinaryImage(bitmap);
                    }
                }
            }
        }

        public void ParseMapAscii()
        {
            Console.WriteLine(this._directoryPath);
            int fileId = 1; // File identification number

            if (File.Exists(_directoryPath))
            {
                // Process single file
                ProcessSingleFile(_directoryPath, fileId);
            }
            else
            {
                // Process directory
                string[] bmpFiles = Directory.GetFiles(_directoryPath, "*.BMP");

                foreach (string filePath in bmpFiles)
                {
                    ProcessSingleFile(filePath, fileId);
                    fileId++;
                }
            }
        }

        public void clearNullChar()
        {
            foreach (var item in this._asciiMap)
            {
                if (item.Value.AsciiString.Contains('\0'.ToString()))
                {
                    item.Value.AsciiString = item.Value.AsciiString.Replace('\0', '\x00');
                }
            }
        }

        private void ProcessSingleFile(string filePath, int fileId = 1)
        {
            //Console.WriteLine($"Processing file: {Path.GetFileName(filePath)}");
            using (Bitmap bitmap = new Bitmap(filePath))
            {
                //PrintbinaryImage(bitmap);
                //Console.WriteLine($"H : {right_y - left_y} L: {right_x - left_x}");
                string bitString = ParseBits(bitmap);
                ConvertBitsToAscii();
                string asciiString = _asciiStringBuilder.ToString();

                // Add ASCII print result to the map
                _asciiMap[fileId] = new FingerString(Path.GetFileNameWithoutExtension(filePath), asciiString);
            }
        }
        private void PrintbinaryImage(Bitmap bitmap)
        {
            for (int x = left_x; x < right_x; x++)
            {
                Console.Write(x % 10);
            }
            Console.WriteLine();

            for (int y = left_y; y < right_y; y++)
            {
                Console.Write($"{y} ");
                for (int x = left_x; x < right_x; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
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

        private string ParseBits(Bitmap bitmap)
        {
            _bitStringBuilder.Clear(); // Clear existing data

            for (int y = left_y; y < right_y; y++)
            {
                for (int x = left_x; x < right_x; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
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

        private double CalculateLuminance(Color color)
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

        public void PrintMap(int id)
        {
            Console.WriteLine("Print ASCII map id " + id);
            if (_asciiMap.ContainsKey(id))
            {
                FingerString value = _asciiMap[id];
                value.displayData();
            }
            else
            {
                Console.WriteLine("Key not found in the map.");
            }
        }
    }
}

