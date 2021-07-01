using System;
using Fiap.Lista.Exercicios03.Models;

namespace Fiap.Lista.Exercicios03
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            CalculadoraFinanceira Calc =new CalculadoraFinanceira();

            double DescontoInss;
            //Solicita capital
            Console.WriteLine("Por Favor, Digite o Valor do Capital");
            double capital = double.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor, Digite o Valor dos Juros");
            double juros = double.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor, Digite o Perido");
            double periodo = double.Parse(Console.ReadLine());

            Console.WriteLine($"Para o Capital {capital} " +
                $"Juro simples montante = {Calc.CalcularJurosSimples(capital, juros, periodo)}");

            Console.WriteLine($"Para o Capital {capital} " +
                $"Juro composto montante = {Calc.CalcularJurosComposto(capital, juros, periodo)}");
        }
    }
}
