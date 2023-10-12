using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InnovateHubITM.API.Data;
using InnovateHubITM.Shared.Entities;

namespace InnovateHubITM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComentariosController : Controller
    {
        private readonly DataContext _context;

        public ComentariosController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Comentarios.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var country = await _context.Comentarios.FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Comentario comentario) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(comentario);
            await _context.SaveChangesAsync();
            return Ok(comentario);
        }
    }
}

