using System;
using System.Collections.Generic;
using Barbarians.Parser;
using System.Linq; 
namespace Barbarians.Hamming
{
    public class Hamming
    {
        private Dictionary<int, FingerString> fingermap;
        private FingerString inputF;
        private List<Result> goodResults;
        private int tuningPersen;

        public Hamming(Dictionary<int, FingerString> fm, FingerString f,int tuningpersen)
        {
            this.fingermap = fm;
            this.inputF = f;
            this.goodResults = new List<Result>();
            this.tuningPersen = tuningpersen;
        }
        public double getBestPercent()
        {
            return goodResults.First().Percentage;
        }
        public void searchHamming()
        {
            foreach (var entry in fingermap)
            {
                if (entry.Value.AsciiString.Length == inputF.AsciiString.Length)
                {
                    int totlength = entry.Value.AsciiString.Length;
                    int different = 0;

                    for (int i = 0; i < totlength; i++)
                    {
                        if (entry.Value.AsciiString[i] == inputF.AsciiString[i])
                        {
                            different++;
                        }
                    }

                    double percent = ((double)different / totlength) * 100;
                    if (percent > this.tuningPersen)
                    {
                        goodResults.Add(new Result(entry.Value, percent));
                    }
                }
                else
                {
                    Console.WriteLine($"Length difference, cannot calculate Hamming distance between {entry.Value.FileName} and {inputF.FileName}");
                }
            }
            //sort
            goodResults.Sort((x, y) => y.Percentage.CompareTo(x.Percentage));
        }

        public void writeResult()
        {
            Console.WriteLine("===RESULTS ABOVE THRESHOLD===");
            foreach (var result in goodResults)
            {
                Console.WriteLine($"FileName: {result.FingerString.FileName}, Percentage: {result.Percentage}%");
            }
        }
        public FingerString getBestResult()
        {
            return goodResults.First().FingerString;
        }

        // Inner class to store the result
        private class Result
        {
            public FingerString FingerString { get; }
            public double Percentage { get; }

            public Result(FingerString fingerString, double percentage)
            {
                this.FingerString = fingerString;
                this.Percentage = percentage;
            }
        }
    }
}
