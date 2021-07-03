using System;
using Fiap.Aula04.Exemplo01.Models;


namespace Fiap.Aula04.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro utilizando o construtor padrão
            // var gol = new Carro();
            //Ao definir um construtor você não pode mais declarar o padrão
            //mas deve declarar considerando o parametro.

           //instanciar um carro utilizando o construtor com um argumemto
            var celta = new Carro("Celta 1.0");

            //instanciar um carro utilizando o construtor com dois argumentos
            var gol = new Carro("gol",2020);

            //Exibir Valores dos objetos
            Console.WriteLine($"Modelo: {celta.Modelo}, Ano: {celta.Ano}");
            Console.WriteLine($"Modelo: {gol.Modelo}, Ano: {gol.Ano}");

            //Instanciar a moto com o construtor padrão, infomando os valores para as propriedades

            var honda = new Moto()
            {
                Cilindrada = 1000,
                Passageiros = 2

            };//Construtor

            //Exibir os dados da moto
            Console.WriteLine($"Cilindrada: {honda.Cilindrada}, Passageiros: {honda.Passageiros}");

        }//Main

    }//Class

}//namespace
