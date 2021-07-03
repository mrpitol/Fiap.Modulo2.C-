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

        //Metodos
        

        //Sobrecarga de Metodo: método com mesmo nome e parâmetros diferentes

        public decimal CalcularDesconto() 
        {
            //Exemplo desconto padrão 5%
            //return Preco - Preco *0,05m
            return CalcularDesconto(5)

;       }//Metodo1

        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Preco - ((Preco * porcentagem) / 100);

        }//Metodo2

        public decimal CalcularDesconto(string cupom)
        {
            //Exemplo: FIAP10 dá 10% de Desconto
            return cupom == "FIAP10" ? CalcularDesconto(10) : 0;
            
        }//Metodo3

    }//Class

}//namespace
