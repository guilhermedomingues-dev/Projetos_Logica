using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMetodo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = (txtLogin.Text);
            string senha = (txtSenha.Text);
            lblSaida.Text = confirma(login, senha);
        }
        private string verificacao(string l, string s)
        {
            char[] checkArray = l.ToCharArray();
            string invertido = String.Empty;
            for (int i = checkArray.Length - 1; i >= 0; i--)
            {
                invertido += checkArray[i];
            }
            return invertido;
        }
        private string confirma(string l, string s)
        {
            char[] checkArray = l.ToCharArray();
            string invertido = String.Empty;
            for (int i = checkArray.Length - 1; i >= 0; i--)
            {
                invertido += checkArray[i];
            }
            if (invertido != s)
            {
                return "Perfil Inexistente";
            }
            else
            {
                return "Bem vindo!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int ano = int.Parse(txtAno.Text);
            lblValidarData.Text = validacao(dia, mes, ano);
        }
        private string validacao(int d, int m, int a)
        {
            string verificacao;
            if (d > 0 && d <= 30 && m > 0 && m <= 12 && a >= 0)
            {
                verificacao = "É uma data válida";
            }
            else
            {
                verificacao = "Essa data não existe";
            }

            return verificacao;
        }
    }
}
