using Framework.Dominio.Entidade;
using Framework.Dominio.Repositorio;
using Framework.Dominio.Servico;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicoMovimentocao.Aplicacao
{
    public class Servico : IServicoMovimentocao
    {
        private readonly IContaCorrenteRepositorio _contaCorrenteRepositorio;
        private readonly ILancamentosRepositorio _lancamentosRepositorio;

        public Servico(IContaCorrenteRepositorio contaCorrenteRepositorio, ILancamentosRepositorio lancamentosRepositorio)
        {
            _contaCorrenteRepositorio = contaCorrenteRepositorio;
            _lancamentosRepositorio = lancamentosRepositorio;
        }

        public decimal SaldoContaCorrente(int id)
        {
            return _contaCorrenteRepositorio.ListarPorCodigo(id).Saldo;
        }

        IEnumerable<Lancamentos> IServicoMovimentocao.Movimentos()
        {
            return _lancamentosRepositorio.ListarTodos();
        }
    }
}
