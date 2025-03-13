namespace CaixaEletronica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbValor = new System.Windows.Forms.Label();
            this.NumInserirValor = new System.Windows.Forms.NumericUpDown();
            this.BtDepositar = new System.Windows.Forms.Button();
            this.BtSacar = new System.Windows.Forms.Button();
            this.LbSaldo = new System.Windows.Forms.Label();
            this.LbSaldodisponivel = new System.Windows.Forms.Label();
            this.LbLimite = new System.Windows.Forms.Label();
            this.NumLimite = new System.Windows.Forms.NumericUpDown();
            this.tmrJuros = new System.Windows.Forms.Timer(this.components);
            this.LblTaxa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumInserirValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // LbValor
            // 
            this.LbValor.AutoSize = true;
            this.LbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbValor.Location = new System.Drawing.Point(138, 64);
            this.LbValor.Name = "LbValor";
            this.LbValor.Size = new System.Drawing.Size(114, 31);
            this.LbValor.TabIndex = 0;
            this.LbValor.Text = "VALOR:";
            // 
            // NumInserirValor
            // 
            this.NumInserirValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumInserirValor.Location = new System.Drawing.Point(245, 62);
            this.NumInserirValor.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.NumInserirValor.Name = "NumInserirValor";
            this.NumInserirValor.Size = new System.Drawing.Size(120, 38);
            this.NumInserirValor.TabIndex = 1;
            this.NumInserirValor.ValueChanged += new System.EventHandler(this.NumInserirValor_ValueChanged);
            // 
            // BtDepositar
            // 
            this.BtDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDepositar.Location = new System.Drawing.Point(86, 112);
            this.BtDepositar.Name = "BtDepositar";
            this.BtDepositar.Size = new System.Drawing.Size(188, 36);
            this.BtDepositar.TabIndex = 2;
            this.BtDepositar.Text = "DEPOSITAR";
            this.BtDepositar.UseVisualStyleBackColor = true;
            this.BtDepositar.Click += new System.EventHandler(this.BtDepositar_Click);
            // 
            // BtSacar
            // 
            this.BtSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSacar.Location = new System.Drawing.Point(280, 112);
            this.BtSacar.Name = "BtSacar";
            this.BtSacar.Size = new System.Drawing.Size(170, 36);
            this.BtSacar.TabIndex = 3;
            this.BtSacar.Text = "SACAR";
            this.BtSacar.UseVisualStyleBackColor = true;
            this.BtSacar.Click += new System.EventHandler(this.BtSacar_Click);
            // 
            // LbSaldo
            // 
            this.LbSaldo.AutoSize = true;
            this.LbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSaldo.Location = new System.Drawing.Point(138, 163);
            this.LbSaldo.Name = "LbSaldo";
            this.LbSaldo.Size = new System.Drawing.Size(114, 31);
            this.LbSaldo.TabIndex = 4;
            this.LbSaldo.Text = "SALDO:";
            // 
            // LbSaldodisponivel
            // 
            this.LbSaldodisponivel.AutoSize = true;
            this.LbSaldodisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSaldodisponivel.Location = new System.Drawing.Point(248, 163);
            this.LbSaldodisponivel.Name = "LbSaldodisponivel";
            this.LbSaldodisponivel.Size = new System.Drawing.Size(57, 31);
            this.LbSaldodisponivel.TabIndex = 6;
            this.LbSaldodisponivel.Text = "R$:";
            this.LbSaldodisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbSaldodisponivel.Click += new System.EventHandler(this.label3_Click);
            // 
            // LbLimite
            // 
            this.LbLimite.AutoSize = true;
            this.LbLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLimite.Location = new System.Drawing.Point(156, 244);
            this.LbLimite.Name = "LbLimite";
            this.LbLimite.Size = new System.Drawing.Size(110, 31);
            this.LbLimite.TabIndex = 7;
            this.LbLimite.Text = "LIMITE:";
            // 
            // NumLimite
            // 
            this.NumLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumLimite.Location = new System.Drawing.Point(264, 244);
            this.NumLimite.Name = "NumLimite";
            this.NumLimite.Size = new System.Drawing.Size(120, 38);
            this.NumLimite.TabIndex = 8;
            // 
            // tmrJuros
            // 
            this.tmrJuros.Enabled = true;
            this.tmrJuros.Interval = 5000;
            this.tmrJuros.Tick += new System.EventHandler(this.tmlJuros_Tick);
            // 
            // LblTaxa
            // 
            this.LblTaxa.AutoSize = true;
            this.LblTaxa.Location = new System.Drawing.Point(141, 327);
            this.LblTaxa.Name = "LblTaxa";
            this.LblTaxa.Size = new System.Drawing.Size(35, 13);
            this.LblTaxa.TabIndex = 9;
            this.LblTaxa.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTaxa);
            this.Controls.Add(this.NumLimite);
            this.Controls.Add(this.LbLimite);
            this.Controls.Add(this.LbSaldodisponivel);
            this.Controls.Add(this.LbSaldo);
            this.Controls.Add(this.BtSacar);
            this.Controls.Add(this.BtDepositar);
            this.Controls.Add(this.NumInserirValor);
            this.Controls.Add(this.LbValor);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumInserirValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbValor;
        private System.Windows.Forms.NumericUpDown NumInserirValor;
        private System.Windows.Forms.Button BtDepositar;
        private System.Windows.Forms.Button BtSacar;
        private System.Windows.Forms.Label LbSaldo;
        private System.Windows.Forms.Label LbSaldodisponivel;
        private System.Windows.Forms.Label LbLimite;
        private System.Windows.Forms.NumericUpDown NumLimite;
        private System.Windows.Forms.Timer tmrJuros;
        private System.Windows.Forms.Label LblTaxa;
    }
}

