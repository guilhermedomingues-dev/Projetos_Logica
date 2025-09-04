using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace escolha_caso_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            char opcao = char.Parse(cmbEscolha.Text);

            switch(opcao)
            {
                case 'A':
                    MessageBox.Show("A opção escolhida foi: A");
                    break;
                case 'B':
                    MessageBox.Show("A opção escolhida foi: B");
                    break;
                case 'C':
                    MessageBox.Show("A opção escolhida foi: C");
                    break;
                default:
                    MessageBox.Show("Opção inválida");
                    break;
            }

        }

        private void calcularCar_Click(object sender, EventArgs e)
        {
            double valor;
            valor = double.Parse(valorCarro.Text);
            char codigo = char.Parse(cmbCodigo.Text);
            double juros;
            double valorFinal;
            double parcela;

            switch(codigo)
            {
                case 'A':
                    juros = (30 / 100.0) * valor;
                    valorFinal = juros + valor;
                    parcela = (valorFinal)/ 24.0;

                    MessageBox.Show("Valor dos juros: R$" + juros.ToString("F") + "\nValor total do financiamento: R$" + valorFinal.ToString("F") + "\nValor de cada parcela: R$" + parcela.ToString("F"));
                    break;
                case 'B':
                    juros = (55 / 100.0) * valor;
                    valorFinal = juros + valor;
                    parcela = (valorFinal) / 36.0;

                    MessageBox.Show("Valor dos juros: R$" + juros.ToString("F") + "\nValor total do financiamento: R$" + valorFinal.ToString("F") + "\nValor de cada parcela: R$" + parcela.ToString("F"));
                    break;
                case 'C':
                    juros = (75 / 100.0) * valor;
                    valorFinal = juros + valor;
                    parcela = (valorFinal) / 48.0;

                    MessageBox.Show("Valor dos juros: R$" + juros.ToString("F") + "\nValor total do financiamento: R$" + valorFinal.ToString("F") + "\nValor de cada parcela: R$" + parcela.ToString("F"));
                    break;
                case 'D':
                    juros = (100 / 100.0) * valor;
                    valorFinal = juros + valor;
                    parcela = (valorFinal) / 60.0;

                    MessageBox.Show("Valor dos juros: R$" + juros.ToString("F") + "\nValor total do financiamento: R$" + valorFinal.ToString("F") + "\nValor de cada parcela: R$" + parcela.ToString("F"));
                    break;
                default:
                    MessageBox.Show("Opção inválida");
                    break;
            }
        }

        private void btnSalario_Click(object sender, EventArgs e)
        {
            string nome = (txtNome.Text);
            char cargo = char.Parse(cmbCargo.Text);
            double horas = double.Parse(txtHoras.Text);
            double salario;

            switch(cargo)
            {
                case 'A':
                    salario = horas * 8.0;
                    MessageBox.Show("Nome: " + nome + "\nHoras trabalhadas: " + horas.ToString("F") + "\nSalário: R$" + salario.ToString("F"));
                    break;
                case 'B':
                    salario = horas * 12.0;
                    MessageBox.Show("Nome: " + nome + "\nHoras trabalhadas: " + horas.ToString("F") + "\nSalário: R$" + salario.ToString("F"));
                    break;
                case 'C':
                    salario = horas * 17.0;
                    MessageBox.Show("Nome: " + nome + "\nHoras trabalhadas: " + horas.ToString("F") + "\nSalário: R$" + salario.ToString("F"));
                    break;
                default:
                    MessageBox.Show("Opção inválida");
                    break;
            }
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            string produto = (cmbProduto.Text);
            double preco;
            double qnt = double.Parse(txtQnt.Text);

            switch(produto)
            {
                case "AUTO":
                    preco = 325.0*qnt;
                    MessageBox.Show("O valor Final é: R$"+preco.ToString("F"));
                    break;
                case "MOTO":
                    preco = 102.0 * qnt;
                    MessageBox.Show("O valor Final é: R$" + preco.ToString("F"));
                    break;
                case "BIKE":
                    preco = 76.0 * qnt;
                    MessageBox.Show("O valor Final é: R$" + preco.ToString("F"));
                    break;
                case "KLWE":
                    preco = 176.0 * qnt;
                    MessageBox.Show("O valor Final é: R$" + preco.ToString("F"));
                    break;
                case "WPDD":
                    preco = 456.0 * qnt;
                    MessageBox.Show("O valor Final é: R$" + preco.ToString("F"));
                    break;
                default:
                    MessageBox.Show("Opção inválida");
                    break;
            }
        }

    }
}
