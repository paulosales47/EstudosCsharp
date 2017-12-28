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
        }

        private void buttonCadastroCliente_Click(object sender, EventArgs e)
        {
            ContaCorrente cc = new ContaCorrente();
            try
            {
                cc.Titular = textNomeTitularCadastro.Text.ToString();
                cc.NumeroConta = int.Parse(textNumeroContaCadastro.Text.ToString());
                cc.Deposita(double.Parse(textSaldoInicialCadastro.Text.ToString()));
                aplicacaoPrincipal.AdicionaConta(cc);
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
