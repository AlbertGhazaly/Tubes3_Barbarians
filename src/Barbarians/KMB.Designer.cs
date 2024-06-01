using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Barbarians
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class KMB : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(KMB));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Label1 = new Label();
            Label1.Click += new EventHandler(Label1_Click);
            PictureBox3 = new PictureBox();
            PictureBox3.Click += new EventHandler(PictureBox3_Click);
            Panel2 = new Panel();
            Button2 = new Button();
            Button1 = new Button();
            PictureBox1 = new PictureBox();
            Panel4 = new Panel();
            Button4 = new Button();
            RichTextBox2 = new RichTextBox();
            RichTextBox2.TextChanged += new EventHandler(RichTextBox2_TextChanged);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Panel3 = new Panel();
            Label2 = new Label();
            PictureBox2 = new PictureBox();
            PictureBox2.Click += new EventHandler(PictureBox2_Click);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel4.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(246, 70, 104);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(PictureBox3);
            Panel1.Location = new Point(2, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1987, 104);
            Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft YaHei UI", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.Window;
            Label1.Location = new Point(1432, 29);
            Label1.Name = "Label1";
            Label1.Size = new Size(415, 36);
            Label1.TabIndex = 1;
            Label1.Text = "Algoritma: Knuth-Morris-Pratt";
            // 
            // PictureBox3
            // 
            PictureBox3.Image = (Image)resources.GetObject("PictureBox3.Image");
            PictureBox3.InitialImage = (Image)resources.GetObject("PictureBox3.InitialImage");
            PictureBox3.Location = new Point(30, 10);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(97, 81);
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox3.TabIndex = 0;
            PictureBox3.TabStop = false;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(254, 150, 119);
            Panel2.Controls.Add(Button2);
            Panel2.Controls.Add(Button1);
            Panel2.Controls.Add(PictureBox1);
            Panel2.Location = new Point(108, 299);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(512, 519);
            Panel2.TabIndex = 1;
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(152, 64, 99);
            Button2.FlatAppearance.BorderSize = 0;
            Button2.FlatAppearance.MouseDownBackColor = Color.Violet;
            Button2.FlatAppearance.MouseOverBackColor = Color.Purple;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Font = new Font("Segoe UI", 8.0f);
            Button2.ForeColor = SystemColors.ButtonFace;
            Button2.Location = new Point(282, 397);
            Button2.Name = "Button2";
            Button2.Size = new Size(108, 57);
            Button2.TabIndex = 2;
            Button2.Text = "CLEAR";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(65, 67, 106);
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            Button1.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Segoe UI", 8.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.ForeColor = SystemColors.ButtonHighlight;
            Button1.Location = new Point(102, 397);
            Button1.Name = "Button1";
            Button1.Size = new Size(108, 57);
            Button1.TabIndex = 1;
            Button1.Text = "INSERT";
            Button1.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Location = new Point(102, 37);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(288, 309);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Panel4
            // 
            Panel4.Controls.Add(Button4);
            Panel4.Controls.Add(RichTextBox2);
            Panel4.Controls.Add(Button3);
            Panel4.Location = new Point(1361, 299);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(446, 519);
            Panel4.TabIndex = 3;
            // 
            // Button4
            // 
            Button4.BackColor = Color.FromArgb(65, 67, 106);
            Button4.FlatAppearance.BorderSize = 0;
            Button4.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            Button4.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Font = new Font("Segoe UI", 8.0f);
            Button4.ForeColor = SystemColors.ButtonHighlight;
            Button4.Location = new Point(37, 395);
            Button4.Name = "Button4";
            Button4.Size = new Size(108, 57);
            Button4.TabIndex = 1;
            Button4.TabStop = false;
            Button4.Text = "SEARCH";
            Button4.UseVisualStyleBackColor = false;
            // 
            // RichTextBox2
            // 
            RichTextBox2.BackColor = SystemColors.Control;
            RichTextBox2.BorderStyle = BorderStyle.None;
            RichTextBox2.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichTextBox2.ForeColor = SystemColors.InfoText;
            RichTextBox2.Location = new Point(37, 24);
            RichTextBox2.Name = "RichTextBox2";
            RichTextBox2.Size = new Size(370, 336);
            RichTextBox2.TabIndex = 2;
            RichTextBox2.Text = "HASIL" + '\n' + "Nama: " + '\n' + "Umur:";
            // 
            // Button3
            // 
            Button3.BackColor = Color.FromArgb(152, 64, 99);
            Button3.FlatAppearance.BorderSize = 0;
            Button3.FlatAppearance.MouseDownBackColor = Color.Violet;
            Button3.FlatAppearance.MouseOverBackColor = Color.Purple;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Font = new Font("Segoe UI", 8.0f);
            Button3.ForeColor = SystemColors.ButtonFace;
            Button3.Location = new Point(299, 397);
            Button3.Name = "Button3";
            Button3.Size = new Size(108, 57);
            Button3.TabIndex = 2;
            Button3.Text = "RESTART";
            Button3.UseVisualStyleBackColor = false;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(254, 150, 119);
            Panel3.Controls.Add(Label2);
            Panel3.Controls.Add(PictureBox2);
            Panel3.Location = new Point(725, 299);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(512, 519);
            Panel3.TabIndex = 3;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.FromArgb(65, 67, 106);
            Label2.FlatStyle = FlatStyle.Flat;
            Label2.Font = new Font("Segoe UI", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = SystemColors.ButtonFace;
            Label2.Location = new Point(188, 408);
            Label2.Margin = new Padding(3);
            Label2.Name = "Label2";
            Label2.Size = new Size(152, 30);
            Label2.TabIndex = 2;
            Label2.Text = "Kemiripan: 0%";
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBox2
            // 
            PictureBox2.Location = new Point(108, 37);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(288, 309);
            PictureBox2.TabIndex = 0;
            PictureBox2.TabStop = false;
            // 
            // KMB
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(Panel3);
            Controls.Add(Panel4);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Name = "KMB";
            Text = "KMB";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel4.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            Load += new EventHandler(KMB_Load);
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal Panel Panel2;
        internal PictureBox PictureBox1;
        internal Panel Panel4;
        internal Button Button2;
        internal Button Button1;
        internal Panel Panel3;
        internal Button Button3;
        internal Button Button4;
        internal PictureBox PictureBox2;
        internal RichTextBox RichTextBox2;
        internal PictureBox PictureBox3;
        internal Label Label1;
        internal Label Label2;
    }
}