using Framework.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Dominio.Servico
{
    public interface IServicoMovimentocao
    {
        IEnumerable<Lancamentos> Movimentos();

        decimal SaldoContaCorrente(int id);
    }
}
