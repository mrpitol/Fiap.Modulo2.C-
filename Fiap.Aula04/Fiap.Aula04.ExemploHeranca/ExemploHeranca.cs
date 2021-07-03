using System;
using Fiap.Aula04.ExemploHeranca.Models;

namespace Fiap.Aula04.ExemploHeranca
{
    class ExemploHeranca
    {
        static void Main(string[] args)
        {
            
           

            //Atribuir o nome ao aluno 
            string nome = "Jose";//  herdado de pessoa
            
            //aluno.Nome3 = "Jose";// Não tem acesso ao Name3 herdado de pessoa
            int idade = 20;//  herdado de pessoa
            int matricula = 1225478; //propriedade de aluno
            string curso = "Engenharia";//propriedade de aluno

            //instanciar um Aluno
            var aluno = new Aluno(nome, matricula);// Definir o construtor
            
            
            aluno.Nome2 = "Jose";//  herdado de pessoa
            //instanciar Pessoa
            

            string nomePessoa  = "Ricardo";
            var pessoa =new Pessoa(nomePessoa);// Definir o construtor

            // Chamar o método retornar dados e exibir os dados
            Console.WriteLine(aluno.RetornaDados());
            Console.WriteLine(pessoa.RetornaDados());

            //


        }
    }
}
