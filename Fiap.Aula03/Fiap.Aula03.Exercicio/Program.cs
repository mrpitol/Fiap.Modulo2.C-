using System;
using Fiap.Aula03.Exercicio.Models;

namespace Fiap.Aula03.Exercicio
{
    class Program
    {
        static void Main(string[] args)

        {
            //Instanciar os objetos e atribuir os valores aos seus atributos
            
            //Cliente cliente = new Cliente();-> Construtor padrão
            ContaCorrente cc = new ContaCorrente(); 
            ContaPoupanca cp = new ContaPoupanca();
            cc.ContaPoupanca = cp;
            
            // Ler os dados do Cliente (nome, cpf e telefone)
            Console.WriteLine("Por favor, digite o nome do Cliente");
            //cliente.Nome = Console.ReadLine();-> Construtor padrão
            string nome = Console.ReadLine();//-> Construtor Cliente

            Console.WriteLine("Por favor, digite o cpf do Cliente");
            //cliente.Cpf = Console.ReadLine();-> Construtor padrão
            string cpf = Console.ReadLine();//-> Construtor Cliente

            Console.WriteLine("Por favor, digite o telefone do Cliente");
            //cliente.Telefone = Console.ReadLine();-> Construtor padrão
            string telefone = Console.ReadLine();//-> Construtor Cliente

            //Instanciando o construtor Cliente - precisa considerar a declaração das variaveis
            Cliente cliente = new Cliente(nome: nome, cpf: cpf, telefone: telefone);


            // Ler o dados da conta poupança (numero)
            Console.WriteLine("Por favor, digite o Numero da Conta poupança");
            cp.Numero = double.Parse(Console.ReadLine());

            // Ler o dados da conta Corrente (numero , especial, juros e limite)
            Console.WriteLine("Por favor, digite o Numero da Conta Corrente");
            cc.Numero = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, a conta corrente é especial?");
            cc.Especial = bool.Parse(Console.ReadLine());

            if (cc.Especial) 
            {
                Console.WriteLine("Por favor, digite o Limite");
                cc.Limite = Convert.ToDecimal(Console.ReadLine());
               
                Console.WriteLine("Por favor, digite os juros");
                cc.Juros = double.Parse(Console.ReadLine());

            }//if

            //Menu
            //Declarar a varivel de opção do Menu
            int opcao;
            do
            {
                Console.WriteLine("\n1 - Depositar\n2 - Retirar \n3 - Transferir \n4 - Sacar da Poupança \n5 - " +
                                    "Calcular o valor da taxa de Juros \n0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Por favor, digite o Valor do Deposito");
                        
                        var valor = decimal.Parse(Console.ReadLine());
                        try
                        { 
                            cc.Depositar(valor);
                            Console.WriteLine($"O Saldo é {cc.Saldo} e o saldo Total é {cc.RetornarSaldoTotal()}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                            break;
                    case 2:

                        Console.WriteLine("Por favor, digite o Valor para Saque");
                        valor = decimal.Parse(Console.ReadLine());
                        try
                        {
                         cc.Retirar(valor);
                         Console.WriteLine($"O Saldo é {cc.Saldo} e o saldo Total é {cc.RetornarSaldoTotal()}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Por favor, digite o Valor para Transfererncia");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.TransferirParaPoupanca(valor);
                        Console.WriteLine($"O Saldo é {cc.Saldo} e o Saldo Total é {cc.RetornarSaldoTotal()} \n Osaldo da poupança é {cc.ContaPoupanca.Saldo}");
                        break;
                    case 4:
                        Console.WriteLine("Por favor, digite o Valor para Sacar da Poupança");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.SacardaPoupanca(valor);
                        if (cc.SacardaPoupanca(valor))
                        {
                            Console.WriteLine($"O Saldo é {cc.Saldo} e o Saldo Total é {cc.RetornarSaldoTotal()} \n O saldo da poupança é {cc.ContaPoupanca.Saldo}"); 
                        }//if
                        else
                        {
                            Console.WriteLine("O saldo da poupança é {cc.ContaPoupanca.Saldo} \nSaldo Insuficiente");
                        }//else
                        break;


                    case 5:
                        Console.WriteLine("Digite a Quantidade de dias");
                        var dias = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O Valor dos Juros será de {cc.CalcularValorTaxaJuros(dias)}%");
                        break;
                    case 0:
                        Console.WriteLine("Finalizado o Sistema");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }


            }//do
            while (opcao!=0);
        }//Main

    }//Class

}//namespace
