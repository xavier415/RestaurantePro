using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using RestaurantePro.Pedido.Application.Contracts;
using RestaurantePro.Pedido.Application.Extentions;
using RestaurantePro.Pedido.Application.PedidosDto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantePro.Pedido.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService pedidoService;
        public PedidoController(IPedidoService pedidoService)
        {
                this.pedidoService = pedidoService;
        }

        
        [HttpGet("GetPedido")]
        public IActionResult Get()
        {
            var result = this.pedidoService.GetPedidos();

            if (result.Success)

                return BadRequest(result);
            else
                return Ok(result);

            
        }

      
        [HttpGet("GetPedidoById")]
        public IActionResult Get(int id)
        {
            var result = this.pedidoService.GetPedidoById(id);

            if (result.Success)

                return BadRequest(result);
            else
                return Ok(result);
        }

        
        [HttpPost("SavePedido")]
        public IActionResult Post([FromBody] PedidoDtoSave dtoSave)
        {
            var result = this.pedidoService.SavePedido(dtoSave);

            if (!result.Success)

                return BadRequest(result);
            else
                return Ok(result);
        }

  
        [HttpPost("UpdatePedido")]
        public IActionResult Put(PedidoDtoUpdate dtoUpdate)
        {
            var result = this.pedidoService.UpdatePedido(dtoUpdate);

            if (!result.Success)

                return BadRequest(result);
            else
                return Ok(result);
        }

        
        [HttpPost("DeletePedido")]
        public IActionResult Delete(PedidoDtoRemove dtoRemove)
        {
            var result = this.pedidoService.RemovePedido(dtoRemove);

            if (!result.Success)

                return BadRequest(result);
            else
                return Ok(result);
            

        }
        
    }

}
