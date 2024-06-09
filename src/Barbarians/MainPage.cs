using Barbarians.Parser;
using MySqlX.XDevAPI.Common;
using System;
using System.IO;
using System.Windows.Forms;
namespace Barbarians
{
    public partial class MainPage
    {
        public static string username;
        public static string password;
        public static string port;
        public static BitmapParserBuilder bitmapParser;
        public MainPage()
        {
            InitializeComponent();
            string rootProjectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string testDirectory = Path.Combine(rootProjectDirectory, "test");
            string sampleDirectory = Path.Combine(testDirectory, "Sample");
            bitmapParser = new BitmapParserBuilder(sampleDirectory);
            bitmapParser.ParseMapAscii();
            textBox1.Text = "username";
            textBox2.Text = "password";
            textBox3.Text = "port";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.KMB.Show();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.BM.Show();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.KMB.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.BM.Show();

        }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MainPage.username = textBox1.Text;
            MainPage.password = textBox2.Text;
            MainPage.port = textBox3.Text;
            MessageBox.Show("username: "+ MainPage.username + " password: " + MainPage.password + " port: "+ MainPage.port);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}