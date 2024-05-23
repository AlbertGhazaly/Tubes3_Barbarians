
using LogicLibrary.Parser;
using System.Linq;
using System;
namespace BMSpace
{
    public class BM
    {
        private Dictionary<int, FingerString> fingermap;
        private FingerString inputF;
        private int[] LastOcc;

        public Dictionary<int, FingerString> Fingermap
        {
            get { return fingermap; }
            set { fingermap = value; }
        }

        public FingerString InputF
        {
            get { return inputF; }
            set { inputF = value; }
        }


        public BM(Dictionary<int, FingerString> fm, FingerString inputF) { 
            this.fingermap = fm;
            this.inputF = inputF;
            this.LastOcc = BuildLastOccurence(inputF.AsciiString);

        }    
        private int[] BuildLastOccurence(string source)
        {
            int[] table = new int[256]; // Assume ASCII character set
            for (int i = 0; i < table.Length; i++)
                table[i] = source.Length;
            for (int i = 0; i < source.Length; i++)
                table[source[i]] = i;
            return table;
        }

        public void searchBM()
        {
            // int x =0;
            foreach (var entry in fingermap) {
                // Console.WriteLine(x);
                // x++;
                string source = inputF.AsciiString;
                string target = entry.Value.AsciiString;
                // Console.WriteLine(inputF.FileName);
                // Console.WriteLine(entry.Value.FileName);
                //Console.WriteLine($" Source : {source} Target : {target}");
                int m = source.Length;
                int n = target.Length;
                int i = m-1;

                if(i > n-1){
                    Console.WriteLine("source lebih panjang dari target!");
                    continue;
                }
                int j = m-1;
                // int a = 0;
                do {
                    // Console.WriteLine($"Comparing: {source[j]} {target[i]}");
                    // if(a>2){
                    //   break;
                    // }
                    // a++;

                    if (source[j] == target[i])
                    {
                        if (j == 0)
                        {
                            Console.WriteLine("Found!");
                            Console.WriteLine($"ditemukan di index {i}");
                            Console.WriteLine($"Nama file yang dicari {inputF.FileName} , dan tujuan : {entry.Value.FileName}");
                            break;
                        }
                        else 
                        { // looking-glass technique
                            i--;
                            j--;
                        }
                    }
                    else { // character jump technique
                        int lo = LastOcc[target[i]]; //last occ
                        i = i + m - Math.Min(j, 1+lo);
                        j = m - 1;
                    }
                    } while (i <= n-1);
                Console.WriteLine("Not Found!");
                continue; // no matches
            }
        }
    }
}
