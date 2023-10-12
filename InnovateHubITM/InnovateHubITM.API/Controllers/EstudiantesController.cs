using InnovateHubITM.API.Data;
using InnovateHubITM.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InnovateHubITM.API.Controllers
{

    [ApiController]
    [Route("api/Estudiantes")]
    public class EstudiantesController : ControllerBase
    {
        private readonly DataContext _context;

        public EstudiantesController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Estudiantes.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(x => x.Id == id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return Ok(estudiante);
        }



        [HttpPost]// post -Create
        public async Task<ActionResult> Post(Estudiante estudiante) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(estudiante);
            await _context.SaveChangesAsync();
            return Ok(estudiante);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Estudiante estudiante)
        {

            _context.Update(estudiante);
            await _context.SaveChangesAsync();
            return Ok(estudiante);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Estudiantes
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

