using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casa.Financas.Entidade;
using Casa.Financas.ExceptionEntidade;
using Casa.Financas.Programa;

namespace Casa.Financas.Visual
{
    public partial class FormularioDeCadastro : Form
    {
        private Form1 aplicacaoPrincipal;

        public FormularioDeCadastro(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();

            comboTipoConta.Items.Add("Conta Corrente");
            comboTipoConta.Items.Add("Conta Poupança");
            comboTipoConta.Items.Add("Conta Investimento");
        }

        private void buttonCadastroCliente_Click(object sender, EventArgs e)
        {
            Conta conta = null;
            try
            {
                int tipoConta = comboTipoConta.SelectedIndex;

                string titular = textNomeTitularCadastro.Text.ToString();
                int numeroDaConta = int.Parse(textNumeroContaCadastro.Text.ToString());
                double saldoInicial = double.Parse(textSaldoInicialCadastro.Text.ToString());

                if(tipoConta == 0)
                {
                    conta = new ContaCorrente();
                }
                else if(tipoConta == 1)
                {
                    conta = new ContaPoupanca();
                }
                else if(tipoConta == 2)
                {
                    conta = new ContaInvestimento();
                }
                else
                {
                    throw new FormatException();
                }

                conta.Titular = titular;
                conta.NumeroConta = numeroDaConta;
                conta.Deposita(saldoInicial);
            
                aplicacaoPrincipal.AdicionaConta(conta);
            }
            catch(OverflowException)
            {
                MessageBox.Show("O valor de saldo inicial informado é inválido");
            }
            catch(ArgumentException)
            {
                MessageBox.Show("O valor inicial de uma conta não pode ser negativo");
            }
            catch(FormatException)
            {
                MessageBox.Show("Verifique se todos os campos do formulário foram preenchidos corretamente");
            }
        }
    }
}
