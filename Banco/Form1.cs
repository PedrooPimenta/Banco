using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {

        private List<Conta> contas;
        private Dictionary<string, Conta> dicionario;
        public Form1()
        {
            InitializeComponent();

        }

        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta);
            comboContas.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<string, Conta>();

            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("Pedro");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Paula");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("Julia");
            c3.Numero = 3;
            this.AdicionaConta(c3);



        }


        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            Conta selecionada = (Conta)comboContas.SelectedItem;
            try
            {
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Deposito realizado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor invalido");
            }

        }


        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            Conta selecionada = (Conta)comboContas.SelectedItem;

            try
            {
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Saque realizado com sucesso.");
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
        }




        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioCadastro = new FormCadastroConta(this);
            formularioCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(300.0);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Adiciona(conta);
            MessageBox.Show("Total: " + totalizador.Total);
            totalizador.Adiciona(sv);
            MessageBox.Show("Total: " + totalizador.Total);

            if (conta is ContaCorrente)
            {
                totalizador.Adiciona(conta);
                MessageBox.Show("Total de Conta Corrente: " + totalizador.Total); //verificar pg 120 num 8
            }
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeTitular = textoBuscaTitular.Text;

                Conta conta = dicionario[nomeTitular];
                comboContas.SelectedItem = conta;
                
            }
            catch 
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }
    }
}
