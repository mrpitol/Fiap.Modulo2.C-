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
        public double juros { get; set; }


        public bool Depositar(decimal Valor)
        {
            if (Saldo > 0)
            {
                Saldo = Saldo + Valor;
                return true;
            }
            else
            {
                Saldo = Saldo;
                return false;
            }
        }//Depositar

        public bool Retirar(decimal Valor)
        {
            if ((Saldo > Valor) & Especial)
            {
                Saldo = (Saldo + Limite) - Valor;
                return true;
            }
            else
            {
                Saldo = Saldo - Valor;
                return false;
            }

        }//Retirar

        public decimal RetornarSaldoTotal()
        {
            return Saldo;
        }// RetornarSaldoTotal


        public bool TransferirParaPoupanca(decimal Valor)
        {

        }//TransferirParaPoupanca
        public bool CalcularValorTaxaJuros(decimal Valor)
        {

        }//CalcularValorTaxaJuros

    }//Class
}//namespace
