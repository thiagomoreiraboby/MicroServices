using Framework.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Dominio.Repositorio
{
    public interface IRepositorioBase<T> where T : EntidadeBase
    {
        void Adicionar(T obj);
        void Atualizar(T obj);
        void Deletar(T obj);
        IEnumerable<T> ListarTodos();
        T ListarPorCodigo(int id);
    }
}
