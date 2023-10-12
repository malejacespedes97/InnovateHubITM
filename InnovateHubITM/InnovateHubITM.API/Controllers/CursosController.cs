using InnovateHubITM.API.Data;
using InnovateHubITM.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InnovateHubITM.API.Controllers
{
    [ApiController]
    [Route("api/Cursos")]
    public class CursosController : ControllerBase
    {
        private readonly DataContext _context;

        public CursosController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Cursos.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var curso = await _context.Cursos.FirstOrDefaultAsync(x => x.Id == id);
            if (curso == null)
            {
                return NotFound();
            }
            return Ok(curso);
        }



        [HttpPost]// post -Create
        public async Task<ActionResult> Post(Curso curso) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(curso);
            await _context.SaveChangesAsync();
            return Ok(curso);
        }

        // Put-- update
        [HttpPut]
        public async Task<ActionResult> Put(Curso curso)
        {

            _context.Update(curso);
            await _context.SaveChangesAsync();
            return Ok(curso);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Cursos
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

