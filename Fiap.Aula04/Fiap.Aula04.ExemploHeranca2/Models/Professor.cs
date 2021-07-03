using Fiap.Aula04.ExemploHeranca.Models; // Pessoa esta em outro namespace, declarar com using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.ExemploHeranca2.Models
{
    class Professor : Pessoa // Pessoa esta em outro namespace, declarar com using
    {
        //Propriedades
        public string MateriaLecionada { get; set; }

        //Construtor que invoca o construtor com o nome e materialecionada
        public Professor(string nome, string materialecionada) : base(nome)
        {
            MateriaLecionada = materialecionada;
        }

        //Método
        public void FazerChamada() 
        {
            Console.WriteLine($"{Nome} esta fazendo a chamada");
            // Console.WriteLine($"{Nome3} esta fazendo a chamada");// Não enxerga Name3 devido ao nivel de proteção da variavel

        }//FazerChamada

    }//Class

}//namespace
