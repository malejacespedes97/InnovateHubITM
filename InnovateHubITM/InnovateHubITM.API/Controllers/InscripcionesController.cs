using InnovateHubITM.API.Data;
using InnovateHubITM.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace InnovateHubITM.API.Controllers
{

    [ApiController]
    [Route("api/Inscripciones")]
    public class InscripcionesController : ControllerBase
    {
        private readonly DataContext _context;

        public InscripcionesController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Inscripciones.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var inscripcion = await _context.Inscripciones.FirstOrDefaultAsync(x => x.Id == id);
            if (inscripcion == null)
            {
                return NotFound();
            }
            return Ok(inscripcion);
        }



        [HttpPost]// post -Create
        public async Task<ActionResult> Post(Inscripcion inscripcion) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(inscripcion);
            await _context.SaveChangesAsync();
            return Ok(inscripcion);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Inscripcion inscripcion)
        {

            _context.Update(inscripcion);
            await _context.SaveChangesAsync();
            return Ok(inscripcion);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Inscripciones
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

