using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Exercicio.Models
{
    abstract class Conta
    {
        public decimal Saldo { get; protected set; } // não permite escrita direta apenas utilizando os metodos
        public double Numero { get; set; }

        public bool Depositar(decimal valor)
        {
            if (Saldo >= 0)
            {
                Saldo += valor;
                return true;
            }
            throw new Exception("Valor Invalido");
        }//Deposita
    }
}
