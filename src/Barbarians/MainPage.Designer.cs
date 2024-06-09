using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Barbarians
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MainPage : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.submit = new System.Windows.Forms.Button();
            this.Panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(150)))), ((int)(((byte)(119)))));
            this.Panel2.Controls.Add(this.panel3);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.Button1);
            this.Panel2.Controls.Add(this.Button3);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Location = new System.Drawing.Point(731, -116);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(787, 943);
            this.Panel2.TabIndex = 4;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.submit);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.Port);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.Password);
            this.panel3.Controls.Add(this.Username);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(186, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 231);
            this.panel3.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 26);
            this.textBox3.TabIndex = 13;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Port.Location = new System.Drawing.Point(61, 132);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(69, 29);
            this.Port.TabIndex = 12;
            this.Port.Text = "Port: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 26);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password.Location = new System.Drawing.Point(61, 86);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(132, 29);
            this.Password.TabIndex = 10;
            this.Password.Text = "Password: ";
            this.Password.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Username.Location = new System.Drawing.Point(61, 37);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(136, 29);
            this.Username.TabIndex = 9;
            this.Username.Text = "Username: ";
            this.Username.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(204, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 114);
            this.label5.TabIndex = 7;
            this.label5.Text = "DATABASE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(70)))), ((int)(((byte)(104)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(536, 649);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(185, 123);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "BM";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(70)))), ((int)(((byte)(104)))));
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button3.Location = new System.Drawing.Point(119, 649);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(185, 123);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "KMP";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label4.Location = new System.Drawing.Point(178, 463);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(467, 114);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "ALGORITMA";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1510, 805);
            this.Panel1.TabIndex = 0;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 597);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(718, 24);
            this.Label3.TabIndex = 3;
            this.Label3.Text = " nobody by any chance ever observes.\" -  Arthur Conan Doyle";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(81, 524);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(514, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "\"The world is full of obvious things which";
            this.Label2.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Uighur", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label1.Location = new System.Drawing.Point(196, 313);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(374, 66);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Fingerprint Forensic";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(232, 34);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(284, 234);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_2);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(337, 182);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(92, 35);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1514, 808);
            this.Controls.Add(this.Panel1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        internal Panel Panel2;
        internal Button Button1;
        internal Button Button3;
        internal Label Label4;
        internal Panel Panel1;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Label label5;
        private Panel panel3;
        private TextBox textBox3;
        private Label Port;
        private TextBox textBox2;
        private Label Password;
        private Label Username;
        private TextBox textBox1;
        private Button submit;
    }
}