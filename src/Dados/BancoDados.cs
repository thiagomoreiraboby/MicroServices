using Framework.Dominio.Entidade;
using System;
using System.Collections.Generic;

namespace Dados
{
    public class BancoDados
    {
        public static List<ContaCorrente> contas = new List<ContaCorrente>()
        {
            new ContaCorrente(1,"Conta Thiago", 100),
            new ContaCorrente(2,"Conta Banco", 1000),
        };
        public static List<Lancamentos> lancamentos = new List<Lancamentos>();

    }
}
