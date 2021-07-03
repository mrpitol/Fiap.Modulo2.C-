using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Exemplo01.Models
{
    class Carro:Veiculo
    {
        //Propriedades
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public bool ArCondicionado { get; set; }
    }
}
