using System;
using System.IO;
using LogicLibrary.Parser;
using KMPSpace;
using BMSpace;
using MySql.Data.MySqlClient;
using LogicLibrary.Hamming;
using LogicLibrary.AlayMatcher;

namespace TestMain
{
    class Program
    {
        static List<string> ReadFileIntoList(string filename)
        {
            try
            {
                // Read all lines from the file and return as a list of strings
                return new List<string>(File.ReadAllLines(filename));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {filename} not found.");
                return new List<string>();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading file {filename}: {ex.Message}");
                return new List<string>();
            }
        }
        static void Main(string[] args)
        {
            //List<string> namaAsli = ReadFileIntoList("nama.txt");
            //List<string> namaAlay = ReadFileIntoList("output.txt");
            //int cnt = 0;
            //for (int i = 0; i < namaAsli.Count; i++)
            //{
            //    // AlayMatch(namaAsli[i], namaAlay[i]);
            //    if (AlayMatch(namaAsli[i], namaAlay[i]))
            //    {
            //        cnt++;
            //    }
            //}
            //Console.WriteLine($"Jumlah cocok: {cnt}");

            string connectionString = InitInputConnection();

            Console.WriteLine($"Connection String: {connectionString}");
            string rootDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(rootDirectory);
            string inputDirectoryPath = Path.Combine(rootDirectory, "Input");
       
            string rootProjectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName;
            string testDirectory = Path.Combine(rootProjectDirectory, "test");
            string sampleDirectory = Path.Combine(testDirectory, "Sample");
            string inputDirectory = Path.Combine(testDirectory, "Input");




            string inputFilePath = Path.Combine(inputDirectory, "tes1.BMP"); // ceritanya input

      

            var bitmapParser = new BitmapParserBuilder(sampleDirectory); //Kumpulan data Sample .BMP dari socofing
            bitmapParser.ParseMapAscii();
            //bitmapParser.PrintBinaryAll();
            //bitmapParser.PrintAllMap();

            var sample = new BitmapParserBuilder(inputFilePath, 32, 1); //fix 32 * 1 biar gampang matchingny
            sample.ParseMapAscii();
            //sample.PrintBinaryAll();
            //sample.PrintAllMap();

   
            FingerString banding = sample.AsciiMap[1]; // sementara bandingin dari map juga, masalah input bmp nanti aja di UI
            banding.displayData();

   
          
            KMP kmp = new KMP(bitmapParser.AsciiMap, banding);
            kmp.searchKMP();
            BM bm = new BM(bitmapParser.AsciiMap, banding);
            bm.searchBM();

       
                string namadapat = "";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string sql = "SELECT * FROM sidik_jari WHERE berkas_citra = @berkascitra";
                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {
                        if (kmp.IsFound)
                        {
                            command.Parameters.AddWithValue("@berkascitra", kmp.Resultmatch[0].FileName + ".BMP");
                        }
                        else if (bm.IsFound) 
                        {
                            command.Parameters.AddWithValue("@berkascitra", bm.Resultmatch[0].FileName + ".BMP");

                        }
                        else // hamming
                        {
                            var fullsample = new BitmapParserBuilder(inputFilePath);
                            fullsample.ParseMapAscii();
                            Hamming ham = new Hamming(bitmapParser.AsciiMap, fullsample.getFirstFingerString(), 70);
                            ham.searchHamming();
                            ham.writeResult();
                            command.Parameters.AddWithValue("@berkascitra", ham.getBestResult().FileName + ".BMP");
                        }
                        using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    namadapat = reader.GetString("nama");

                                    Console.WriteLine($"Nama yang ditemukan : {namadapat}");
                                }
                                else
                                {
                                    Console.WriteLine("Data tidak ditemukan.");
                                }

                            }

                        }
                        sql = "SELECT * FROM biodata";

                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    
                                    string nama = reader.GetString("nama");
                                    
                                    if(AlayMatcher.AlayMatch(namadapat, nama))
                                    {
                                        string NIK = reader.GetString("NIK");
                                        string tempatLahir = reader.GetString("tempat_lahir");
                                        DateTime tanggalLahir = reader.GetDateTime("tanggal_lahir");
                                        string jenisKelamin = reader.GetString("jenis_kelamin");
                                        string golonganDarah = reader.GetString("golongan_darah");
                                        string alamat = reader.GetString("alamat");
                                        string agama = reader.GetString("agama");
                                        string statusPerkawinan = reader.GetString("status_perkawinan");
                                        string pekerjaan = reader.GetString("pekerjaan");
                                        string kewarganegaraan = reader.GetString("kewarganegaraan");
                                        Console.WriteLine($"NIK: {NIK}, Nama: {nama}, Tempat Lahir: {tempatLahir}, Tanggal Lahir: {tanggalLahir.ToShortDateString()}, Jenis Kelamin: {jenisKelamin}, Golongan Darah: {golonganDarah}, Alamat: {alamat}, Agama: {agama}, Status Perkawinan: {statusPerkawinan}, Pekerjaan: {pekerjaan}, Kewarganegaraan: {kewarganegaraan}");
                                    }
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 0)
                        {
                            Console.WriteLine("Koneksi ditolak. Periksa kembali informasi koneksi Anda.");
                        }
                        else
                        {
                            Console.WriteLine($"Terjadi kesalahan MySQL: {ex.Message}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                    }
                }

            


            

        }
        private static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, (password.Length - 1));
                    Console.Write("\b \b");
                }
            }
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();

            return password;
        }

        private static string InitInputConnection()
        {

            Console.Write("Masukkan hostname atau IP server MySQL (default: localhost): ");
            string server = Console.ReadLine();

            Console.Write("Masukkan port MySQL (default: 3306): ");
            string port = Console.ReadLine();

            Console.Write("Masukkan nama database: ");
            string databaseName = Console.ReadLine();

            Console.Write("Masukkan username(default: root): ");
            string username = Console.ReadLine();

            Console.Write("Masukkan password: ");
            string password = ReadPassword();

            return GetConnectionString(server, port, databaseName, username, password);
        }

        private static string GetConnectionString(string server, string port, string databaseName, string username, string password)
        {
            string connectionString = $"server={server ?? "localhost"};port={port ?? "3306"};user={username ?? "root"};password={password};database={databaseName}";
            return connectionString;
        }
    }

}
