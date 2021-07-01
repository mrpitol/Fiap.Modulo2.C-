using System;

namespace Fiap.Aula01.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler uma String
            //cw -> tab tab
            Console.WriteLine("Por favor, Digite um nome");
            string nome = Console.ReadLine();
            // Ler um número
            Console.WriteLine("Por favor, Digite sua idade");
            int idade = int.Parse(Console.ReadLine());   
           // Ler um dado
           Console.WriteLine($"O nome digitado é: {nome} e a idade é {idade}");
        }
    }
}
