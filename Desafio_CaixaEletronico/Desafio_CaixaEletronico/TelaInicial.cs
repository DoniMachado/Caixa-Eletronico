using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Desafio_CaixaEletronico
{
    public partial class FormInicial : Form
    {

        Thread t1;

        public FormInicial()
        {
            InitializeComponent();
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double saldoInicial = 0;
            try
            {
                //Recebe o valor do TextBox e o converte para double
                saldoInicial = Double.Parse(txtboxSaldoInicial.Text);
                
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Valor inválido. Digite um valor numérico válido!","Alerta de erro!",
                                MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtboxSaldoInicial.Text = "";
                txtboxSaldoInicial.Focus();
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Valor inválido. Digite um valor numérico válido! entre "+Double.MinValue+" e "+Double.MaxValue, "Alerta de erro!",
                                MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtboxSaldoInicial.Text = "";
                txtboxSaldoInicial.Focus();
                return;
            }

            var result = MessageBox.Show("Deseja confirmar a criação da conta bancária?\n\n"+ "Saldo disponível: " + saldoInicial.ToString("C"),
                "Confirmação de saldo bancário.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            //Chega aqui só em caso de valor válido
            if (result == DialogResult.OK)
            {
                this.Close();
                t1 = new Thread(abrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start(saldoInicial);
            }
            else if (result == DialogResult.Cancel)
            {
                
                txtboxSaldoInicial.Text = "";
                txtboxSaldoInicial.Focus();

            }
           
                               


        }

        private void abrirJanela(object obj)
        {
           
            Application.Run(new FormPrincipal(Double.Parse(obj.ToString() ) ) );

        }
    }
}
