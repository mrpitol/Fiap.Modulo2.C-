using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula07.Exemplo01.Exceptions
{
    //execption - Digitar execptio tab tab e o programa ja estrutura a exception

    [Serializable]
    public class MensagemInvalidaException : Exception
    {
        public MensagemInvalidaException() { }
        public MensagemInvalidaException(string message) : base(message) { }
        public MensagemInvalidaException(string message, Exception inner) : base(message, inner) { }
        protected MensagemInvalidaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
