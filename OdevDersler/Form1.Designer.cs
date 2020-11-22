namespace OdevDersler
{
    partial class Dersler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hosgeldiniz = new System.Windows.Forms.Label();
            this.Derlerigörüntüle = new System.Windows.Forms.Button();
            this.YeniDersEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Adi = new System.Windows.Forms.Label();
            this.Kategori = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Icerik = new System.Windows.Forms.Label();
            this.Kredi = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Memory = new System.Windows.Forms.RadioButton();
            this.File = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Hosgeldiniz
            // 
            this.Hosgeldiniz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Hosgeldiniz.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hosgeldiniz.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Hosgeldiniz.Location = new System.Drawing.Point(53, 44);
            this.Hosgeldiniz.Name = "Hosgeldiniz";
            this.Hosgeldiniz.Size = new System.Drawing.Size(321, 58);
            this.Hosgeldiniz.TabIndex = 0;
            this.Hosgeldiniz.Text = "HOŞGELDİNİZ";
            this.Hosgeldiniz.Click += new System.EventHandler(this.label1_Click);
            // 
            // Derlerigörüntüle
            // 
            this.Derlerigörüntüle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Derlerigörüntüle.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Derlerigörüntüle.Location = new System.Drawing.Point(64, 169);
            this.Derlerigörüntüle.Name = "Derlerigörüntüle";
            this.Derlerigörüntüle.Size = new System.Drawing.Size(310, 33);
            this.Derlerigörüntüle.TabIndex = 1;
            this.Derlerigörüntüle.Text = "Dersleri Görüntüle";
            this.Derlerigörüntüle.UseVisualStyleBackColor = false;
            this.Derlerigörüntüle.Click += new System.EventHandler(this.Derlerigörüntüle_Click);
            // 
            // YeniDersEkle
            // 
            this.YeniDersEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YeniDersEkle.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeniDersEkle.Location = new System.Drawing.Point(64, 307);
            this.YeniDersEkle.Name = "YeniDersEkle";
            this.YeniDersEkle.Size = new System.Drawing.Size(310, 33);
            this.YeniDersEkle.TabIndex = 1;
            this.YeniDersEkle.Text = "Yeni Ders Ekle";
            this.YeniDersEkle.UseVisualStyleBackColor = false;
            this.YeniDersEkle.Click += new System.EventHandler(this.YeniDersEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 400);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Adi
            // 
            this.Adi.AutoSize = true;
            this.Adi.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Adi.Location = new System.Drawing.Point(61, 400);
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(51, 25);
            this.Adi.TabIndex = 4;
            this.Adi.Text = "Adı:";
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategori.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Kategori.Location = new System.Drawing.Point(62, 443);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(116, 25);
            this.Kategori.TabIndex = 4;
            this.Kategori.Text = "Kategorisi:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 480);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 26);
            this.textBox2.TabIndex = 3;
            // 
            // Icerik
            // 
            this.Icerik.AutoSize = true;
            this.Icerik.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icerik.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icerik.Location = new System.Drawing.Point(62, 481);
            this.Icerik.Name = "Icerik";
            this.Icerik.Size = new System.Drawing.Size(77, 25);
            this.Icerik.TabIndex = 4;
            this.Icerik.Text = "İçeriği:";
            // 
            // Kredi
            // 
            this.Kredi.AutoSize = true;
            this.Kredi.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kredi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Kredi.Location = new System.Drawing.Point(62, 521);
            this.Kredi.Name = "Kredi";
            this.Kredi.Size = new System.Drawing.Size(85, 25);
            this.Kredi.TabIndex = 4;
            this.Kredi.Text = "Kredisi:";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(192, 447);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(143, 21);
            this.comboBoxKategori.TabIndex = 5;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(192, 526);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ekle.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ekle.Location = new System.Drawing.Point(225, 580);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(110, 36);
            this.Ekle.TabIndex = 7;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(434, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 420);
            this.listBox1.TabIndex = 8;
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memory.Location = new System.Drawing.Point(67, 241);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(107, 29);
            this.Memory.TabIndex = 9;
            this.Memory.TabStop = true;
            this.Memory.Text = "Memory";
            this.Memory.UseVisualStyleBackColor = true;
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File.Location = new System.Drawing.Point(310, 241);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(64, 29);
            this.File.TabIndex = 9;
            this.File.TabStop = true;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            // 
            // Dersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(740, 635);
            this.Controls.Add(this.File);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.Kredi);
            this.Controls.Add(this.Icerik);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.Adi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.YeniDersEkle);
            this.Controls.Add(this.Derlerigörüntüle);
            this.Controls.Add(this.Hosgeldiniz);
            this.Name = "Dersler";
            this.Text = "DersSistemi";
            this.Load += new System.EventHandler(this.Dersler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hosgeldiniz;
        private System.Windows.Forms.Button Derlerigörüntüle;
        private System.Windows.Forms.Button YeniDersEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Adi;
        private System.Windows.Forms.Label Kategori;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Icerik;
        private System.Windows.Forms.Label Kredi;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton Memory;
        private System.Windows.Forms.RadioButton File;
    }
}

