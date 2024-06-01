using System;
using System.Collections.Generic;
using System.IO;
using MySql.Data.MySqlClient;
using LogicLibrary.Parser;

namespace DBFingerBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = Directory.GetCurrentDirectory();
            string sampleDirectoryPath = Path.Combine(rootDirectory, "Sample");
            string namaDirectoryPath = Path.Combine(rootDirectory, "name");
            Console.WriteLine(sampleDirectoryPath);

            BitmapParserBuilder bin = new BitmapParserBuilder(sampleDirectoryPath);
            bin.ParseMapAscii();
            List<string> lines = new List<string>(File.ReadAllLines(Path.Combine(namaDirectoryPath, "nama2.txt")));
            List<string> linesOld = new List<string>(File.ReadAllLines(Path.Combine(namaDirectoryPath, "nama.txt")));

            Dictionary<int, FingerString> mapFingerString = bin.AsciiMap;

            string connectionString = "server=localhost;database=tubes3_stima24;user=root;password=26032006;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Database connection successful!");
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string newName = lines[i];
                        string oldName = linesOld[i];
                        cmd.CommandText = "UPDATE biodata SET nama = @newName WHERE nama = @oldName";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@newName", newName);
                        cmd.Parameters.AddWithValue("@oldName", oldName); // replace with the old name you want to update

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            Console.WriteLine($"Updated {rowsAffected} rows for {newName}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error updating {newName}: {ex.Message}");
                        }
                    }

                }
            }
        }
    }
}


    
/*    cmd.CommandText = "INSERT INTO sidik_jari (nama, berkascitra) VALUES (@nama, @berkascitra)";
                    for (int i = 0; i<lines.Count && i<mapFingerString.Count; i++)
                    {
                        string nama = linesOld[i];
                        for (int j = 0; j< 10; j++)
                        {
                            FingerString fingerString = mapFingerString[i * 10 + (j + 1)];
    string berkascitra = fingerString.AsciiString;

    cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@nama", nama);
                            cmd.Parameters.AddWithValue("@berkascitra", berkascitra);

                            try
                            {
                                cmd.ExecuteNonQuery();
                                Console.WriteLine($"Inserted: {nama} - {berkascitra.Substring(0, Math.Min(berkascitra.Length, 50))}...");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error inserting {nama}: {ex.Message}");
                            }
                        }

                    }
                }*/