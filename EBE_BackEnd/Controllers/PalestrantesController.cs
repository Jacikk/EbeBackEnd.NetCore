using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EBE_BackEnd.Data;
using EBE_BackEnd.Models;

namespace EBE_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalestrantesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PalestrantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Palestrantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Palestrantes>>> GetPalestrantes()
        {
            return await _context.Palestrantes.ToListAsync();
        }

        // GET: api/Palestrantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Palestrantes>> GetPalestrantes(int id)
        {
            var palestrantes = await _context.Palestrantes.FindAsync(id);

            if (palestrantes == null)
            {
                return NotFound();
            }

            return palestrantes;
        }

        // PUT: api/Palestrantes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPalestrantes(int id, Palestrantes palestrantes)
        {
            if (id != palestrantes.Id)
            {
                return BadRequest();
            }

            _context.Entry(palestrantes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PalestrantesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Palestrantes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Palestrantes>> PostPalestrantes(Palestrantes palestrantes)
        {
            _context.Palestrantes.Add(palestrantes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPalestrantes", new { id = palestrantes.Id }, palestrantes);
        }

        // DELETE: api/Palestrantes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Palestrantes>> DeletePalestrantes(int id)
        {
            var palestrantes = await _context.Palestrantes.FindAsync(id);
            if (palestrantes == null)
            {
                return NotFound();
            }

            _context.Palestrantes.Remove(palestrantes);
            await _context.SaveChangesAsync();

            return palestrantes;
        }

        private bool PalestrantesExists(int id)
        {
            return _context.Palestrantes.Any(e => e.Id == id);
        }
    }
}
