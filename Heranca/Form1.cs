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

namespace Casa.Financas.Visual
{
    public partial class Form1 : Form
    {
        private ContaCorrente[] contas;
        private int indiceSelecionado = 0;

        public Form1()
        {
            InitializeComponent();
            #region Caixa Eletronico
            ContaCorrente ca = new ContaCorrente();
            ContaCorrente cb = new ContaCorrente();

            comboSaldo.Enabled = false;
            comboNumero.Enabled = false;

            ca.Titular = "Usuário A";
            ca.NumeroConta = 1;
            ca.Deposita(10000);

            cb.Titular = "Usuário B";
            cb.NumeroConta = 2;
            cb.Deposita(5000);

            this.contas = new ContaCorrente[2];
            this.contas[0] = ca;
            this.contas[1] = cb;

            comboContas.Items.Add(contas[0].Titular);
            comboContas.Items.Add(contas[1].Titular);

            comboDestino.Items.Add(contas[0].Titular);
            comboDestino.Items.Add(contas[1].Titular);
            #endregion Caixa Eletronico

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            comboSaldo.Text = contaSelecionada.saldo.ToString();
            comboNumero.Text = contaSelecionada.NumeroConta.ToString();
            
        }

        private void buttonDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textValor.Text.ToString()))
                {
                    throw new ArgumentNullException();
                }

                double valorSaque = double.Parse(textValor.Text.ToString());
                contas[indiceSelecionado].Deposita(valorSaque);
                comboSaldo.Text = contas[indiceSelecionado].saldo.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas numeros");
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("É necessário preencher o campo de valor");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Limite máximo de valor ultrapassado");
            }

        }
        private void buttonSaque_Click(object sender, EventArgs e)
        {
            try
            {
                double valorSaque = double.Parse(textValor.Text.ToString());
                contas[indiceSelecionado].Saca(valorSaque);
                comboSaldo.Text = contas[indiceSelecionado].saldo.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas numeros");
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch(SaldoInsulficienteException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonTransferencia_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceDestino = comboDestino.SelectedIndex;
                double valorTransferencia = double.Parse(textValor.Text.ToString());
                contas[indiceSelecionado].Saca(valorTransferencia);
                contas[indiceDestino].Deposita(valorTransferencia);
                comboSaldo.Text = contas[indiceSelecionado].saldo.ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
    }
}

#region Caixa Eletronico
//Conta ca = new ContaCorrente();
//Conta cb = new ContaCorrente();

//comboSaldo.Enabled = false;
//comboNumero.Enabled = false;

//ca.Titular = "Usuário A";
//ca.NumeroConta = 1;
//ca.Deposita(10000);

//cb.Titular = "Usuário B";
//cb.NumeroConta = 2;
//cb.Deposita(5000);

//this.contas = new Conta[2];
//this.contas[0] = ca;
//this.contas[1] = cb;

//comboContas.Items.Add(contas[0].Titular);
//comboContas.Items.Add(contas[1].Titular);

//comboDestino.Items.Add(contas[0].Titular);
//comboDestino.Items.Add(contas[1].Titular);
#endregion Caixa Eletronico

#region Totalizador de Contas
//TotalizadorDeContas total = new TotalizadorDeContas();

//ContaPoupanca cp = new ContaPoupanca();
//cp.Deposita(1000);
//total.Adiciona(cp);

//Conta c = new Conta();
//c.Deposita(100);
//total.Adiciona(c);

//MessageBox.Show("Total das contas: " + total.total);
#endregion Totalizador de Contas

#region Teste de Referencias
//ContaPoupanca cp = new ContaPoupanca();
//ContaPoupanca c1 = new ContaPoupanca();
//ContaPoupanca c2 = null;

//cp.Deposita(1000);
//MessageBox.Show(cp.saldo.ToString());

//c1.Deposita(500);
//MessageBox.Show(c1.saldo.ToString());

//c2 = cp;
//MessageBox.Show(c2.saldo.ToString());

//c2 = c1;
//MessageBox.Show(c2.saldo.ToString());

//c2 = new ContaPoupanca();
//MessageBox.Show(c1.saldo.ToString());
//MessageBox.Show(cp.saldo.ToString());
#endregion Teste de Referencias

#region Testando Interfce
//GerenciadorDeImposto tdt = new GerenciadorDeImposto();
//ContaCorrente cc = new ContaCorrente();
//ContaPoupanca cp = new ContaPoupanca();
//ContaInvestimento ci = new ContaInvestimento();

//cc.Deposita(1000);
//cp.Deposita(500);
//ci.Deposita(7500);

////tdt.Acumula(cc);
//tdt.Acumula(cp);
//tdt.Acumula(ci);

//MessageBox.Show(tdt.Total.ToString());
#endregion Testando Interface