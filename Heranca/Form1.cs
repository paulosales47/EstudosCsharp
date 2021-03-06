﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casa.Financas.Entidade;
using Casa.Financas.ExceptionEntidade;
using Casa.Financas.Interface;

namespace Casa.Financas.Visual
{
    public partial class Form1 : Form
    {
        private List<Conta> contas  = new List<Conta>();
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
            ca.Deposita(100000);

            cb.Titular = "Usuário B";
            cb.NumeroConta = 2;
            cb.Deposita(50000);
            
            this.contas.Add(ca);
            this.contas.Add(cb);
            
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

        public void AdicionaConta(Conta conta)
        {
            try
            {
                this.contas.Add((ContaCorrente) conta);
                comboContas.Items.Add(conta.Titular);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Não é possível cadastrar mais contas.");
            }
        }

        private void buttonAbreFormularioCadastroCliente_Click(object sender, EventArgs e)
        {
            FormularioDeCadastro cadastro = new FormularioDeCadastro(this);
            cadastro.ShowDialog();
        }

        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {
            contas.RemoveAt(indiceSelecionado);
            comboContas.Items.RemoveAt(indiceSelecionado);
            comboSaldo.Text = "";
            comboNumero.Text = "";
        }

        private void buttonSalvarTextoArquivo_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\SQL\README.md";

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            Stream saida = File.Open(filePath, FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(textBoxArquivo.Text);
            escritor.Close();
            saida.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

#region Testes com extensões
//double valor = 100;

//MessageBox.Show("teste".Plurarize());
//MessageBox.Show(valor.Dobro().ToString());
#endregion Testes com extensões

#region LINQ e Lambda
//Conta cc1 = new ContaCorrente();
//Conta cc2 = new ContaCorrente();
//Conta cc3 = new ContaCorrente();
//cc1.Deposita(1000);
//cc2.Deposita(2000);
//cc3.Deposita(3000);
//var lista = new List<Conta>();
//lista.Add(cc1);
//lista.Add(cc2);
//lista.Add(cc3);

////FILTRAR CONTAS COM SALDO MAIOR IGUAL A 2000
//var filtrados = from c in lista
//                where c.saldo >= 2000
//                select c;

////TOTAL DE SALDO DAS CONTAS FILTRADAS
//double total = filtrados.Sum(c => c.saldo);

////CONTAS EM QUE O NOME DO TITULAR COMEÇA COM A LETRA G
//var filtradosNomne = from c in lista
//    where c.Titular.StartsWith("G")
//    select c;

////LAMBDA DENTRO DA CLAUSULA WHERE
//var filtradosLambda = lista.Where(c => c.NumeroConta < 1000 && c.saldo > 5000.0);

////SUM
//int[] inteiros = new int[5] { 100, 25, 15, 35, 50 };
//var soma = inteiros.Where(i => i > 10).Sum();

////ORDENAÇÃO VETOR
//var ordenados = from ord in inteiros
//                orderby ord
//                select ord;

////ORDENAÇÃO VETOR + WHERE
//var ordenadosWhere = from ord in inteiros
//                     where ord > 10
//                     orderby ord
//                    select ord;

////ORDENAÇÃO OBJETO + WHERE
//var contasOrdenadas = from conta in lista
//                      where conta.saldo > 1000
//                      orderby conta.saldo descending
//                      select conta;

////ORDENAÇÃO OBJETO + WHERE 2
//var resultado = lista.Where(c => c.saldo < 1000)
//          .OrderByDescending(c => c.NumeroConta);

////ORDENAÇÃO COM MAIS DE UMA CLAUSULA
//var ordenadas = from p in lista
//                orderby p.NumeroConta , p.saldo
//                select p;
////ORDENAÇÃO COM MAIS DE UMA CLAUSULA 2
//var ordenadas2 = lista.OrderBy(c => c.saldo).ThenBy(c => c.NumeroConta);

////ORDENAÇÃO COM MAIS DE UMA CLAUSULA DESCENDENTE
//var ordenadas3 = lista.OrderBy(c => c.saldo).ThenByDescending(c => c.NumeroConta);
#endregion LINQ e Lambda

#region Testes com Arquivos
//string filePath = @"C:\SQL\README.md";

//if (File.Exists(filePath))
//{
//    using (Stream entrada = File.Open(filePath, FileMode.Open))
//    using (StreamReader leitor = new StreamReader(entrada))
//    {
//        //COMPLETO
//        string texto = leitor.ReadToEnd();
//        textBoxArquivo.Text = texto;

//        //LINHA-A-LINHA
//        //string linha = leitor.ReadLine();
//        //while (linha != null)
//        //{
//        //    textBoxArquivo.Text += linha;
//        //    linha = leitor.ReadLine();
//        //}
//    }
//}
#endregion Testes com arquivos

#region String
//int idade = 21;
//string nome = "Paulo Henrique";
//string mensagem = string.Format("Olá {0}, a sua idade é: {1} anos", nome, idade);
//MessageBox.Show(mensagem);

//string dados = "Paulo Henrique,21,São José dos Campos,Brasil";
//string[] partes = dados.Split(',');
//foreach(string parte in partes)
//{
//    MessageBox.Show(parte);
//}
#endregion String

#region SortedDictionary
//SortedDictionary<string, string> nomes = new SortedDictionary<string, string>();
//nomes.Add("Adriano", "Almeida");
//nomes.Add("Mario", "Amaral");
//nomes.Add("Eric", "Torti");
//nomes.Add("Guilherme", "Silveira");
//foreach (var i in nomes)
//{
//    MessageBox.Show(i.Key + " " + i.Value);
//}
#endregion SortedDictionary

#region Teste foreach com Dictionary
//Dictionary<string, string> nomesEPalavras = new Dictionary<string, string>();
//nomesEPalavras.Add("Paulo", "Sampaio");
//nomesEPalavras.Add("Nome", "Sobrenome");
//nomesEPalavras.Add("Nome1", "Sobrenome1");
//nomesEPalavras.Add("Nome2", "Sobrenome2");

//foreach (var i in nomesEPalavras)
//{
//    MessageBox.Show(i.Key + "->" + i.Value);
//}
#endregion Teste foreach com Dictionary

#region Testes com Foreach
//List<Conta> listaDeContas = new List<Conta>();
//Conta cc1 = new ContaCorrente();
//Conta cc2 = new ContaCorrente();
//Conta cc3 = new ContaCorrente();

//cc1.Titular = "Paulo";
//cc2.Titular = "Titular 2";
//cc3.Titular = "Titular 3";
//listaDeContas.Add(cc1);
//listaDeContas.Add(cc2);
//listaDeContas.Add(cc3);

//foreach (var conta in listaDeContas)
//{
//    MessageBox.Show(conta.Titular+" - ");
//}
#endregion Testes com Foreach

#region Testes com Dictionary
//Dictionary<string, Conta> dicionarioContas = new Dictionary<string, Conta>();
//Conta c = new ContaCorrente();
//dicionarioContas.Add("Paulo", c);
//MessageBox.Show(dicionarioContas["Paulo"].ToString());
#endregion Testes com Dictionary

#region Testes com SortedSet
//SortedSet<string> palavras = new SortedSet<string>();
//palavras.Add("vida");
//palavras.Add("furadeira");
//palavras.Add("maçã");
//foreach (string palavra in palavras)
//{
//    MessageBox.Show(palavra);
//}
#endregion Testes com SortedSet

#region Testes com HahSet
//var conjunto = new HashSet<Conta>();
//var cc1 = new ContaCorrente();
//var cc2 = new ContaCorrente();
////cc2 = cc1;
//conjunto.Add(cc1);
//conjunto.Add(cc2);

//MessageBox.Show(conjunto.Count.ToString());
//cc2 = cc1;
#endregion Testes com HashSet

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

#region Testes na classe Object
//ContaCorrente cc1 = new ContaCorrente();
//ContaCorrente cc2 = new ContaCorrente();
//ContaCorrente cc3 = cc1;

//cc1.NumeroConta = 1;
//cc2.NumeroConta = 1;
//cc1.Titular = "Paulo Henrique Sales Sampaio";
//cc2.Titular = "Laís Silva Amorim";

//MessageBox.Show("Iguais: " + cc1.Equals(cc2));
//MessageBox.Show("Iguais: " + cc1.Equals(cc3));


//MessageBox.Show(cc1.ToString());
//MessageBox.Show(cc2.ToString());
#endregion Testes na classe Object