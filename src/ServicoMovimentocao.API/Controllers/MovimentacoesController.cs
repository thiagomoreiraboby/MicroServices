
using Framework.Dominio.Entidade;
using Framework.Dominio.Servico;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ServicoMovimentocao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentacoesController : ControllerBase
    {
        private readonly IServicoMovimentocao _servico;

        public MovimentacoesController(IServicoMovimentocao lancamentosService)
        {
            _servico = lancamentosService;
        }

        [HttpGet]
        public IEnumerable<Lancamentos> Get()
        {
            return _servico.Movimentos();
        }
        [HttpGet("{id}")]
        public decimal Get(int id)
        {
            return _servico.SaldoContaCorrente(id);
        }

       

    }
}
