using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public int[] masiv = new int[10];
        public int m = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void skaic_prid_Click(object sender, EventArgs e)
        {

                if (int.TryParse(skaic_input.Text, out masiv[m]))
                {
                    m++;
                    skaic_rezul.Text = masiv[0] + " + ";
                    
                    for (int i = 1; i < m; i++)
                    {
                        skaic_rezul.AppendText(masiv[i] + " + ");

                }
                    if (m == 10)
                    {
                        skaic_prid.Enabled = false;
                    }
                }
            skaic_input.Clear();
        }
        private void skaic_mygtukas_Click(object sender, EventArgs e)
        {
            if (m < 10)
            {
                skaic_label.Text = "Masyve trūksta skaičių";
            }
            else
            {
                int i = 0;
                int suma = 0;
                while (true)
                {
                    suma += masiv[i];
                    i++;
                    if (i == m) break;
                }
                skaic_rezul.Text = "Suma yra: " + suma;
            }
        }

        private void mas_val_Click(object sender, EventArgs e)
        {
            skaic_rezul.Clear();
            skaic_input.Clear();
            skaic_label.Text = "";
            m = 0;
            skaic_prid.Enabled = true;
        }

        private void pies_mygtukas_Click(object sender, EventArgs e)
        {
            int size;
            int i = 0;
            int star = 1;
            int space;
            if(int.TryParse(pies_input.Text, out size) && size > 0)
            {
                pies_output.Clear();
                space = size;
                do
                {
                    for (int n = 1; n < space; n++)
                    {
                        pies_output.AppendText(" ");
                    }
                    for (int n = 0; n < star; n++)
                    {
                        pies_output.AppendText("* ");
                    }
                    pies_output.AppendText("\n");
                    space--;
                    star++;
                    i++;
                } while (i < size);
            }
        }


    }
}
