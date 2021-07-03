using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.ExemploHeranca.Models
{
    public class Pessoa // Definir public para ser adicionar a outro projeto, por padrão é internal
    {
    
        //Propriedades
        //protected internal -> classes filhas e do mesmo projeto
        protected internal string Nome2 { get; set; } // Não pode ser visto em outro projeto
        protected private string Nome3 { get; set; } // Não pode ser visto em outro projeto
        public string Nome { get; set; } // Pode ser compartilhado em outro projeto
        public int Idade { get; set; }
        
        //Construtor de Pessoa
        public Pessoa (string nome)
        {
            Nome = nome;   
        }
        public Pessoa(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }

        //Método
        public string RetornaDados()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
                
        }
    }
}
