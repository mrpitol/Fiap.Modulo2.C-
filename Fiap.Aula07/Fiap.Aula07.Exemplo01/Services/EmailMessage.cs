using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula07.Exemplo01.Services
{
    class EmailMessage : IMessage
    {
       

        public void EnviarMensagem (string mensagem) 
        {
            Console.WriteLine($"Enviando e-mail{mensagem}");
        }
        
    }
}
