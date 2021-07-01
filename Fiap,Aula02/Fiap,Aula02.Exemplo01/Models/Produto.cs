

namespace Fiap_Aula02.Exemplo01.Models
{
    public class Produto
    {
        //Atributo publico todos acessam privado apenas a propria classe
        private int _id;

        //Getters e Setters (Propriedades)
        public string Nome { get; set; } //pardrão null

        public decimal Valor { get; set; } // int float qq número padrão é 0

        public Fabricante Fabricante { get; set; } // Classes padrão null
 

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }//Id

        // Metodos
        //Calcular o valor do produto com desconto e retorna o valor calculado
        public decimal CalcularDesconto(decimal porcentagem) 
        { 
            return Valor - (Valor * (porcentagem/100)) ;

        }

        public void Cadastrar() 
        {
            System.Console.WriteLine("Produto Sendo Cadastrado..");
        }

    }//class

}//Namespace
