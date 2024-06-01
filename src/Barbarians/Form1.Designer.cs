using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Barbarians
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Label3 = new Label();
            Label3.Click += new EventHandler(Label3_Click);
            Label2 = new Label();
            Label2.Click += new EventHandler(Label2_Click_1);
            Label1 = new Label();
            Label1.Click += new EventHandler(Label1_Click);
            PictureBox1 = new PictureBox();
            Panel2 = new Panel();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click_1);
            Label4 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click_1);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(65, 67, 106);
            Panel1.Controls.Add(Panel2);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(PictureBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1510, 805);
            Panel1.TabIndex = 0;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("SimSun-ExtB", 12.0f, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label3.Location = new Point(12, 597);
            Label3.Name = "Label3";
            Label3.Size = new Size(718, 24);
            Label3.TabIndex = 3;
            Label3.Text = " nobody by any chance ever observes.\" -  Arthur Conan Doyle";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("SimSun-ExtB", 12.0f, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label2.Location = new Point(81, 524);
            Label2.Name = "Label2";
            Label2.Size = new Size(514, 24);
            Label2.TabIndex = 2;
            Label2.Text = "\"The world is full of obvious things which";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Uighur", 28.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = SystemColors.ButtonFace;
            Label1.Location = new Point(196, 313);
            Label1.Name = "Label1";
            Label1.Size = new Size(374, 66);
            Label1.TabIndex = 1;
            Label1.Text = "Fingerprint Forensic";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(232, 34);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(284, 234);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.None;
            Panel2.BackColor = Color.FromArgb(254, 150, 119);
            Panel2.Controls.Add(Button1);
            Panel2.Controls.Add(Button3);
            Panel2.Controls.Add(Label4);
            Panel2.Location = new Point(731, -116);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(787, 943);
            Panel2.TabIndex = 4;
            // 
            // Button3
            // 
            Button3.BackColor = Color.FromArgb(246, 70, 104);
            Button3.FlatAppearance.BorderSize = 0;
            Button3.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            Button3.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.ForeColor = SystemColors.ControlLightLight;
            Button3.Location = new Point(115, 486);
            Button3.Name = "Button3";
            Button3.Size = new Size(185, 123);
            Button3.TabIndex = 5;
            Button3.Text = "KMP";
            Button3.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Uighur", 48.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = SystemColors.ButtonFace;
            Label4.Location = new Point(161, 227);
            Label4.Name = "Label4";
            Label4.Size = new Size(467, 114);
            Label4.TabIndex = 4;
            Label4.Text = "ALGORITMA";
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(246, 70, 104);
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            Button1.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.ForeColor = SystemColors.ControlLightLight;
            Button1.Location = new Point(517, 486);
            Button1.Name = "Button1";
            Button1.Size = new Size(185, 123);
            Button1.TabIndex = 6;
            Button1.Text = "BM";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1514, 808);
            Controls.Add(Panel1);
            Name = "Form1";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal PictureBox PictureBox1;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Panel Panel2;
        internal Button Button3;
        internal Label Label4;
        internal Button Button1;
    }
}