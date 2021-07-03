using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exemplo01.Models
{
    class Carro
    {
        //Propriedades
        public string Modelo{ get; set; }
        public int Ano  { get; set; }

        //Construtores -> Sem Retorno e mesmo nome da classe
        public Carro(string modelo) 
        {
            Modelo = modelo;
        }//Carro(modelo)

        // não é permitir declarar o construtor com o mesmo tipo
        /*public Carro(string modelo)
        {
            Modelo = modelo;
        }*/
        //Mas se declarar tipos diferentes não tem problema

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }//Carro(modelo,ano)


    }//Class

}//namespace
