using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap_Aula02.Exemplo01.Models
{
    public class Fabricante // para ser acessivel por outro projeto colocar como publico
    {
        //Propriedade (Getters e Setters)
        // prop -> tab tab
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int Cnpj { get; set; }

        // propfull -> tab tab - Exemplo
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }//MyProperty


    }//class
}//Namespace
