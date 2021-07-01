using System;
using Fiap_Aula02.Exemplo01.Models;

namespace Fiap_Aula02.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar um produto
            // ctrl + .  ou Alt + enter
            //Variavéis não são inicilizadas automaticamente com o valor padrão - apenas atributos.

            Produto notebook = new Produto();

            // Atribuir valores para os atributos - ver classe produto
            notebook.Id = 10;
            notebook.Nome = "vostro D1510";
            notebook.Valor = 1000; // devido ao private no set (independente do atributo definido

            //notebook.Fabricante.Nome = "Dell"; - nullReferenceException - Não foi criado o objeto do fabricante
            
            // Precisa então criar um novo objeto para depois instanciar o nome 

           // instaciar um fabricante
            Fabricante fabricante = new Fabricante();
            fabricante.Nome = "Dell";
            fabricante.Ativo = true;

            // Atribuir o objeto fabricante no atributo do objeto produto
            notebook.Fabricante =fabricante;

            // Recuperar e exibir os valores dos atributos
            Console.WriteLine(notebook.Id);

            //Exibir o nome do fabricante e se esta ativo ou não
            Console.WriteLine($"{notebook.Fabricante.Nome} está ativo: {notebook.Fabricante.Ativo}");
            // ao rodar tera Dell esta ativo: false - default de bool é false

            // Calcular e Exibir o valor do Notebook com 15% de Desconto
           decimal valor = notebook.CalcularDesconto(15);
            Console.WriteLine($"O produto com desconto é {valor}");


        }
    }
}
