using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Exercicio.Models
{
    class ContaPoupanca:Conta
    {
        //Propriedades
        //public decimal Saldo { get;  set; }// não permite escrita direta apenas utilizando os metodos
        //public double Numero { get; set; }
        public decimal Rendimentos { get; set; }
       

        /*public bool Depositar(decimal Valor)
        {
            if (Saldo >= 0)
            {
                Saldo += Valor;
                return true;    
            }
            return false;
        }//Depositar - tirado do filho e colocado no pai - conta*/

        public bool Retirar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }//Retirar

    }//Class

}//namespace
