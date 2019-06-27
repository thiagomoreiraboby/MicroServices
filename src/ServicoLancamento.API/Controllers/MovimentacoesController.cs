using Framework.Dominio.Entidade;
using Framework.Dominio.Servico;
using Microsoft.AspNetCore.Mvc;
using ServicoLancamento.API.Model;
using System.Collections.Generic;

namespace ServicoLancamento.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LancamentosController : ControllerBase
    {
        private readonly IServicoLancamento _lancamentosService;

        public LancamentosController(IServicoLancamento lancamentosService)
        {
            _lancamentosService = lancamentosService;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Movimento movimento)
        {
            var resultado = _lancamentosService.Lancamentos(movimento.ContaOrigem, movimento.ContaDestino, movimento.Valor);
            if (resultado)
               return Ok();
            else
               return BadRequest();
        }

    }
}
