using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklady_na_proscviceni_na_30._01
{
    public partial class Ukol3 : Form
    {
        public Ukol3()
        {
            InitializeComponent();
        }

        private void prevod_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int cisla = 0;
                int minimum = int.MaxValue;
                int maximum = int.MinValue;
                int soucin = 1;
                foreach (string cislo in textBox1.Lines)
                {
                    cisla = int.Parse(cislo);
                    if (cisla % 2 != 0)
                    {
                        listBox1.Items.Add(cisla);
                    }
                    if (minimum > cisla)
                    {
                        minimum = cisla;
                    }
                    if (maximum < cisla)
                    {
                        maximum = cisla;
                    }
                    if (cisla < 5 || cisla >= 20)
                    {
                        soucin *= cisla;
                    }
                }
                int cifernysoucet = 0;
                int cifra = 0;
                for (int i = 0; maximum > 0;)
                {
                    cifra = maximum % 10;
                    cifernysoucet += cifra;
                    maximum /= 10;
                }

                min.Text = minimum.ToString();
                if (soucin != 1)
                {
                    interval.Text = soucin.ToString();
                }
                else
                {
                    interval.Text = "---";
                }
                labelcifernysoucet.Text = cifernysoucet.ToString();
            }
            catch
            {

            }
           
        }
    }
}
