using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("motoristas")]
    public class MotoristaController: ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Motorista>>> Get(
            [FromServices] DataContext context
        )
        {
            var motoristas = await context.Motoristas.ToListAsync();
            return motoristas;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Motorista>> Post(
            [FromServices] DataContext context,
            [FromBody] Motorista model
        )
        {
            if (ModelState.IsValid){
                context.Motoristas.Add(model);
                await context.SaveChangesAsync();
                return model;
            }else{
                return BadRequest(ModelState);
            }
        }
    }
}