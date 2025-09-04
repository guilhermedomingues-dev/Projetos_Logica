using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeMetodo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            label3.Text = "O cubo no número é: " + cuboDoNumero(a).ToString();
        }
        private int cuboDoNumero(int a)
        {
            int cubo = a * a * a;
            return cubo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double salario1 = double.Parse(sal1.Text);
            double salario2 = double.Parse(sal2.Text);
            double salario3 = double.Parse(sal3.Text);

            label4.Text = "O marior salário é: R$" + maiorSal(salario1, salario2, salario3).ToString();
        }
        private double maiorSal(double a, double b, double c)
        {
            double maior;
            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > a && b > c)
            {
                maior = a;
            }
            else
            {
                maior = c;
            }
            
            return maior;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int d = int.Parse(dia.Text);
            int m = int.Parse(mes.Text);
            int a = int.Parse(ano.Text);

            label6.Text = "A data juliana é: " + dataJuliana(d, m, a);
        }
        private double dataJuliana(int a, int b, int c)
        {
            int diaJuliano = (b - 1) * 30 + a;

            return diaJuliano;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string palavra = palavraOriginal.Text;
            label8.Text = verificacao(palavra);
            label10.Text = confirma(palavra);
        }
        private string verificacao(string a)
        {
            char[] checkArray = a.ToCharArray();
            string invertido = String.Empty;
            for (int i = checkArray.Length -1; i>=0; i--)
            {
                invertido += checkArray[i];
            }
            return invertido;
        }
        private string confirma(string a)
        {
            char[] checkArray = a.ToCharArray();
            string invertido = String.Empty;
            for (int i = checkArray.Length - 1; i >= 0; i--)
            {
                invertido += checkArray[i];
            }
            if (invertido == a)
            {
                return "É palíndromo";
            }
            else
            {
                return "Não é palíndromo";
            }
            
        }
    }
}
