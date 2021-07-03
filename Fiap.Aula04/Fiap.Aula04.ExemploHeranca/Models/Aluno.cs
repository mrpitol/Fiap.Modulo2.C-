using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.ExemploHeranca.Models
{
    //Aluni herda Pessoa (A Classe Aluno possui atributos e métodos da Classe Pessoa)
    public class Aluno:Pessoa // Definir public para ser adicionar a outro projeto, por padrão é internal
    {
        //Propriedades
        public int Matricula { get; set; }
        public string Curso { get; set; }

       
        //Construtor que invoca o construtor com o nome e idade da pessoa
        public Aluno(string nome, int matricula) : base(nome)
        {
            Matricula = matricula;
        }
        public Aluno(string nome, int idade, int matricula, string curso) : base(nome , idade) 
        {
            Matricula=matricula;
            Curso=curso;
        }
        //Metodos
        public void obterPresenca() 
        {
            Console.WriteLine(  $"{Nome} presente?");

        }//obterPresenca

    }//Class

}//namespace
