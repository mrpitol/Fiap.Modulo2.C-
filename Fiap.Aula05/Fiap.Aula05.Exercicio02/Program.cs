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

            // Chamar o método1 para Calcular o desconto padrão 5% e exibir o resultado
            Console.WriteLine($"O valor com desconto padrão 5% é de R${livro.CalcularDesconto()}!!");
            
            // Chamar o método2 para Calcular o desconto de 20% e exibir o resultado
            Console.WriteLine($"O valor com desconto de 20% é de R${livro.CalcularDesconto(20)}!!");

            // Chamar o método3 para Calcular o desconto FIAP10 e exibir o resultado
            Console.WriteLine($"O valor com desconto FIAP10 é de R${livro.CalcularDesconto("FIAP10")}!!");

            //Chamar o método1 do eletronico  para calcular o valor da garantia e exibir o resultado
            Console.WriteLine($"O valor da Garantia é de {eletronico.CalcularGarantiaEstendida()}");

            //Chamar o método2 do eletronico para calcular o valor da garantia e exibir o resultado
            Console.WriteLine($"O valor da Garantia é de {eletronico.CalcularGarantiaEstendida("FIAP20",20)}");

            // Chamar o método3 para Calcular o desconto FIAP10 e exibir o resultado
            Console.WriteLine($"O valor com desconto FIAPBOOK é de R${livro.CalcularDesconto("FIAPBOOK")}!!");



        }//Main

    }//Class

}//namesapce
