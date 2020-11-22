using OdevDersler.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace OdevDersler
{
    public partial class Dersler : Form
    {
        
        public Dersler()
        {
            InitializeComponent();

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dersler_Load(object sender, EventArgs e)
        {
            Dersler dersler = new Dersler();
            dersler.Width = 425;
            dersler.Height = 425;
            Adi.Visible = false;
            Kategori.Visible = false;
            Icerik.Visible = false;
            Kredi.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBoxKategori.Visible = false;
            comboBox2.Visible = false;
            listBox1.Visible = false;
            Ekle.Visible = false;
            Memory.Checked = true;

            comboBoxKategori.Items.Add("--Seçiniz--");
            comboBoxKategori.Items.Add("0");
            comboBoxKategori.Items.Add("1");
            
            comboBox2.Items.Add("--Seçiniz--");
            comboBox2.Items.Add("0");
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            
        }

        public void Derlerigörüntüle_Click(object sender, EventArgs e)
        {
            Adi.Visible = false;
            Kategori.Visible = false;
            Icerik.Visible = false;
            Kredi.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBoxKategori.Visible = false;
            comboBox2.Visible = false;
            listBox1.Visible = false;
            Ekle.Visible = false;
            listBox1.Items.Clear();
            if (Memory.Checked)
            {

                listBox1.Visible = true;
                DerslerService derslerService = new DerslerService(new MemoryIslmeler());
                derslerService.List();
                string dersBiglisi = "";
                foreach (var d in MemoryIslmeler.dersler)
                {
                    dersBiglisi = d.Id + " - " + d.adi + " - " + d.dersKategori + " - " + d.icerik + " - " + d.dersKredisi;
                    listBox1.Items.Add(dersBiglisi);
                }
               
            }
            else 
            {
                FileIslemler.dersler2.Clear();
                listBox1.Visible = true;
                DerslerService derslerService = new DerslerService(new FileIslemler());
                FileIslemler.dersler2=derslerService.List();
                string dersBiglisi = "";
                foreach (var d in FileIslemler.dersler2)
                {
                    dersBiglisi = d.Id + " - " + d.adi + " - " + d.dersKategori + " - " + d.icerik + " - " + d.dersKredisi;
                    listBox1.Items.Add(dersBiglisi);
                }
            }
            
        }

        private void DersListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YeniDersEkle_Click(object sender, EventArgs e)
        {
            Adi.Visible = true;
            Kategori.Visible = true;
            Icerik.Visible = true;
            Kredi.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            comboBoxKategori.Visible = true;
            comboBox2.Visible = true;
            listBox1.Visible = false;
            Ekle.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            comboBoxKategori.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void Ekle_Click(object sender, EventArgs e)
        {
            Ders ders = new Ders();
            List<int> idler = new List<int>();

            if (Memory.Checked)
            {
                foreach (var d in MemoryIslmeler.dersler)
                {
                    idler.Add(d.Id);
                }
                int soneksibirId = idler.Max();
                ders.Id = (soneksibirId + 1);
                textBox1.Text.Trim();
                if (!(textBox1.Text==""))
                {
                    ders.adi=textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Ad Giriniz!");
                }
                textBox2.Text.Trim();
                if (!(textBox2.Text==""))
                {
                   ders.icerik=textBox2.Text;
                }
                else
                {
                    MessageBox.Show("içerik Giriniz!");
                }

                if (!(comboBoxKategori.SelectedIndex==0))
                {
                    ders.dersKategori = (DersKategoriEnum)Convert.ToInt32(comboBoxKategori.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Lütfen Ders Kategorisi Seçiniz!");
                }
                if (!(comboBox2.SelectedIndex == 0))
                {
                    ders.dersKredisi = (DersKredisiEnum)Convert.ToInt32(comboBox2.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Lütfen Ders Kategorisi Seçiniz!");
                }
                DerslerService derslerService = new DerslerService(new MemoryIslmeler());
                derslerService.AddDers(ders);

            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Visible = true;
                DerslerService derslerService = new DerslerService(new FileIslemler());
                FileIslemler.dersler2 = derslerService.List();
                string dersBiglisi = "";
                foreach (var d in FileIslemler.dersler2)
                {
                    dersBiglisi = d.Id + " - " + d.adi + " - " + d.dersKategori + " - " + d.icerik + " - " + d.dersKredisi;
                    listBox1.Items.Add(dersBiglisi);
                }
                foreach (var d in FileIslemler.dersler2)
                {
                    idler.Add(d.Id);
                }
                int soneksibirId = idler.Max();
                ders.Id = (soneksibirId + 1);
                textBox1.Text.Trim();
                if (!(textBox1.Text == ""))
                {
                    ders.adi = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Ad Giriniz!");
                }
                textBox2.Text.Trim();
                if (!(textBox2.Text == ""))
                {
                    ders.icerik = textBox2.Text;
                }
                else
                {
                    MessageBox.Show("içerik Giriniz!");
                }

                if (!(comboBoxKategori.SelectedIndex == 0))
                {
                    ders.dersKategori = (DersKategoriEnum)Convert.ToInt32(comboBoxKategori.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Lütfen Ders Kategorisi Seçiniz!");
                }
                if (!(comboBox2.SelectedIndex == 0))
                {
                    ders.dersKredisi = (DersKredisiEnum)Convert.ToInt32(comboBox2.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Lütfen Ders Kategorisi Seçiniz!");
                }
                
                derslerService.AddDers(ders);

              
                
               
            }

            Adi.Visible = false;
            Kategori.Visible = false;
            Icerik.Visible = false;
            Kredi.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBoxKategori.Visible = false;
            comboBox2.Visible = false;
            listBox1.Visible = false;
            Ekle.Visible = false;
        }
    }
}
