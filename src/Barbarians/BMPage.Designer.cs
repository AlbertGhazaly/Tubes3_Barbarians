using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Barbarians
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BMPage : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMPage));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Button4 = new System.Windows.Forms.Button();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(70)))), ((int)(((byte)(104)))));
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.PictureBox3);
            this.Panel1.Location = new System.Drawing.Point(3, 34);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1997, 104);
            this.Panel1.TabIndex = 4;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.Window;
            this.Label1.Location = new System.Drawing.Point(1466, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(342, 36);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Algoritma: Boyer-Moore";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox3.InitialImage")));
            this.PictureBox3.Location = new System.Drawing.Point(30, 10);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(97, 81);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 0;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(150)))), ((int)(((byte)(119)))));
            this.Panel2.Controls.Add(this.Button2);
            this.Panel2.Controls.Add(this.Button1);
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Location = new System.Drawing.Point(83, 337);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(512, 519);
            this.Panel2.TabIndex = 5;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button2.Location = new System.Drawing.Point(282, 397);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(108, 57);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "CLEAR";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Location = new System.Drawing.Point(102, 397);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(108, 57);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "INSERT";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(102, 37);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(288, 309);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.Button4);
            this.Panel4.Controls.Add(this.RichTextBox2);
            this.Panel4.Controls.Add(this.Button3);
            this.Panel4.Location = new System.Drawing.Point(1365, 337);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(446, 519);
            this.Panel4.TabIndex = 6;
            this.Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button4.Location = new System.Drawing.Point(37, 395);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(108, 57);
            this.Button4.TabIndex = 1;
            this.Button4.TabStop = false;
            this.Button4.Text = "SEARCH";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RichTextBox2.Location = new System.Drawing.Point(37, 24);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(370, 336);
            this.RichTextBox2.TabIndex = 2;
            this.RichTextBox2.Text = "HASIL\nNama: \nUmur:";
            this.RichTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(64)))), ((int)(((byte)(99)))));
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button3.Location = new System.Drawing.Point(299, 397);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(108, 57);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "RESTART";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(150)))), ((int)(((byte)(119)))));
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.PictureBox2);
            this.Panel3.Location = new System.Drawing.Point(710, 337);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(512, 519);
            this.Panel3.TabIndex = 7;
            this.Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(106)))));
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label2.Location = new System.Drawing.Point(188, 408);
            this.Label2.Margin = new System.Windows.Forms.Padding(3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(152, 30);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Kemiripan: 0%";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Location = new System.Drawing.Point(108, 37);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(288, 309);
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // BMPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Name = "BMPage";
            this.Text = "BM";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        internal Panel Panel1;
        internal Label Label1;
        internal PictureBox PictureBox3;
        internal Panel Panel2;
        internal Button Button2;
        internal Button Button1;
        internal PictureBox PictureBox1;
        internal Panel Panel4;
        internal Button Button4;
        internal RichTextBox RichTextBox2;
        internal Button Button3;
        internal Panel Panel3;
        internal Label Label2;
        internal PictureBox PictureBox2;
    }
}