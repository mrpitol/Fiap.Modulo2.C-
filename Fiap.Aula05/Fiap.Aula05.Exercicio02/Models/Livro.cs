using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exercicio02.Models
{
    class Livro:Produto
    {
        //Propriedades
        public string Autor { get; set; }
        public int  NumerodePaginas { get; set; }
        public int AnoPublicacao { get; set; }

        //Construtores
        public Livro(int id, string nome, string autor): base(id, nome)
        {
            Id = id;
            Nome = nome;
            Autor = autor;
        }//Livro(int id, string nome, string autor)
         
    }//Class

}//namespace
