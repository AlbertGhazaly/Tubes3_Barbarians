using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary.Parser;

namespace LogicLibrary.Hamming
{
    public class Hamming
    {
        private Dictionary<int, FingerString> fingermap;
        private FingerString inputF;
        public Hamming(Dictionary<int,FingerString> fm,FingerString f)
        {
            this.fingermap = fm;
            this.inputF = f;

        }
        public void searchHamming()
        {
            foreach(var entry in fingermap)
            {
                if(entry.Value.AsciiString.Length == inputF.AsciiString.Length)
                {
                    Console.WriteLine($"Banding {entry.Value.FileName} dengan {inputF.FileName} : ");
                    int totlength = entry.Value.AsciiString.Length;
                    int different = 0;

                    for(int i = 0; i < totlength; i++)
                    {
                        if (entry.Value.AsciiString[i] == inputF.AsciiString[i])
                        {
                            different++;
                        }

                    }
                    double persen = ((double)different/totlength) * 100;
                    Console.WriteLine($"Total perbedaan :  {persen:F2} %");

                }
                else
                {
                    Console.WriteLine($"Terdapat perbedaan panjang, tidak bisa hamming distance file {entry.Value.FileName} dengan {inputF.FileName}");

                }

            }

        }


    }
}
