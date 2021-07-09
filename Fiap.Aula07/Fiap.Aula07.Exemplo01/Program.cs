using Fiap.Aula07.Exemplo01.Exceptions;
using Fiap.Aula07.Exemplo01.Services;
using System;

namespace Fiap.Aula07.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //tratamento de exception
            try
            {
                //Ler um Número
                Console.WriteLine("Digite um Número");
                var numero = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Número Inválido");
            }
            finally
            {
                Console.WriteLine("Número Aceito");
            }
            string msg="";
            try
            {
                //Ler uma Mensagem
                Console.WriteLine("Digite uma Mensagem");
                msg = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Mensagem Invalida");
            }
            finally//Sempre executa , não é obrigatorio (fechar uma comunicação)
            {
                Console.WriteLine("Enviando Mensagem");
            }
            //interface -> diminuir o acomplamento (dependencia) entre os objetos
            //instanciar um EmailMessage
            IMessage message = new SmsMessage();
            try
            {
                //chamar o método de enviar mensagem
                message.EnviarMensagem(msg);
            }
            catch (MensagemInvalidaException e)
            {
                Console.WriteLine($"Erro:"+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
