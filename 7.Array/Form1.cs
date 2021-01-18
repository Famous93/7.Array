using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Array
{
    public partial class Form1 : Form
    {
        int[] taulukko;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void luo_Click(object sender, EventArgs e)
        {
            Int32 lukumaara = Convert.ToInt32(koko_kentta.Text);
            taulukko = new int[lukumaara];

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
             
                Int32 talletettavaNum = Convert.ToInt32(tall_Num.Text);
                Int32 talletettavaIndeksi = Convert.ToInt32(tall_Indeksi.Text);

                taulukko[talletettavaIndeksi] = talletettavaNum;
            }
            catch (Exception)
            {
                MessageBox.Show("Virhe; Suurin indeksi on " + koko_kentta.Text);
            }
           
        }

        private void haku_Click(object sender, EventArgs e)
        {
            if (haku_indeksi.Text == tall_Indeksi.Text)
            { 
             

                result.Text = tall_Num.Text;
            }
            else
            {
                MessageBox.Show("Ei ole olemassa");
            }
            
        }
    }
}
