
using Framework.Dominio.Entidade;
using Framework.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicoLancamento.Repositorio
{
    public class LancamentosRepositorio : RepositorioBase<Lancamentos>, ILancamentosRepositorio
    {
        public LancamentosRepositorio():base(typeof(Lancamentos))
        {

        }
    }
}
