using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Exercicio.Models
{
    class ContaPoupanca
    {
        //Propriedades
        public decimal Saldo { get; set; }
        public double Numero { get; set; }
        public decimal Rendimentos { get; set; }

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
        }

        public bool Retirar(decimal Valor)
        {
            if (Saldo > Valor)
            {
                Saldo = Saldo - Valor;
                return true;
            }
            else
            {
                Saldo = (Saldo + Valor)*-1;
                return false;
            }

        }
    }
}
