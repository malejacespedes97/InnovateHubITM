﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InnovateHubITM.API.Data;
using InnovateHubITM.Shared.Entities;

namespace ProyectoInvestigacion.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModulosController : Controller
    {
        private readonly DataContext _context;

        public ModulosController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]//get por lista
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Modulos.ToListAsync());
        }

        [HttpGet("{id}")]//get por parametro
        public async Task<ActionResult> Get(int id)
        {
            var country = await _context.Modulos.FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Modulo modulo) //siempre los post son iguales, solo cambia el nombre de la entidad
        {

            _context.Add(modulo);
            await _context.SaveChangesAsync();
            return Ok(modulo);
        }
    }
}
