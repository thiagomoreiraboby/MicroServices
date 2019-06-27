using Framework.Dominio.Entidade;
using Framework.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicoMovimentocao.Repositorio
{
    public class ContaCorrenteRepositorio : RepositorioBase<ContaCorrente>, IContaCorrenteRepositorio
    {
        public ContaCorrenteRepositorio() : base(typeof(ContaCorrente))
        {

        }
    
    }
}
