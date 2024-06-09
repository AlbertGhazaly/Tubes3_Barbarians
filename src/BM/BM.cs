
using LogicLibrary.Parser;
namespace BMSpace
{
    public class BM
    {
        private Dictionary<int, FingerString> fingermap;
        private FingerString inputF;
        private int[] LastOcc;
        private List<FingerString> resultmatch;
        private bool isFound;


        public List<FingerString> Resultmatch
        {
            get { return resultmatch; }
            set { resultmatch = value; }
        }


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
        public bool IsFound
        {
            get { return isFound; }
            set { isFound = value; }
        }
        public void printHasil()
        {
            Console.WriteLine("=============BM==================");
            if (this.isFound)
            {
                Console.WriteLine("Hasil yang ditemukan:");
                foreach (var entry in resultmatch)
                {
                    Console.WriteLine($"Filename : {entry.FileName}");
                }

            }
            else
            {
                Console.WriteLine("Tidak ada hasil yang ditemukan!");

            }
        }


        public BM(Dictionary<int, FingerString> fm, FingerString inputF)
        {
            this.fingermap = fm;
            this.inputF = inputF;
            this.LastOcc = BuildLastOccurence(inputF.AsciiString);
            this.resultmatch = new List<FingerString>();
            this.isFound = false;

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
            foreach (var entry in fingermap)
            {
                // Console.WriteLine(x);
                // x++;
                string source = inputF.AsciiString;
                string target = entry.Value.AsciiString;
                // Console.WriteLine(inputF.FileName);
                // Console.WriteLine(entry.Value.FileName);
                //Console.WriteLine($" Source : {source} Target : {target}");
                int m = source.Length;
                int n = target.Length;
                int i = m - 1;

                if (i > n - 1)
                {
                    Console.WriteLine("source lebih panjang dari target!");
                    continue;
                }
                int j = m - 1;
                // int a = 0;
                do
                {
                    // Console.WriteLine($"Comparing: {source[j]} {target[i]}");
                    // if(a>2){
                    //   break;
                    // }
                    // a++;

                    if (source[j] == target[i])
                    {
                        if (j == 0)
                        {
                            //Console.WriteLine($"ditemukan di index {i}");
                            this.isFound = true;
                            resultmatch.Add(entry.Value);
                            break;
                        }
                        else
                        { // looking-glass technique
                            i--;
                            j--;
                        }
                    }
                    else
                    { // character jump technique
                        int lo = LastOcc[target[i]]; //last occ
                        i = i + m - Math.Min(j, 1 + lo);
                        j = m - 1;
                    }
                } while (i <= n - 1);
                continue; // no matches
            }
            printHasil();
        }
    }

}
