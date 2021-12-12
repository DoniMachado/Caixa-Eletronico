
namespace Desafio_CaixaEletronico
{
    partial class FormPrincipal
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
            this.labelSaldo = new System.Windows.Forms.Label();
            this.btnConfirmarOP = new System.Windows.Forms.Button();
            this.rbDeposito = new System.Windows.Forms.RadioButton();
            this.rbSaque = new System.Windows.Forms.RadioButton();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.gbSaque = new System.Windows.Forms.GroupBox();
            this.txbValorOp = new System.Windows.Forms.TextBox();
            this.lbValorOp = new System.Windows.Forms.Label();
            this.rb20 = new System.Windows.Forms.RadioButton();
            this.rb50 = new System.Windows.Forms.RadioButton();
            this.rb100 = new System.Windows.Forms.RadioButton();
            this.gbOpcoes.SuspendLayout();
            this.gbSaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(282, 55);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(84, 13);
            this.labelSaldo.TabIndex = 0;
            this.labelSaldo.Text = "Saldo bancário: ";
            // 
            // btnConfirmarOP
            // 
            this.btnConfirmarOP.Location = new System.Drawing.Point(325, 252);
            this.btnConfirmarOP.Name = "btnConfirmarOP";
            this.btnConfirmarOP.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarOP.TabIndex = 1;
            this.btnConfirmarOP.Text = "Confirmar";
            this.btnConfirmarOP.UseVisualStyleBackColor = true;
            this.btnConfirmarOP.Click += new System.EventHandler(this.btnConfirmarOP_Click);
            // 
            // rbDeposito
            // 
            this.rbDeposito.AutoSize = true;
            this.rbDeposito.Location = new System.Drawing.Point(6, 33);
            this.rbDeposito.Name = "rbDeposito";
            this.rbDeposito.Size = new System.Drawing.Size(67, 17);
            this.rbDeposito.TabIndex = 2;
            this.rbDeposito.TabStop = true;
            this.rbDeposito.Text = "Deposito";
            this.rbDeposito.UseVisualStyleBackColor = true;
            // 
            // rbSaque
            // 
            this.rbSaque.AutoSize = true;
            this.rbSaque.Location = new System.Drawing.Point(6, 56);
            this.rbSaque.Name = "rbSaque";
            this.rbSaque.Size = new System.Drawing.Size(56, 17);
            this.rbSaque.TabIndex = 3;
            this.rbSaque.TabStop = true;
            this.rbSaque.Text = "Saque";
            this.rbSaque.UseVisualStyleBackColor = true;
            this.rbSaque.CheckedChanged += new System.EventHandler(this.rbSaque_CheckedChanged);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.rbDeposito);
            this.gbOpcoes.Controls.Add(this.rbSaque);
            this.gbOpcoes.ForeColor = System.Drawing.Color.Black;
            this.gbOpcoes.Location = new System.Drawing.Point(22, 87);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(180, 83);
            this.gbOpcoes.TabIndex = 4;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Operações Disponíveis";
            // 
            // gbSaque
            // 
            this.gbSaque.Controls.Add(this.rb100);
            this.gbSaque.Controls.Add(this.rb50);
            this.gbSaque.Controls.Add(this.rb20);
            this.gbSaque.Location = new System.Drawing.Point(591, 87);
            this.gbSaque.Name = "gbSaque";
            this.gbSaque.Size = new System.Drawing.Size(180, 115);
            this.gbSaque.TabIndex = 5;
            this.gbSaque.TabStop = false;
            this.gbSaque.Text = "Opções de Saque";
            // 
            // txbValorOp
            // 
            this.txbValorOp.Location = new System.Drawing.Point(375, 117);
            this.txbValorOp.Name = "txbValorOp";
            this.txbValorOp.Size = new System.Drawing.Size(133, 20);
            this.txbValorOp.TabIndex = 6;
            // 
            // lbValorOp
            // 
            this.lbValorOp.AutoSize = true;
            this.lbValorOp.Location = new System.Drawing.Point(248, 122);
            this.lbValorOp.Name = "lbValorOp";
            this.lbValorOp.Size = new System.Drawing.Size(97, 13);
            this.lbValorOp.TabIndex = 7;
            this.lbValorOp.Text = "Valor da operação:";
            // 
            // rb20
            // 
            this.rb20.AutoSize = true;
            this.rb20.Location = new System.Drawing.Point(6, 33);
            this.rb20.Name = "rb20";
            this.rb20.Size = new System.Drawing.Size(69, 17);
            this.rb20.TabIndex = 0;
            this.rb20.TabStop = true;
            this.rb20.Text = "R$ 20,00";
            this.rb20.UseVisualStyleBackColor = true;
            // 
            // rb50
            // 
            this.rb50.AutoSize = true;
            this.rb50.Location = new System.Drawing.Point(6, 56);
            this.rb50.Name = "rb50";
            this.rb50.Size = new System.Drawing.Size(69, 17);
            this.rb50.TabIndex = 1;
            this.rb50.TabStop = true;
            this.rb50.Text = "R$ 50,00";
            this.rb50.UseVisualStyleBackColor = true;
            // 
            // rb100
            // 
            this.rb100.AutoSize = true;
            this.rb100.Location = new System.Drawing.Point(6, 79);
            this.rb100.Name = "rb100";
            this.rb100.Size = new System.Drawing.Size(75, 17);
            this.rb100.TabIndex = 2;
            this.rb100.TabStop = true;
            this.rb100.Text = "R$ 100,00";
            this.rb100.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.lbValorOp);
            this.Controls.Add(this.txbValorOp);
            this.Controls.Add(this.gbSaque);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.btnConfirmarOP);
            this.Controls.Add(this.labelSaldo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafio Caixa Eletronico";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPrincipal_Paint);
            this.gbOpcoes.ResumeLayout(false);
            this.gbOpcoes.PerformLayout();
            this.gbSaque.ResumeLayout(false);
            this.gbSaque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button btnConfirmarOP;
        private System.Windows.Forms.RadioButton rbDeposito;
        private System.Windows.Forms.RadioButton rbSaque;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.GroupBox gbSaque;
        private System.Windows.Forms.TextBox txbValorOp;
        private System.Windows.Forms.Label lbValorOp;
        private System.Windows.Forms.RadioButton rb100;
        private System.Windows.Forms.RadioButton rb50;
        private System.Windows.Forms.RadioButton rb20;
    }
}