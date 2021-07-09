using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Exercicio.Models
{
    interface IContaInvestimento
    {
        decimal CalcularContaInvestimento(decimal taxa);
    }
}
