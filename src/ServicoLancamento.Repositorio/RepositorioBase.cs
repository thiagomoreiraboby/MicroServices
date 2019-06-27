using Dados;
using Framework.Dominio.Entidade;
using Framework.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicoLancamento.Repositorio
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase
    {
       
        private readonly Type _type;
        public RepositorioBase(Type type)
        {
            _type = type;
        }

        public void Adicionar(T obj)
        {  
            AcertarBanco().Add(obj);
        }

        public void Atualizar(T obj)
        {
            var itemantigo = ListarPorCodigo((int)obj.ID);
            AcertarBanco().Remove(itemantigo);
            AcertarBanco().Add(obj);
        }

        public void Deletar(T obj)
        {
            AcertarBanco().Remove(obj);
        }

        public T ListarPorCodigo(int id)
        {
            return AcertarBanco().FirstOrDefault(x=> x.ID == id);
        }

        public IEnumerable<T> ListarTodos()
        {
            return AcertarBanco();
        }

        private List<T> AcertarBanco()
        {
            return (_type == typeof(ContaCorrente)) ? BancoDados.contas as List<T> : BancoDados.lancamentos as List<T>;
        }
    }
}
