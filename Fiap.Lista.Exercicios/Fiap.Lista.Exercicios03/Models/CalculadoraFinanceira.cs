using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Lista.Exercicios03.Models
{
    class CalculadoraFinanceira
    {
        public double CalcularJurosSimples(double Capital, double TaxadeJuros, double Periodo) 
        {
        return Capital*(1+TaxadeJuros*Periodo);
        }//CalcJurosSimple

        public double CalcularJurosComposto(double Capital, double TaxadeJuros, double Periodo)
        {
            return Capital * (Math.Pow((1+TaxadeJuros), Periodo));

        }//CalcJurosComposto

    }//Class

}//namespace
