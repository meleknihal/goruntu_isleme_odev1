using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melek_nihal_aydın
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ortalamadegerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ortalamadeger = new Form2();
            ortalamadeger.ShowDialog();
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bt709 = new Form3();
            bt709.ShowDialog();
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 luma = new melek_nihal_aydın.Form4();
            luma.ShowDialog();
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 açıklık = new melek_nihal_aydın.Form5();
            açıklık.ShowDialog();
        }

        private void kanalcıkarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 kanalcıkarım = new melek_nihal_aydın.Form6();
            kanalcıkarım.ShowDialog();
        }
    }
}
