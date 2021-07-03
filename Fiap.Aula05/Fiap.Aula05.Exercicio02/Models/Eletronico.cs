using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exercicio02.Models
{
    class Eletronico:Produto
    {
        //Propriedades
        public bool Garantia  { get; set; }

        //Construtores
        public Eletronico(int id, string nome) : base(id, nome)
        {
            Id = id;
            Nome = nome;

        }//Eletronico(int id, string nome)

        //Metodo
        public decimal CalcularGarantiaEstendida() 
        {
           
            return Garantia ? Preco - (Preco * 0.1m) : 0; // o m no final converte como monetário

        }//Metodo1

        public decimal CalcularGarantiaEstendida(string cupom,decimal porcentagem)
        {

            return cupom == "FIAP20" && Garantia ?  Preco - (Preco *(porcentagem* 0.01m)) : 0; // o m no final converte como monetário

        }//Metodo2
         
    }//Class

}//namespace
