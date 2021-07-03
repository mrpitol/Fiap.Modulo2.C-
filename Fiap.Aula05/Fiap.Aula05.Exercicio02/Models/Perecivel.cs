using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exercicio02.Models
{
    class Perecivel:Produto
    {
        //Propriedades
        public DateTime DataValidade { get; set; }

        //Construtores
        public Perecivel(int id, string nome, DateTime datavalidade) : base(id, nome)
        {
            Id = id;
            Nome = nome;
            DataValidade = datavalidade;

        }//Perecivel(int id, string nome, DateTime data)

    }//Class

}//namespace
