using Fiap.Aula04.ExemploHeranca.Models;
using System;


namespace Fiap.Aula04.ExemploHeranca2
{
    class ExemploHeranca2
    {
        static void Main(string[] args)
        {
            // Para referenciar add-> project reference -> ExemploHeranca
            //Instanciar aluno
            //var aluno = new Aluno();// Definir o construtor
            var aluno = new Aluno(nome:"Alencar",123456);// Construtor-> Aluno(nome, matricula)
            var aluno2 = new Aluno(nome: "Alencar",20, 123456, "Engenharia");// Construtor-> Aluno(nome, idade, matricula, curso )
            // aluno.Nome2 = "Jose"; // A propriedade Nome2 esta como protected internal  - não pode ser vista em outro projeto

            //aluno.Nome = "Jose";// A propriedade Nome esta como como public - Pode ser vista em outro projeto
            //aluno.Nome2 = "Jose";// A propriedade Nome2 esta como protected internal  - não pode ser vista em outro projeto
           // aluno.Nome3 = "Jose";// A propriedade Nome3 esta como protected private  - não pode ser vista em outro projeto
            //aluno.Idade = 22; // A propriedade Idade esta como como public - Pode ser vista em outro projeto
        }//Main

    }//Class

}//namespace
