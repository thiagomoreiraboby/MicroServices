using Framework.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Dominio.Servico
{
    public interface IServicoLancamento
    {
        bool Lancamentos(int contaOrigem, int contaDestino, decimal ValorMovimentacao);
    }
}
