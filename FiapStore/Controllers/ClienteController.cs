/*using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FiapStoreApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(ICliente clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet("pedido-seis-meses/{id:int}")]
        public IActionResult ClienteEPedidosSeisMeses([FromRoute] int id)
        {
            try
            {
                return Ok(_clienteRepository.ObterPedidosSeisMeses(id));
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
*/