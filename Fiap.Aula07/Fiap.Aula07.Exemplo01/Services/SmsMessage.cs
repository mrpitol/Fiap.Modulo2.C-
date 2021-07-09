using Fiap.Aula07.Exemplo01.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula07.Exemplo01.Services
{
    class SmsMessage:IMessage
    {
        public void EnviarMensagem(string mensagem)
        {
            //Validar se a mensagem tem menos de 10 caracteres e lançar MensagemInvalidaException
            if (mensagem.Length < 10)
            {
                throw new MensagemInvalidaException("Mensagem com menos de 10 caracteres");
            }
            Console.WriteLine($"Enviando sms{mensagem}");
        }

    }
}
