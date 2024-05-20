using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace LogicLibrary.Parser
{
    public class BitmapParser
    {
        private string _directoryPath;

        public BitmapParser(string directoryPath)
        {
            _directoryPath = directoryPath;
        }

        public void ParseAllAndPrintASCII()

        {
            Console.WriteLine(this._directoryPath);
            string[] bmpFiles = Directory.GetFiles(_directoryPath, "*.BMP");

            foreach (string filePath in bmpFiles)
            {
                Console.WriteLine($"Processing file: {Path.GetFileName(filePath)}");
                using (Image<Rgba32> image = Image.Load<Rgba32>(filePath))
                {
                    string bitString = ParseBits(image);
                    string asciiString = ConvertBitsToAscii(bitString);
                    Console.WriteLine(asciiString);
                }
            }
        }

        private string ParseBits(Image<Rgba32> image)
        {
            using (var clone = image.CloneAs<Rgba32>())
            {
                var bitStringBuilder = new System.Text.StringBuilder();

                for (int y = 0; y < clone.Height; y++)
                {
                    for (int x = 0; x < clone.Width; x++)
                    {
                        Rgba32 pixel = clone[x, y];
                        double luminance = CalculateLuminance(pixel);

                        if (luminance > 128)
                        {
                            bitStringBuilder.Append("1");
                        }
                        else
                        {
                            bitStringBuilder.Append("0");
                        }
                    }
                }

                return bitStringBuilder.ToString();
            }
        }

        private string ConvertBitsToAscii(string bitString)
        {
            var asciiStringBuilder = new System.Text.StringBuilder();

            for (int i = 0; i < bitString.Length; i += 8)
            {
                string byteString = bitString.Substring(i, Math.Min(8, bitString.Length - i));
                if (byteString.Length < 8)
                {
                    byteString = byteString.PadRight(8, '0');
                }
                int asciiValue = Convert.ToInt32(byteString, 2);
                asciiStringBuilder.Append((char)asciiValue);
            }

            return asciiStringBuilder.ToString();
        }

        private double CalculateLuminance(Rgba32 color)
        {
            return 0.299 * color.R + 0.587 * color.G + 0.114 * color.B;
        }
    }
}
