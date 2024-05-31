
using LogicLibrary.Parser;
using System.Linq;
namespace KMPSpace
{
    public class KMP
    {
        private Dictionary<int, FingerString> fingermap;
        private FingerString inputF;
        private List<int> borderfunc;
        private List<FingerString> resultmatch;
        private bool isFound;

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

        public List<int> Borderfunc
        {
            get { return borderfunc; }
            set { borderfunc = value; }
        }
        public List<FingerString> Resultmatch
        {
            get { return resultmatch; }
            set { resultmatch = value; }
        }

        public KMP(Dictionary<int, FingerString> fm, FingerString inputF) { 
            this.fingermap = fm;
            this.inputF = inputF;
            this.borderfunc = Enumerable.Repeat(0, inputF.AsciiString.Length).ToList();
            this.isFound = false;
            this.resultmatch = new List<FingerString>();

        }    


        public void searchKMP()
        {
            initBorderFunc();
            foreach (var entry in fingermap) {

                string source = inputF.AsciiString;
                string target = entry.Value.AsciiString;
                //Console.WriteLine($" Source : {source} Target : {target}");
                int i = 0;
                int j = 0;
                while(j < borderfunc.Count && i < target.Length)
                {
                    //Console.WriteLine($"i = {i} dan j = {j}  | banding {source[j]} dengan {target[i]}" );
                   
                    if (source[j] == target[i]) 
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        if (source[j] != target[i] && j > 0)
                        {
                            j = borderfunc[j - 1];
                        }
                        else// j<=0
                        {
                            j = 0;
                            i++;

                        }
                    }

                }
                if(j != borderfunc.Count)
                {
                }
                else
                {
                    resultmatch.Add(entry.Value);
                    isFound = true;
                }



            }
            printHasil();

        }
        public void printHasil()
        {
            Console.WriteLine("=============KMP==================");
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
        public void initBorderFunc()
        {
            string word = inputF.AsciiString;
            int idx = 0;
            int streak = 0;
            int j = 1;
            while(j < word.Length)
            {
                if (word[idx] == word[j])
                {
                    Console.WriteLine(j);
                    idx++;
                    j++;
                    streak++;
                    borderfunc[j-1] = streak;
                    


                }
                else if (word[idx] != word[j] && idx > 0)
                {
                    streak = 0;
                    idx = borderfunc[idx - 1];

                }
                else
                {
                    streak = 0;
                    idx = borderfunc[0];
                    j++;

                }

            }
            //PrintBorderFunc();


        }
        public void PrintBorderFunc()
        {
            Console.WriteLine("Border Function Values:");
            for (int i = 0; i < borderfunc.Count; i++)
            {
                Console.WriteLine($"borderfunc[{i}] = {borderfunc[i]}");
            }
        }


    }
}
