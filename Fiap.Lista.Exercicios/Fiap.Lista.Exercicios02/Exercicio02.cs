using System;
using Fiap.Lista.Exercicios02.Models;

namespace Fiap.Lista.Exercicios02
{
    class Exercicio02
    {
        static void Main(string[] args)
        {
            double DescontoInss;
            Salario salario = new Salario();
            //Solicita o Valor Bruto
            Console.WriteLine("Por Favor, Digite o Valor Bruto do Salário");
            salario.ValorBruto = double.Parse(Console.ReadLine());
            Console.WriteLine($"O Valor Bruto é: {salario.ValorBruto}");
            //Calcular o Desconto do INSS
            Console.WriteLine($"O Desconto é: {DescontoInss = salario.CalcularINSS(salario.ValorBruto)}");

            Console.WriteLine($"O Valor Liquido é: {salario.ObterValorLiquido(salario.ValorBruto, DescontoInss)}");

        }//Main
    }//Class

}//namespace
