using System;
using LogicLibrary.Parser;
using MySql.Data.MySqlClient;
using KMPSpace;
using BMSpace;

namespace SqlDataAccessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace with your actual connection string
            string connectionString = "server=localhost;port=3307;user=root;password=180401;database=tes2;";
            Dictionary<int, FingerString> fingerStringMap = new Dictionary<int, FingerString>();
            string rootDirectory = Directory.GetCurrentDirectory();
            string inputDirectoryPath = Path.Combine(rootDirectory, "Input");
       
            string inputFilePath = Path.Combine(inputDirectoryPath, "227__M_Left_thumb_finger.BMP");
            BitmapParserBuilder sample = new BitmapParserBuilder(inputFilePath, 32, 1);
            sample.ParseMapAscii();
            FingerString fn = sample.AsciiMap[1];

            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Example query to select data from a table
                    string query = "SELECT * FROM sidik_jari";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int index = 0;
                            while (reader.Read())
                            {
                                string fileName = reader["nama"].ToString();
                                string asciiString = reader["berkas_citra"].ToString();

                                // Create a new FingerString object and add it to the dictionary
                                FingerString fingerString = new FingerString(fileName, asciiString);
                                fingerStringMap.Add(index, fingerString);

                                index++;
                            }
                        }
                    }
                }

                // Display data from the dictionary
                foreach (var kvp in fingerStringMap)
                {
                    //Console.WriteLine($"Index: {kvp.Key}");
                    //Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            KMP kmp = new KMP(fingerStringMap,fn);
            kmp.searchKMP();
            BM bm = new BM(fingerStringMap, fn);
            bm.searchBM();




        }
    }
}
