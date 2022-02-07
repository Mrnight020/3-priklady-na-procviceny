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
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                int cislo = int.Parse(numericUpDown2.Value.ToString());
                Random rnd = new Random();

                if (cislo > 50)
                {
                    MessageBox.Show("Zadej mensi!!");
                }
                else
                {
                    for (int i = 0; i < cislo; i++)
                    {
                        double randomcislo = rnd.NextDouble() * 20 - 5;
                        listBox2.Items.Add(randomcislo.ToString());

                        if (randomcislo >= -2 && randomcislo < 5)
                        {
                            break;
                        }
                    }

                }
            }
            catch
            {
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                int cislo = int.Parse(numericUpDown2.Value.ToString());
                Random rnd = new Random();

                if (cislo > 50)
                {
                    MessageBox.Show("Zadej mensi!!");
                }
                else
                {
                    bool konec = false;
                    for (int i = 0; i < cislo && konec == false; i++)
                    {
                        double randomcislo = rnd.NextDouble() * 20 - 5;
                        listBox2.Items.Add(randomcislo.ToString());

                        if (randomcislo >= -2 && randomcislo < 5)
                        {
                            konec = true;
                        }
                    }

                }
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                int cislo = int.Parse(numericUpDown2.Value.ToString());
                Random rnd = new Random();

                if (cislo > 50)
                {
                    MessageBox.Show("Zadej mensi!!");
                }
                else
                {
                    bool konec = false;
                    int i = 0;
                    while ( i < cislo && konec == false)
                    {
                        double randomcislo = rnd.NextDouble() * 20 - 5;
                        listBox2.Items.Add(randomcislo.ToString());

                        if (randomcislo >= -2 && randomcislo < 5)
                        {
                            konec = true;
                        }
                        i++;
                    }

                }
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                int cislo = int.Parse(numericUpDown2.Value.ToString());
                Random rnd = new Random();

                if (cislo > 50)
                {
                    MessageBox.Show("Zadej mensi!!");
                }
                else
                {
                    bool konec = false;
                    int i = 0;
                    do
                    {
                        if (cislo > 0)
                        {
                            double randomcislo = rnd.NextDouble() * 20 - 5;
                            listBox2.Items.Add(randomcislo.ToString());

                            if (randomcislo >= -2 && randomcislo < 5)
                            {
                                konec = true;
                            }
                            i++;
                        }
                    } while (i < cislo && konec == false) ;

                }
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pokud se vygeneruje číslo v intervalu (2,5> ,Cyklus se ukončí");
        }
    }
}
