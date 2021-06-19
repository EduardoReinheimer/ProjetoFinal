using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("caminhoes")]
    public class CaminhaoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Caminhao>>> Get(
            [FromServices] DataContext context
        )
        {
            var caminhoes = await context.Caminhoes.ToListAsync();
            return caminhoes;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Caminhao>> Post(
            [FromServices] DataContext context,
            [FromBody] Caminhao model
        )
        {
            if (ModelState.IsValid){
                context.Caminhoes.Add(model);
                await context.SaveChangesAsync();
                return model;
            }else{
                return BadRequest(ModelState);
            }
        }

    }
}