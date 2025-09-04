using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades___While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sequencia1_Click_1(object sender, EventArgs e)
        {
            txt_saida.Clear();
            int cont = 1;

            while (cont <= 512)
            {
                txt_saida.Text += cont + " ";
                cont *= 2;
            }
        }

        private void btn_sequencia2_Click(object sender, EventArgs e)
        {
            txt_saida.Clear();
            int cont = 10;

            while (cont >= 0)
            {
                txt_saida.Text += cont + " ";
                cont = cont - 1;
            }
        }

        private void btn_sequencia3_Click(object sender, EventArgs e)
        {
            txt_saida.Clear();
            int cont = 100;

            while (cont >= 10)
            {
                if (cont % 3 == 0)
                {
                    txt_saida.Text += cont + " ";
                }
                cont -= 1;
            }
        }

        private void btn_sequencia4_Click(object sender, EventArgs e)
        {
            txt_saida.Clear();
            int cont = 20;

            while (cont >= 2)
            {
                if (cont % 2 == 0)
                {
                    txt_saida.Text += cont + " ";
                }
                cont -= 1;
            }
        }

        private void btn_sequencia5_Click(object sender, EventArgs e)
        {
            txt_saida.Clear();
            int cont = 0;

            while (cont <= 100)
            {
                if (cont % 10 == 0 && cont != 0)
                {
                    txt_saida.Text += cont.ToString() + "\r\n";
                }
                else
                {
                    txt_saida.Text += cont.ToString() + " ";
                }
                cont += 1;
            }
        }

        private void btn_sequencia6_Click(object sender, EventArgs e)
        {
            txt_saida.Clear();
            int cont = 1;

            while (cont <= 9)
            {
                if (cont % 3 == 0)
                {
                    txt_saida.Text += cont.ToString() + "\r\n";
                }
                else
                {
                    txt_saida.Text += cont.ToString() + " ";
                }
                cont += 1;
            }
        }

        private void btn_sequencia8_Click(object sender, EventArgs e)
        {
            txt_saida.Clear();
            int cont = 3;

            while (cont <= 45)
            {
                txt_saida.Text += cont + " ";
                cont += 7;
            }
        }

        private void btn_sequencia9_Click(object sender, EventArgs e)
        {
            txt_saida.Clear();
            int cont = 1;

            while (cont <= 19)
            {
                if (cont <= 9 && cont % 2==1)
                {
                    txt_saida.Text += cont + " ";
                }
                else if ((cont - 10) % 3 == 0 && cont-10>=0)
                {
                    txt_saida.Text += cont + " ";
                }
                cont += 1;
            }
        }
    }
}
