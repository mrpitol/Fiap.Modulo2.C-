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

        // Sobrescrever o método definido no pai(override), modificar o comportamento do método na classe filha
        public override decimal CalcularDesconto() // Altera o Metodo do Pai ( Virtual)
        {
            return CalcularDesconto(50);
        }

        //Sobrescrever o método desconto com cupom, adicionando o FIAPBOOK com 30%
        public override decimal CalcularDesconto(string cupom)
        {
            //Exemplo:FIAPBOOK com 30% ou  FIAP10 com 10% de Desconto
            //return cupom == "FIAPBOOK" ? CalcularDesconto(30) : cupom == "FIAP10" ? CalcularDesconto(10) : 0 ;// Altera o Metodo do Pai ( Virtual)
            // Outro Exemplo
            return cupom == "FIAPBOOK" ? CalcularDesconto(30) : base.CalcularDesconto(30) ; 
        }//Metodo3


    }//Class

}//namespace
