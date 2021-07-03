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
           
            return !Garantia ? 0: Preco - (Preco * 0.1m); // o m no final converte como monetário

        }//Metodo

    }//Class

}//namespace
