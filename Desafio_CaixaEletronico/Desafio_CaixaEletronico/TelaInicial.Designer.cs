
namespace Desafio_CaixaEletronico
{
    partial class FormInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelMSG = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtboxSaldoInicial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.Location = new System.Drawing.Point(308, 72);
            this.labelBemVindo.Name = "labelBemVindo";
            this.labelBemVindo.Size = new System.Drawing.Size(154, 13);
            this.labelBemVindo.TabIndex = 0;
            this.labelBemVindo.Text = "Seja bem-vindo ao SimuCash ! \r\n";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(288, 108);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(191, 13);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "O melhor simulador de caixa-eletrônico.";
            // 
            // labelMSG
            // 
            this.labelMSG.AutoSize = true;
            this.labelMSG.Location = new System.Drawing.Point(174, 188);
            this.labelMSG.Name = "labelMSG";
            this.labelMSG.Size = new System.Drawing.Size(178, 13);
            this.labelMSG.TabIndex = 3;
            this.labelMSG.Text = "Digite um valor para seu saldo inicial";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(325, 252);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtboxSaldoInicial
            // 
            this.txtboxSaldoInicial.Location = new System.Drawing.Point(362, 185);
            this.txtboxSaldoInicial.Name = "txtboxSaldoInicial";
            this.txtboxSaldoInicial.Size = new System.Drawing.Size(125, 20);
            this.txtboxSaldoInicial.TabIndex = 5;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.txtboxSaldoInicial);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labelMSG);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelBemVindo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafio Caixa Eletronico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBemVindo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelMSG;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtboxSaldoInicial;
    }
}

