using System;

namespace Fiap.Aula01.Exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler uma String
            Console.WriteLine("Por favor, Digite o valor das vendas");
            double vendas = int.Parse(Console.ReadLine());
            double comissao;
            string cond;
            if (vendas > 1500)
            {
                comissao = 0.1;
                cond = "acima";
            }
            else 
            {
                comissao = 0.05;
                cond = "abaixo";
            }
            Double Salario= 15w00*(1+comissao);
            // Ler um dado
            Console.WriteLine($"O Salario do Vendedor é: {Salario} com comissao de {(comissao*100)}% - {10000 * (comissao)} por vender  {vendas-1500} {cond} da meta");
        }
    }
}
