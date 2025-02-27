using System;
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

        }
    }
}
