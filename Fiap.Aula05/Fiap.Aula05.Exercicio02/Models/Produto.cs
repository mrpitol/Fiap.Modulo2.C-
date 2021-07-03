using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exercicio02.Models
{
    class Produto:Identidade
    {
        //Propriedades
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }

        // Contrutores
        public Produto(int id, string nome) 
        {
            Nome = nome;
            Id= id;
        }//Produto(int id, string nome) 
        public Produto(int id, string nome,decimal preco)
        {
            Nome = nome;
            Id = id;
            Preco =preco;
        }//Produto(int id, string nome,decimal preco)

        //Metodo
        public decimal CalcularDesconto(decimal porcentagem) 
        {
            return Preco - ((Preco * porcentagem)/100);
            

        }//Metodo

    }//Class

}//namespace
