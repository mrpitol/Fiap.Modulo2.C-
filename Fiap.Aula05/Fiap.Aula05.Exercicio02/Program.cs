using System;
using Fiap.Aula05.Exercicio02.Models;
namespace Fiap.Aula05.Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar um Produto, Eletronico, Livro e Perecivel
            var produto = new Produto(1, "Camiseta");
            var eletronico = new Eletronico(2, "Notebook")
            {
                Garantia = true,
                Preco =2500

            };
            var livro = new Livro(3, "O poder do Habito", "Charles Duhigg")
            {
                Preco=40
            };
            //DateTime -> Utiliza o Construtor com ano mes e dia
            var arroz = new Perecivel(4, "Arroz", new DateTime(2022, 12, 25));

            // Chamar o método para Calcular o desconto e exibir o resultado
            Console.WriteLine($"O valor com desconto é de R${livro.CalcularDesconto(20)}!!");

            //Chamar o método para calcular o valor da garantia e exibir o resultado
            Console.WriteLine($"O valor da Garantia é de {eletronico.CalcularGarantiaEstendida()}");

        }
    }
}
