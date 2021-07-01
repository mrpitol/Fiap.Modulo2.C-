using System;

namespace Fiap.Aula01.Exercicios01
{
    class Exercicios
    {
        static void Main(string[] args)
        {
          //Exercicio 01
          
           Console.WriteLine("Por favor, digitar o custo de Fabrica");
            double custoFabrica = int.Parse(Console.ReadLine());
            // Ler um número
            double percentualDistribuidor = 0.29;
            double percentualImpostos = 0.46;
            double custodoCarro = custoFabrica + (custoFabrica + percentualDistribuidor) + (custoFabrica + percentualImpostos);
            // Ler um dado
            Console.WriteLine($"O Custo do Carro é: {custodoCarro}");
            Console.WriteLine($"O Custo de Fabrica é: {custoFabrica}");
            Console.WriteLine($"O percentual do  Distribuidor é: {(custoFabrica + percentualDistribuidor)}");
            Console.WriteLine($"O percentual de  Impostos é: {custoFabrica + percentualImpostos}");
          
        }

    }

    }
    