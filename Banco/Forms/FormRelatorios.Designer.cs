namespace Banco
{
    partial class FormRelatorios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.botaoAntigas = new System.Windows.Forms.Button();
            this.Resumo = new System.Windows.Forms.GroupBox();
            this.SaldoTotal = new System.Windows.Forms.Label();
            this.maiorSaldo = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.Resumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(13, 22);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(344, 264);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(13, 392);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(167, 23);
            this.botaoFiltroSaldo.TabIndex = 1;
            this.botaoFiltroSaldo.Text = "Saldo maior do que 500";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // botaoAntigas
            // 
            this.botaoAntigas.Location = new System.Drawing.Point(250, 392);
            this.botaoAntigas.Name = "botaoAntigas";
            this.botaoAntigas.Size = new System.Drawing.Size(105, 23);
            this.botaoAntigas.TabIndex = 2;
            this.botaoAntigas.Text = "Antigas";
            this.botaoAntigas.UseVisualStyleBackColor = true;
            this.botaoAntigas.Click += new System.EventHandler(this.botaoAntigas_Click);
            // 
            // Resumo
            // 
            this.Resumo.Controls.Add(this.labelMaiorSaldo);
            this.Resumo.Controls.Add(this.labelSaldoTotal);
            this.Resumo.Controls.Add(this.maiorSaldo);
            this.Resumo.Controls.Add(this.SaldoTotal);
            this.Resumo.Location = new System.Drawing.Point(13, 310);
            this.Resumo.Name = "Resumo";
            this.Resumo.Size = new System.Drawing.Size(344, 76);
            this.Resumo.TabIndex = 3;
            this.Resumo.TabStop = false;
            this.Resumo.Text = "Resumo";
            // 
            // SaldoTotal
            // 
            this.SaldoTotal.AutoSize = true;
            this.SaldoTotal.Location = new System.Drawing.Point(18, 25);
            this.SaldoTotal.Name = "SaldoTotal";
            this.SaldoTotal.Size = new System.Drawing.Size(61, 13);
            this.SaldoTotal.TabIndex = 0;
            this.SaldoTotal.Text = "Saldo Total";
            // 
            // maiorSaldo
            // 
            this.maiorSaldo.AutoSize = true;
            this.maiorSaldo.Location = new System.Drawing.Point(18, 60);
            this.maiorSaldo.Name = "maiorSaldo";
            this.maiorSaldo.Size = new System.Drawing.Size(63, 13);
            this.maiorSaldo.TabIndex = 1;
            this.maiorSaldo.Text = "Maior Saldo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(247, 25);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(0, 13);
            this.labelSaldoTotal.TabIndex = 2;
            this.labelSaldoTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(245, 51);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(0, 13);
            this.labelMaiorSaldo.TabIndex = 3;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.Resumo);
            this.Controls.Add(this.botaoAntigas);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Resumo.ResumeLayout(false);
            this.Resumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.Button botaoAntigas;
        private System.Windows.Forms.GroupBox Resumo;
        private System.Windows.Forms.Label SaldoTotal;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label maiorSaldo;
    }
}