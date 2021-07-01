using Fiap.Aula01.Exemplo02.Models;
using System;

namespace Fiap.Aula01.Exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um médico (criar um objeto de uma Classe)
            Models.Medico cardiologista =  new Models.Medico();
            // ao colocar o Models no namespace, altera a localização da classe
            
            // A Classe cliente esta no namspace padrão assim não precisa acrescentar
           Cliente cliente = new Cliente();

            // ou using Fiap.Aula01.Exemplo02.Models; 
            Teste teste = new Teste();  

            
        }//Main
    }// class
}//namespace
