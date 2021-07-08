using System;
using System.Collections.Generic;
using System.Linq;
using Fiap.Aula07.Exercicio.Models;

namespace Fiap.Aula07.Exercicio
{
    class Program
    {
        static void Main(string[] args)


        {
           
            //Criar uma lista para armazenar alunos
            var lista = new List<Aluno>();

            do
            {


                //Ler os dados Alunos
                Console.WriteLine("Por valor Digite o nome do Aluno");
                var nome = Console.ReadLine();

                Console.WriteLine("Por valor Digite a nota do Aluno");
                var nota = float.Parse(Console.ReadLine());

                Console.WriteLine("Por valor Digite o Genero do Aluno");
                //Transforma uma string em um valor do Enum, (Genero) cast -> forçar o objeto ser do tipo genero
                                                                                      //Não diferencia Maiuscula de Minuscula
                Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(),true);
                //Instanciar o aluno com Valores
                Aluno aluno = new Aluno()
                {
                    Genero = genero,
                    Nome = nome,
                    Nota = nota
                };

                //Adicionar o objeto aluno na lista
                lista.Add(aluno);
                Console.WriteLine("Por valor deseja adicionar mais um Aluno? (true / false)");

            } while (bool.Parse(Console.ReadLine()));

            //Percorrer a lista e exibir o nome dos Alunos
            for(int i = 0;i<lista.Count; i++)
            {
                Console.WriteLine(lista[i].Nome);
            }//for
            float somaNotas = 0;
            foreach (var item in lista)
            {
                Console.WriteLine(item.Nome);
                somaNotas += item.Nota;
            }//foreach

            //Exibir o total de alunos cadastrados
            Console.WriteLine($"Total de alunos: {lista.Count}");


            //Exibir a média geral das notas
            Console.WriteLine($"A média das notas dos alunos é: {somaNotas/lista.Count}");
            //Outro modo                                           //Average -> Método que retorna a média
                                                                   // a = aluno
            Console.WriteLine($"\nA média das notas dos alunos é: { lista.Average(a=>a.Nota)}");

            //Exibir porcenteagem por genero                       //
            Console.WriteLine($"\nA Porcentagem de alunas: { (float) lista.Count(g => g.Genero == Genero.Feminino)/lista.Count*100}%");
            Console.WriteLine($"\nA Porcentagem de alunos: {(float)lista.Count(g => g.Genero == Genero.Masculino) / lista.Count*100 }%");
            Console.WriteLine($"\nA Porcentagem de outros: { (float)lista.Count(g => g.Genero == Genero.Outros) / lista.Count*100 }%");
            //ctrl d - dulpica a linha
            int opcao;
            do
            {
                Console.WriteLine("\nDigite: \n1 Exibir nome e médias \n2-Alunos com Notas acima de 6.0 \n3-Aluno por Genero \n0-Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        //exibir o nome é média de todos os aluno
                        foreach (var item in lista)
                        {
                            Console.WriteLine($"Nome:{item.Nome},Média: {item.Nota}");
                        }
                        break;
                    case 2:
                        //exibir o nome é média de todos os aluno
                        var listaFiltrada = lista.Where(x => x.Nota > 6).ToList();
                        foreach (var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome:{item.Nome},Média: {item.Nota}");
                        }
                        break;
                    case 3:
                        //Ler o Genero
                        Console.WriteLine("Por favor Digite o Genero para a pequisa");
                        Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);
                        //Exibir os alunos por genero
                        listaFiltrada = lista.Where (h => h.Genero == genero).ToList();
                        foreach (var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome:{item.Nome}");
                        }
                        break;
                    case 0:
                        //sair
                        break;
                }


            } while (opcao != 0);





        }//Main

    }//namespace
}
