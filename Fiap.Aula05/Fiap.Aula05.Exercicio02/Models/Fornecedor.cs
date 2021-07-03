using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exercicio02.Models
{
    class Fornecedor :Identidade
    {
        //Propriedades Herdades de Identidade

        //Construtores

        public Fornecedor(int id, string nome, string telefone) 
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }//Fornecedor(int id, string nome, string telefone) 


    }//Class

}//namespace
