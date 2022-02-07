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
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            InitializeComponent();
        }

        private void prevod_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int cislo = int.Parse(numericUpDown1.Value.ToString());
            Random rnd = new Random();
            int maximum = -16;
            int pocetmaximum = 1;
            int poradimaximum = 0;
            int minimum = 62;
            int pocetminimum = 0;
            int poradiminimum = 0;

            if (cislo > 90)
            {
                MessageBox.Show("Zadej mensi!!");
            }
            else
            {
                for(int i = 0;i < cislo;i++)
                {
                    int randomcislo = rnd.Next(-15, 60);
                    if(randomcislo == minimum)
                    {
                        pocetminimum++;
                    }
                    if(randomcislo < minimum)
                    {
                        minimum = randomcislo;
                        poradiminimum = i + 1;
                        pocetminimum = 1;
                    }

                    if(randomcislo == maximum)
                    {
                        pocetmaximum++;
                        poradimaximum = i + 1;
                    }
                    if (randomcislo > maximum)
                    {
                        pocetmaximum = 1;
                        maximum = randomcislo;
                        poradimaximum = i + 1;
                    }


                    listBox1.Items.Add(randomcislo.ToString());
                }
                labelmax.Text = maximum.ToString();
                labelmaxipocet.Text = pocetmaximum.ToString();
                labelmaxposledni.Text = poradimaximum.ToString();

                labelmin.Text = minimum.ToString();
                labelminpocet.Text = pocetminimum.ToString();
                labelminprvni.Text = poradiminimum.ToString();
            }


            //listBox1.Items.Add(cislo.ToString());
        }
    }
}
