using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_CaixaEletronico
{
    class ContaBancaria
    {
        //Atributos
        private double saldo;

        //Construtor
        public ContaBancaria(double val)
        {
            this.saldo = val;
        }


        //Metodos
        public void deposito(double val) 
        {

            if (val < 0) throw new ArgumentException("Valor de deposito inválido, valor menor que zero.");

            this.saldo += val;
        }

        public void saque (double val)
        {

            if (val < 0) throw new ArgumentException("Valor de saque inválido, valor menor que zero.");

            if (this.saldo <= 0) throw new ArgumentException("Conta com saldo zero ou negativo! Não é possível realizar saques.");

            if (val > this.saldo) throw new ArgumentException("Valor de saque inválido, valor maior que o saldo atual.");

            this.saldo -= val;
        }


        public double saldoConta()
        {
            return this.saldo;
        }

        override
        public String ToString()
        {
            return this.saldo.ToString("C");
        }


        public static int[] getNotas(double valorSaque, double opcao)
        {
            int[] qtsNotas = new int[4] { 0, 0, 0, 0 };     // pos 0 -> R$ opção
                                                            // pos 1 - > R$ 5,00
                                                            // pos 2 -> R$  1,00
                                                            // pos 3 -> centavos restantes



           int notasOP = (int) Math.Floor(valorSaque/opcao); //Acha quantas notas da quantidade escolhida
           qtsNotas[0] = notasOP;



            double restante = valorSaque - (notasOP * opcao); // Acha o valor restante

            if (restante > 0) // Se tem resto
            {
                int notas5 = (int)Math.Floor(restante / 5); //Acha quantas notas de R$ 5,00.
                qtsNotas[1] = notas5;

                restante = restante - (notas5 * 5);

                if (restante > 0) // Se tem resto
                {
                    int notas1 = (int)Math.Floor(restante / 1); //Acha quantas notas de R$ 1,00.
                    qtsNotas[2] = notas1;

                    restante = restante - (notas1 * 1); // Restante em centavos ou restante R$ 00,00
                    qtsNotas[3] =(int) (restante*100);

                }

            }

            return qtsNotas;
        }


    }
}
