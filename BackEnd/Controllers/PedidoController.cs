using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("pedidos")]
    public class PedidoController: ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Pedido>>> Get(
            [FromServices] DataContext context
        )
        {
            var pedidos = await context.Pedidos.ToListAsync();
            return pedidos;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Pedido>> Post(
            [FromServices] DataContext context,
            [FromBody] Pedido model
        )
        {
            if (ModelState.IsValid){
                context.Pedidos.Add(model);
                await context.SaveChangesAsync();
                return model;
            }else{
                return BadRequest(ModelState);
            }
        }

    }
}