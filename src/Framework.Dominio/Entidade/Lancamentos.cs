using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Dominio.Entidade
{
    public class Lancamentos : EntidadeBase
    {
        public Lancamentos() { }
        public Lancamentos(int id, ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valorLancamento)
        {
            ID = id;
            ContaOrigem = contaOrigem;
            ContaDestino = contaDestino;
            ValorLancamento = valorLancamento;
            SaldoAnteriorOrigem = contaOrigem.Saldo;
            SaldoAnteriorDestino = contaDestino.Saldo;
            Data = DateTime.Now;
        }
        public ContaCorrente ContaOrigem { get; protected set; }
        public ContaCorrente ContaDestino { get; protected set; }
        public decimal ValorLancamento { get; protected set; }
        public DateTime Data { get; set; }
        public decimal SaldoAnteriorOrigem { get; protected set; }
        public decimal SaldoAnteriorDestino { get; protected set; }
    }
}
