using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Barbarians.Parser;
using System.Diagnostics;

namespace Barbarians
{
    public partial class KMBPage
    {
        string imgPath;
        public KMBPage()
        {

            InitializeComponent();
            imgPath = null;
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private static string GetConnectionString(string port, string username, string password)
        {
            string connectionString = $"server={"localhost"};port={port ?? "3306"};user={username ?? "root"};password={password};database={"stima3"}";
            return connectionString;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "HASIL";
            PictureBox1.Image = null;
            PictureBox2.Image = null;
            imgPath = null;
            label3.Text = "Durasi: 0 ms";
            Label2.Text = "Kemiripan: 0%";
        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.Form1.Show();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KMB_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (PictureBox1 != null && this.imgPath != null)
            {
                string connectionString = GetConnectionString(MainPage.port, MainPage.username, MainPage.password);

                Console.WriteLine($"Connection String: {connectionString}");
                string rootDirectory = Directory.GetCurrentDirectory();
                Console.WriteLine(rootDirectory);
                string inputDirectoryPath = Path.Combine(rootDirectory, "Input");

                string rootProjectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
                string testDirectory = Path.Combine(rootProjectDirectory, "test");
                string sampleDirectory = Path.Combine(testDirectory, "Sample");
                /*var bitmapParser = new BitmapParserBuilder(sampleDirectory); //Kumpulan data Sample .BMP dari socofing*/

                //bitmapParser.PrintBinaryAll();
                //bitmapParser.PrintAllMap();
                var sample = new BitmapParserBuilder(imgPath, 32, 1); //fix 32 * 1 biar gampang matchingny
                sample.ParseMapAscii();
                //sample.PrintBinaryAll();
                //sample.PrintAllMap();


                FingerString banding = sample.AsciiMap[1]; // sementara bandingin dari map juga, masalah input bmp nanti aja di UI
                banding.displayData();
                BM bm = new BM(MainPage.bitmapParser.AsciiMap, banding);
                Stopwatch stopwatch = new Stopwatch();


                stopwatch.Start();
                bm.searchBM();
                stopwatch.Stop();

                string namadapat = "";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string sql = "SELECT * FROM sidik_jari WHERE berkas_citra = @berkascitra";
                        using (MySqlCommand command = new MySqlCommand(sql, connection))
                        {

                            if (bm.IsFound)
                            {
                                command.Parameters.AddWithValue("@berkascitra", bm.Resultmatch[0].FileName + ".BMP");
                                PictureBox2.Image = new System.Drawing.Bitmap(Path.Combine(sampleDirectory, (bm.Resultmatch[0].FileName + ".BMP")));
                                Label2.Text = "Kemiripan: 100%";
                                label3.Text = $"Durasi: {stopwatch.ElapsedMilliseconds}ms";
                            }
                            else // hamming
                            {
                                var fullsample = new BitmapParserBuilder(this.imgPath);
                                fullsample.ParseMapAscii();
                                Hamming.Hamming ham = new Hamming.Hamming(MainPage.bitmapParser.AsciiMap, fullsample.getFirstFingerString(), 70);
                                ham.searchHamming();
                                ham.writeResult();
                                command.Parameters.AddWithValue("@berkascitra", ham.getBestResult().FileName + ".BMP");
                                PictureBox2.Image = new System.Drawing.Bitmap(Path.Combine(sampleDirectory, (ham.getBestResult().FileName + ".BMP")));
                                Label2.Text = $"Kemiripan: {ham.getBestPercent().ToString("F2")}%";
                                label3.Text = $"Durasi: {stopwatch.ElapsedMilliseconds}ms";

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

                                    if (AlayMatcher.AlayMatcher.AlayMatch(namadapat, nama))
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
                                        richTextBox1.Text = $"HASIL\n" +
                                            $"NIK: {NIK} \n" +
                                            $"Tempat Lahir: {tempatLahir}\n" +
                                            $"Tanggal Lahir: {tanggalLahir.ToShortDateString()} \n" +
                                            $"Jenis Kelamin: {jenisKelamin}\n" +
                                            $"Golongan Darah: {golonganDarah}\n" +
                                            $"Alamat: {alamat}\n" +
                                            $"Agama: {agama}\n" +
                                            $"Status Perkawinan: {statusPerkawinan}\n" +
                                            $"Pekerjaan: {pekerjaan}\n" +
                                            $"Kewarganegaraan: {kewarganegaraan}\n";
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
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select the image file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            // Show the dialog and get result
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                PictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                this.imgPath = openFileDialog.FileName;
                MessageBox.Show("imgPath: " + openFileDialog.FileName);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PictureBox1.Image = null;
            this.imgPath = null;
        }
    }
}