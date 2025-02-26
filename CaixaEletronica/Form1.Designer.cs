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
            this.LbValor = new System.Windows.Forms.Label();
            this.InserirValor = new System.Windows.Forms.NumericUpDown();
            this.BtDepositar = new System.Windows.Forms.Button();
            this.BtSacar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.InserirValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // LbValor
            // 
            this.LbValor.AutoSize = true;
            this.LbValor.Location = new System.Drawing.Point(138, 64);
            this.LbValor.Name = "LbValor";
            this.LbValor.Size = new System.Drawing.Size(46, 13);
            this.LbValor.TabIndex = 0;
            this.LbValor.Text = "VALOR:";
            // 
            // InserirValor
            // 
            this.InserirValor.Location = new System.Drawing.Point(190, 62);
            this.InserirValor.Name = "InserirValor";
            this.InserirValor.Size = new System.Drawing.Size(120, 20);
            this.InserirValor.TabIndex = 1;
            // 
            // BtDepositar
            // 
            this.BtDepositar.Location = new System.Drawing.Point(166, 112);
            this.BtDepositar.Name = "BtDepositar";
            this.BtDepositar.Size = new System.Drawing.Size(108, 23);
            this.BtDepositar.TabIndex = 2;
            this.BtDepositar.Text = "DEPOSITAR";
            this.BtDepositar.UseVisualStyleBackColor = true;
            // 
            // BtSacar
            // 
            this.BtSacar.Location = new System.Drawing.Point(280, 112);
            this.BtSacar.Name = "BtSacar";
            this.BtSacar.Size = new System.Drawing.Size(109, 23);
            this.BtSacar.TabIndex = 3;
            this.BtSacar.Text = "SACAR";
            this.BtSacar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(235, 180);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtSacar);
            this.Controls.Add(this.BtDepositar);
            this.Controls.Add(this.InserirValor);
            this.Controls.Add(this.LbValor);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            ((System.ComponentModel.ISupportInitialize)(this.InserirValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbValor;
        private System.Windows.Forms.NumericUpDown InserirValor;
        private System.Windows.Forms.Button BtDepositar;
        private System.Windows.Forms.Button BtSacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

