using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_CaixaEletronico
{
    public partial class FormPrincipal : Form
    {

        private ContaBancaria ctb;


        public FormPrincipal(double temp)
        {
            InitializeComponent();
            ctb = new ContaBancaria(temp);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            labelSaldo.Text = "Saldo bancário inicial: "+this.ctb.ToString();            
            gbSaque.Visible = false;
        }

        private void btnConfirmarOP_Click(object sender, EventArgs e)
        {
            if (!rbDeposito.Checked && !rbSaque.Checked) 
            {

                 MessageBox.Show("Não foi selecionado nenhuma opção de operação",
                "Selecione uma opção de operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rbDeposito.Checked) //Operação de deposito
                {
                    //Código de Deposito
                    double valorOperacao = 0;
                    try
                    {
                        //Recebe o valor do TextBox e o converte para double
                        valorOperacao = Double.Parse(txbValorOp.Text);
                        valorOperacao = Math.Round(valorOperacao, 2);
                        this.ctb.deposito(valorOperacao);


                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Valor inválido. Digite um valor numérico válido!", "Alerta de erro!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbValorOp.Text = "";
                        txbValorOp.Focus();
                        return;
                    }
                    catch (OverflowException ex)
                    {
                        MessageBox.Show("Valor inválido. Digite um valor numérico válido! entre " + Double.MinValue + " e " + Double.MaxValue, "Alerta de erro!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbValorOp.Text = "";
                        txbValorOp.Focus();
                        return;
                    }
                    catch (ArgumentException ex)
                    {

                        MessageBox.Show(ex.Message, "Alerta de erro!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbValorOp.Text = "";
                        txbValorOp.Focus();
                        return;
                    }

                    this.Refresh(); //Redesenha a tela com valores atualizados



                }
                else //Operação de saque
                {
                                        

                    if (!rb20.Checked && !rb50.Checked && !rb100.Checked)
                    {
                        MessageBox.Show("Não foi selecionado nenhuma opção de saque",
                            "Selecione uma opção de saque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {


                        //Código de Saque
                        double valorOperacao = 0;
                        try
                        {
                            //Recebe o valor do TextBox e o converte para double
                            valorOperacao = Double.Parse(txbValorOp.Text);
                            valorOperacao = Math.Round(valorOperacao, 2);
                            this.ctb.saque(valorOperacao);


                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Valor inválido. Digite um valor numérico válido!", "Alerta de erro!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbValorOp.Text = "";
                            txbValorOp.Focus();
                            return;
                        }
                        catch (OverflowException ex)
                        {
                            MessageBox.Show("Valor inválido. Digite um valor numérico válido! entre " + Double.MinValue + " e " + Double.MaxValue, "Alerta de erro!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbValorOp.Text = "";
                            txbValorOp.Focus();
                            return;
                        }
                        catch (ArgumentException ex)
                        {

                            MessageBox.Show(ex.Message, "Alerta de erro!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbValorOp.Text = "";
                            txbValorOp.Focus();
                            return;
                        }


                        //Se chegou aqui a operação de saque foi concluída com sucesso


                        if (rb20.Checked) //Selecionou a opção de receber o saque em notas de R$ 20,00
                        {
                            int[] notas = ContaBancaria.getNotas(valorOperacao,20);
                            MessageBox.Show("Valor do Saque: "+ valorOperacao+
                                            "\n\nNotas de R$ 20,00 : " + notas[0]+
                                            "\nNotas de R$ 5,00 : " + notas[1] +
                                            "\nNotas de R$ 1,00 : " + notas[2] +
                                            "\nCentavos restantes : " + notas[3] , "Quantidade de notas obtidas!",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (rb50.Checked) //Selecionou a opção de receber o saque em notas de R$ 50,00
                        {
                            int[] notas = ContaBancaria.getNotas(valorOperacao, 50);
                            MessageBox.Show("Valor do Saque: " + valorOperacao +
                                            "\n\nNotas de R$ 50,00 : " + notas[0] +
                                            "\nNotas de R$ 5,00 : " + notas[1] +
                                            "\nNotas de R$ 1,00 : " + notas[2] +
                                            "\nCentavos restantes : " + notas[3], "Quantidade de notas obtidas!",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else //Selecionou a opção de receber o saque em notas de R$ 100,00
                        {
                            int[] notas = ContaBancaria.getNotas(valorOperacao, 100);
                            MessageBox.Show("Valor do Saque: " + valorOperacao +
                                            "\n\nNotas de R$ 100,00 : " + notas[0] +
                                            "\nNotas de R$ 5,00 : " + notas[1] +
                                            "\nNotas de R$ 1,00 : " + notas[2] +
                                            "\nCentavos restantes : " + notas[3], "Quantidade de notas obtidas!",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        this.Refresh(); //Redesenha a tela com valores atualizados


                    }                   

                }
                
            }



        }

        private void rbSaque_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSaque.Checked)
            {
                gbSaque.Visible = true;
            }
            else
            {
                gbSaque.Visible = false;
                rb100.Checked = false;
                rb50.Checked = false;
                rb20.Checked = false;
            }

        }

        private void FormPrincipal_Paint(object sender, PaintEventArgs e)
        {
            labelSaldo.Text = "Saldo bancário atualizado: " + this.ctb.ToString();
        }
    }
}
