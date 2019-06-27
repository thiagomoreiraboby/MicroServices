using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoLancamento.API.Model
{
    public class Movimento
    {
        public int ContaOrigem { get; set; }
        public int ContaDestino { get; set; }
        public decimal Valor { get; set; }
    }
}
