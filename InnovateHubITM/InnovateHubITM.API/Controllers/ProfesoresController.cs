using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InnovateHubITM.API.Data;
using InnovateHubITM.Shared.Entities;

namespace ProyectoInvestigacion.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesoresController : Controller
    {
        private readonly DataContext _context;

        public ProfesoresController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Profesores.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var country = await _context.Profesores.FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Profesor profesor) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(profesor);
            await _context.SaveChangesAsync();
            return Ok(profesor);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Profesor profesor)
        {

            _context.Update(profesor);
            await _context.SaveChangesAsync();
            return Ok(profesor);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Profesores
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
