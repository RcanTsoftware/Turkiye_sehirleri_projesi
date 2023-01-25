
namespace FinalProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Geri_buton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonRenk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.textBoxG2 = new System.Windows.Forms.TextBox();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.labelB2 = new System.Windows.Forms.Label();
            this.labelG2 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.textBoxB3 = new System.Windows.Forms.TextBox();
            this.textBoxG3 = new System.Windows.Forms.TextBox();
            this.textBoxR3 = new System.Windows.Forms.TextBox();
            this.labelB3 = new System.Windows.Forms.Label();
            this.labelG3 = new System.Windows.Forms.Label();
            this.labelR3 = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.buttonRP = new System.Windows.Forms.Button();
            this.buttonNS = new System.Windows.Forms.Button();
            this.linkLabelSHR = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(743, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÜRKİYE HARİTASI";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // Geri_buton
            // 
            this.Geri_buton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Geri_buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geri_buton.ForeColor = System.Drawing.Color.Gold;
            this.Geri_buton.Location = new System.Drawing.Point(12, 9);
            this.Geri_buton.Name = "Geri_buton";
            this.Geri_buton.Size = new System.Drawing.Size(96, 43);
            this.Geri_buton.TabIndex = 3;
            this.Geri_buton.Text = "GERİ";
            this.Geri_buton.UseVisualStyleBackColor = false;
            this.Geri_buton.Click += new System.EventHandler(this.Geri_buton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(203, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "PLAKA SIRALAMA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(1340, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "NÜFUS SIRALAMA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelR.Location = new System.Drawing.Point(1606, 443);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(74, 46);
            this.labelR.TabIndex = 6;
            this.labelR.Text = "R :";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelG.Location = new System.Drawing.Point(1607, 521);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(76, 46);
            this.labelG.TabIndex = 7;
            this.labelG.Text = "G :";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelB.Location = new System.Drawing.Point(1608, 598);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(72, 46);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "B :";
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxR.Location = new System.Drawing.Point(1686, 443);
            this.textBoxR.Multiline = true;
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(106, 46);
            this.textBoxR.TabIndex = 9;
            this.textBoxR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxR_KeyPress);
            // 
            // textBoxG
            // 
            this.textBoxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxG.Location = new System.Drawing.Point(1686, 521);
            this.textBoxG.Multiline = true;
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(106, 46);
            this.textBoxG.TabIndex = 10;
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxG_TextChanged);
            this.textBoxG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxG_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxB.Location = new System.Drawing.Point(1686, 598);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(106, 46);
            this.textBoxB.TabIndex = 11;
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxB_KeyPress);
            // 
            // buttonRenk
            // 
            this.buttonRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRenk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonRenk.Location = new System.Drawing.Point(1260, 680);
            this.buttonRenk.Name = "buttonRenk";
            this.buttonRenk.Size = new System.Drawing.Size(461, 58);
            this.buttonRenk.TabIndex = 12;
            this.buttonRenk.Text = "RENKLENDİR";
            this.buttonRenk.UseVisualStyleBackColor = true;
            this.buttonRenk.Click += new System.EventHandler(this.buttonRenk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(1072, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 13;
            // 
            // textBoxB2
            // 
            this.textBoxB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxB2.Location = new System.Drawing.Point(1414, 601);
            this.textBoxB2.Multiline = true;
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(106, 46);
            this.textBoxB2.TabIndex = 20;
            // 
            // textBoxG2
            // 
            this.textBoxG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxG2.Location = new System.Drawing.Point(1414, 524);
            this.textBoxG2.Multiline = true;
            this.textBoxG2.Name = "textBoxG2";
            this.textBoxG2.Size = new System.Drawing.Size(106, 46);
            this.textBoxG2.TabIndex = 19;
            // 
            // textBoxR2
            // 
            this.textBoxR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxR2.Location = new System.Drawing.Point(1414, 446);
            this.textBoxR2.Multiline = true;
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(106, 46);
            this.textBoxR2.TabIndex = 18;
            // 
            // labelB2
            // 
            this.labelB2.AutoSize = true;
            this.labelB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelB2.Location = new System.Drawing.Point(1336, 601);
            this.labelB2.Name = "labelB2";
            this.labelB2.Size = new System.Drawing.Size(72, 46);
            this.labelB2.TabIndex = 17;
            this.labelB2.Text = "B :";
            // 
            // labelG2
            // 
            this.labelG2.AutoSize = true;
            this.labelG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelG2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelG2.Location = new System.Drawing.Point(1335, 524);
            this.labelG2.Name = "labelG2";
            this.labelG2.Size = new System.Drawing.Size(76, 46);
            this.labelG2.TabIndex = 16;
            this.labelG2.Text = "G :";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelR2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelR2.Location = new System.Drawing.Point(1334, 446);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(74, 46);
            this.labelR2.TabIndex = 15;
            this.labelR2.Text = "R :";
            // 
            // textBoxB3
            // 
            this.textBoxB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxB3.Location = new System.Drawing.Point(1170, 601);
            this.textBoxB3.Multiline = true;
            this.textBoxB3.Name = "textBoxB3";
            this.textBoxB3.Size = new System.Drawing.Size(106, 46);
            this.textBoxB3.TabIndex = 26;
            // 
            // textBoxG3
            // 
            this.textBoxG3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxG3.Location = new System.Drawing.Point(1170, 524);
            this.textBoxG3.Multiline = true;
            this.textBoxG3.Name = "textBoxG3";
            this.textBoxG3.Size = new System.Drawing.Size(106, 46);
            this.textBoxG3.TabIndex = 25;
            // 
            // textBoxR3
            // 
            this.textBoxR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxR3.Location = new System.Drawing.Point(1170, 446);
            this.textBoxR3.Multiline = true;
            this.textBoxR3.Name = "textBoxR3";
            this.textBoxR3.Size = new System.Drawing.Size(106, 46);
            this.textBoxR3.TabIndex = 24;
            // 
            // labelB3
            // 
            this.labelB3.AutoSize = true;
            this.labelB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelB3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelB3.Location = new System.Drawing.Point(1092, 601);
            this.labelB3.Name = "labelB3";
            this.labelB3.Size = new System.Drawing.Size(72, 46);
            this.labelB3.TabIndex = 23;
            this.labelB3.Text = "B :";
            // 
            // labelG3
            // 
            this.labelG3.AutoSize = true;
            this.labelG3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelG3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelG3.Location = new System.Drawing.Point(1091, 524);
            this.labelG3.Name = "labelG3";
            this.labelG3.Size = new System.Drawing.Size(76, 46);
            this.labelG3.TabIndex = 22;
            this.labelG3.Text = "G :";
            // 
            // labelR3
            // 
            this.labelR3.AutoSize = true;
            this.labelR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelR3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelR3.Location = new System.Drawing.Point(1090, 446);
            this.labelR3.Name = "labelR3";
            this.labelR3.Size = new System.Drawing.Size(74, 46);
            this.labelR3.TabIndex = 21;
            this.labelR3.Text = "R :";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelS.Location = new System.Drawing.Point(1630, 369);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(195, 46);
            this.labelS.TabIndex = 27;
            this.labelS.Text = "SOLGUN";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelO.Location = new System.Drawing.Point(1385, 372);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(135, 46);
            this.labelO.TabIndex = 28;
            this.labelO.Text = "ORTA";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelD.Location = new System.Drawing.Point(1103, 372);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(197, 46);
            this.labelD.TabIndex = 29;
            this.labelD.Text = "DOLGUN";
            // 
            // buttonRP
            // 
            this.buttonRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRP.Location = new System.Drawing.Point(1514, 75);
            this.buttonRP.Name = "buttonRP";
            this.buttonRP.Size = new System.Drawing.Size(311, 58);
            this.buttonRP.TabIndex = 30;
            this.buttonRP.Text = "RENK PANELİ";
            this.buttonRP.UseVisualStyleBackColor = true;
            this.buttonRP.Click += new System.EventHandler(this.buttonRP_Click);
            // 
            // buttonNS
            // 
            this.buttonNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNS.ForeColor = System.Drawing.Color.Olive;
            this.buttonNS.Location = new System.Drawing.Point(1170, 308);
            this.buttonNS.Name = "buttonNS";
            this.buttonNS.Size = new System.Drawing.Size(535, 58);
            this.buttonNS.TabIndex = 31;
            this.buttonNS.Text = "NÜFUS SAYISINI ÖĞREN";
            this.buttonNS.UseVisualStyleBackColor = true;
            this.buttonNS.Click += new System.EventHandler(this.buttonNS_Click);
            // 
            // linkLabelSHR
            // 
            this.linkLabelSHR.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabelSHR.AutoSize = true;
            this.linkLabelSHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabelSHR.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabelSHR.Location = new System.Drawing.Point(1252, 211);
            this.linkLabelSHR.Name = "linkLabelSHR";
            this.linkLabelSHR.Size = new System.Drawing.Size(199, 46);
            this.linkLabelSHR.TabIndex = 32;
            this.linkLabelSHR.TabStop = true;
            this.linkLabelSHR.Text = "linkLabel1";
            this.linkLabelSHR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSHR_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1847, 990);
            this.Controls.Add(this.linkLabelSHR);
            this.Controls.Add(this.buttonNS);
            this.Controls.Add(this.buttonRP);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.textBoxB3);
            this.Controls.Add(this.textBoxG3);
            this.Controls.Add(this.textBoxR3);
            this.Controls.Add(this.labelB3);
            this.Controls.Add(this.labelG3);
            this.Controls.Add(this.labelR3);
            this.Controls.Add(this.textBoxB2);
            this.Controls.Add(this.textBoxG2);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.labelB2);
            this.Controls.Add(this.labelG2);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRenk);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Geri_buton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Geri_buton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonRenk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.TextBox textBoxG2;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.Label labelB2;
        private System.Windows.Forms.Label labelG2;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.TextBox textBoxB3;
        private System.Windows.Forms.TextBox textBoxG3;
        private System.Windows.Forms.TextBox textBoxR3;
        private System.Windows.Forms.Label labelB3;
        private System.Windows.Forms.Label labelG3;
        private System.Windows.Forms.Label labelR3;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Button buttonRP;
        private System.Windows.Forms.Button buttonNS;
        private System.Windows.Forms.LinkLabel linkLabelSHR;
    }
}

