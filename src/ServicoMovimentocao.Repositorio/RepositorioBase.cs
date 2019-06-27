using Dados;
using Framework.Dominio.Entidade;
using Framework.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicoMovimentocao.Repositorio
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase
    {
       
        private readonly Type _type;
        public RepositorioBase(Type type)
        {
            _type = type;
            criarDados();
        }

        private void criarDados()
        {
            BancoDados.lancamentos = new List<Lancamentos> { 
                new Lancamentos(1,BancoDados.contas.FirstOrDefault(x=> x.ID == 1), BancoDados.contas.FirstOrDefault(x => x.ID == 2), 10),
                new Lancamentos(2,BancoDados.contas.FirstOrDefault(x=> x.ID == 2), BancoDados.contas.FirstOrDefault(x => x.ID == 1), 9),
                new Lancamentos(3,BancoDados.contas.FirstOrDefault(x=> x.ID == 1), BancoDados.contas.FirstOrDefault(x => x.ID == 2), 20),
                new Lancamentos(4,BancoDados.contas.FirstOrDefault(x=> x.ID == 2), BancoDados.contas.FirstOrDefault(x => x.ID == 1), 30),
                new Lancamentos(5,BancoDados.contas.FirstOrDefault(x=> x.ID == 1), BancoDados.contas.FirstOrDefault(x => x.ID == 2), 40),
                new Lancamentos(6,BancoDados.contas.FirstOrDefault(x=> x.ID == 2), BancoDados.contas.FirstOrDefault(x => x.ID == 1), 20),
                new Lancamentos(7,BancoDados.contas.FirstOrDefault(x=> x.ID == 1), BancoDados.contas.FirstOrDefault(x => x.ID == 2), 10),
                };
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
