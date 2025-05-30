﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double saldo =0;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumInserirValor_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtDepositar_Click(object sender, EventArgs e)
        {
            saldo += (double) NumInserirValor.Value;
            LbSaldodisponivel.Text = saldo.ToString("c");
        }

        private void BtSacar_Click(object sender, EventArgs e)
        {
            saldo -= (double)NumInserirValor.Value;
            LbSaldodisponivel.Text = saldo.ToString("c");
            if (saldo < (double)NumInserirValor.Value)
                MessageBox.Show("Saldo insuficiente");
            else
                MessageBox.Show("Transferência feita com sucesso!");
            
        }

        double taxa = 0.001;

        private void tmlJuros_Tick(object sender, EventArgs e)
        {
            saldo += saldo * taxa;
            LbSaldodisponivel.Text = saldo.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblTaxa.Text = $"* Taxa: {taxa * 100}% a.c{tmrJuros.Interval / 1000}s";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja sair da aplicação?", "Banco Taxed", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) 
                e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Tchau, pobre!");
        }
    }
} 
