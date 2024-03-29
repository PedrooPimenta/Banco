﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            try {
                listaResultado.Items.Clear();
                var resultado = from c in contas
                                where c.Saldo > 5000
                                orderby c.Titular descending, c.Numero descending
                                select c;
                foreach (var c in resultado)
                {
                    listaResultado.Items.Add(c);
                };

                double saldoTotal = resultado.Sum(conta => conta.Saldo);
                double maiorSaldo = resultado.Max(conta => conta.Saldo);

                labelSaldoTotal.Text = Convert.ToString(saldoTotal);
                labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);
            } catch (Exception)
            {
                MessageBox.Show("Nenhum registro");
            }
            }
            

        private void botaoAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where c.Saldo > 1000
                            select new { c.Numero, c.Titular };
            foreach (var c in resultado)
            {
                listaResultado.Items.Add(c);
            };

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

