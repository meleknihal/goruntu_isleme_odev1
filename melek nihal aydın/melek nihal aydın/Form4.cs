﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace melek_nihal_aydın
{
    public partial class Form4 : Form
    {
        Bitmap kaynak, islem;
        public Form4()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Yöntem Dosyaları|*.jpg;*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox2.Image = kaynak;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yuk = kaynak.Height;
            int gen = kaynak.Width;

            islem = new Bitmap(gen, yuk);
            for(int y=0;y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color original = kaynak.GetPixel(x, y);
                    double luma = original.R * 0.3 + original.G * 0.59 + original.B * 0.11;
                    int lumalasan = Convert.ToInt16(luma);
                    Color sonrenk = Color.FromArgb(lumalasan, lumalasan, lumalasan);
                    islem.SetPixel(x, y, sonrenk);
                }
            }
            islemBox2.Image = islem;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }
    }
}
