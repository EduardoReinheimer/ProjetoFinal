using System.Collections.Generic;
using System.Threading.Tasks;
using BackEnd.Data;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("cargas")]
    public class CargaController: ControllerBase
    {
         [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Carga>>> Get(
            [FromServices] DataContext context
        )
        {
            var cargas = await context.Cargas.ToListAsync();
            return cargas;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Carga>> Post(
            [FromServices] DataContext context,
            [FromBody] Carga model
        )
        {
            if (ModelState.IsValid){
                context.Cargas.Add(model);
                await context.SaveChangesAsync();
                return model;
            }else{
                return BadRequest(ModelState);
            }
        }
    }
}