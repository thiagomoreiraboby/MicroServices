using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Dominio.Entidade
{
    public class ContaCorrente : EntidadeBase
    {
        public ContaCorrente() { }
        public ContaCorrente(int id, string nome, decimal saldo)
        {
            ID = id;
            Nome = nome;
            Saldo = saldo;
        }
        public void Debito(decimal valor)
        {
            Saldo -= valor;
        }
        public void Credito(decimal valor)
        {
            Saldo += valor;
        }
        public string Nome { get; protected set ; }
        public decimal Saldo { get; protected set; }
    }
}
