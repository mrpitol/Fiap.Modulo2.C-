using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Exercicio.Models
{
    class ContaCorrente
    {
        //Propriedades
        public decimal Saldo { get; set; }
        public double Numero  { get; set; }
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

        //Metodos
        public bool Depositar(decimal valor)
        {
            if (Saldo > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }//Depositar

        public bool Retirar(decimal valor)
        {
            /*if (Especial)
            {
                if (valor <= Saldo + Limite)
                {
                    Saldo -= valor;
                    return true;
                }
            }// Especial true
            else
            { 
                if (valor<= Saldo)
                    Saldo = valor;
                return true;    
            }//Especial else*/
            // Ternario (Condição ? se verdadeiro : Se falso)
            if ((Especial && valor <= Saldo + Limite) || (valor <= Saldo))
            {
                Saldo -= valor;
                return true;
            }

            return false;
        }//Retirar
        public decimal RetornarSaldoTotal()
        {
            // Ternario (Condição ? se verdadeiro : Se falso)
            return Especial ? Saldo+Limite : Saldo;

            /*if (Especial)
            {
                return Saldo + Limite;
            }//if
            else 
            {
                return Saldo;
            }//else*/

        }// RetornarSaldoTotal


        public bool TransferirParaPoupanca(decimal valor)
        {
            //Retirar da conta corrente, se conseguir adiciona o valor na conta poupança
            // Chama o método retirar da cc e valida se foi possive
            if (Retirar(valor))
            {
                ContaPoupanca.Depositar(valor);
                return true;
            }   
             return false;

        }//TransferirParaPoupanca
        public decimal CalcularValorTaxaJuros(int dias)
        {
            // Ternario (Condição ? se verdadeiro : Se falso)

            return (Saldo < 0) ? dias * Convert.ToDecimal(Juros) * Saldo * -1 :  0;

        }//CalcularValorTaxaJuros

    }//Class
}//namespace
