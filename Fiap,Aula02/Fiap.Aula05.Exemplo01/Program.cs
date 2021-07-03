using System;
using Fiap.Aula05.Exemplo01.Models;

namespace Fiap_Aula02._Exercicio01
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            //Definir os objetos
            Aviao aviao = new Aviao();
            Carro carro = new Carro();
            Lancha lancha = new Lancha();
            Cor cor = new Cor();

            //Atribuir valores para os atributos
            //ler os dados
            Console.WriteLine("Digite o Modelo do Carro");
            carro.Modelo = Console.ReadLine();

            Console.WriteLine("Digite o Ano do Carro");
            carro.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Comprimento do Carro");
            carro.Comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Placa do Carro");
            carro.Placa = Console.ReadLine();

            Console.WriteLine("Digite o Valor do Carro");
            carro.Valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("O Carro possui ar Condicinado?");
            carro.Placa = Console.ReadLine();

            Console.WriteLine("Digite a Cor do Carro");
            cor.Nome = Console.ReadLine();

            Console.WriteLine("Digite o R da cor");
            cor.R = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o G da cor");
            cor.G = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o B da cor");
            cor.B = int.Parse(Console.ReadLine());

            //atribuir cor ao carro
            carro.Cor = cor;

            //Exibir os dados do carro
            Console.WriteLine($"Modelo: { carro.Modelo}, ano: { carro.Ano}," +
            $"Comprimento: { carro.Comprimento},placa: {carro.Placa}," +
            $"valor: { carro.Valor},ar condicionado: {carro.ArCondicionado}," +
            $"cor: { carro.Cor.Nome} (R:{ carro.Cor.R},G:{ carro.Cor.G},B:{ carro.Cor.B})");


        }
    }
}
