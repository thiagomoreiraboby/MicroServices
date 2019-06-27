
using Framework.Dominio.Entidade;
using Framework.Dominio.Repositorio;
using Framework.Dominio.Servico;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicoLancamento.Aplicacao
{
    public class Servico : IServicoLancamento
    {
        private readonly IContaCorrenteRepositorio _contaCorrenteRepositorio;
        private readonly ILancamentosRepositorio _lancamentosRepositorio;

        public Servico(IContaCorrenteRepositorio contaCorrenteRepositorio, ILancamentosRepositorio lancamentosRepositorio)
        {
            _contaCorrenteRepositorio = contaCorrenteRepositorio;
            _lancamentosRepositorio = lancamentosRepositorio;
        }

      

        public bool Lancamentos(int contaOrigem, int contaDestino, decimal ValorMovimentacao)
        {
            try
            {
                var origem = _contaCorrenteRepositorio.ListarPorCodigo(contaOrigem);
                var destino = _contaCorrenteRepositorio.ListarPorCodigo(contaDestino);
                if (origem == null || destino == null || ValorMovimentacao <= 0)
                    return false;
                var id = 1;
                if (_lancamentosRepositorio.ListarTodos().Any())
                    id += (int)_lancamentosRepositorio.ListarTodos().Max(x => x.ID);
                _lancamentosRepositorio.Adicionar(new Lancamentos(id, origem, destino, ValorMovimentacao));

                origem.Debito(ValorMovimentacao);
                _contaCorrenteRepositorio.Atualizar(origem);
                destino.Credito(ValorMovimentacao);
                _contaCorrenteRepositorio.Atualizar(destino);



                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
