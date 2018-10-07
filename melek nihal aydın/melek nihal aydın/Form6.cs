using System;
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
    public partial class Form6 : Form
    {
        Bitmap kaynak, islem;
        public Form6()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                kaynakBox5.Image = kaynak;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kırmızı kanal çıkarımı
            int yuk = kaynak.Height;
            int gen = kaynak.Width;

            islem = new Bitmap(gen, yuk);

            for(int y=0;y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color original = kaynak.GetPixel(x, y);
                    Color final = Color.FromArgb(0, original.G, original.B);
                    islem.SetPixel(x, y, final);
                }
            }
            islemBox5.Image = islem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //yeşil kanal çıkarımı

            int yuk = kaynak.Height;
            int gen = kaynak.Width;

            islem = new Bitmap(gen, yuk);

            for(int y=0;y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color original = kaynak.GetPixel(x, y);
                    Color final = Color.FromArgb(original.R, 0, original.B);
                    islem.SetPixel(x, y, final);

                }
            }
            islemBox5.Image = islem;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //mavi kanal çıkarımı

            int yuk = kaynak.Height;
            int gen = kaynak.Width;

            islem = new Bitmap(gen, yuk);

            for(int y=0;y<yuk;y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color original = kaynak.GetPixel(x, y);
                    Color final = Color.FromArgb(original.R, original.G, 0);
                    islem.SetPixel(x, y, final);

                }
            }
            islemBox5.Image = islem;
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
