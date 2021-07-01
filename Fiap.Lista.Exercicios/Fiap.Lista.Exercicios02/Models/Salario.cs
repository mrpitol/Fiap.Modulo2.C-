using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Lista.Exercicios02.Models
{
    class Salario
    {
        public double ValorBruto { get; set; }
         
        
        public double CalcularINSS( Double ValorBruto) 
        {
            return (ValorBruto*0.2); 
        }

        public double ObterValorLiquido(double ValorBruto , double DescontoINSS)
        {
            return (ValorBruto - DescontoINSS);
        }
    }
}
