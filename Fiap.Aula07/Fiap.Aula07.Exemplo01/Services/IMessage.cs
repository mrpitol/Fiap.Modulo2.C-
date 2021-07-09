using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula07.Exemplo01.Services
{
    //Define o contrato, os métodos que a classe deve implementar
    interface IMessage
    {
        public void EnviarMensagem(string mensagem)
        {
            if (mensagem.Length < 5)
            {
                //Lança uma exception
                throw new Exception("Número de caracteres inválidos");
            }

            Console.WriteLine($"Enviando Mensagem: { mensagem}");
        }
        

    }
}
