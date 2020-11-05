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
    public class InstituitonsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InstituitonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Instituitons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instituiton>>> GetInstituitons()
        {
            return await _context.Instituitons.ToListAsync();
        }

        // GET: api/Instituitons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instituiton>> GetInstituiton(int id)
        {
            var instituiton = await _context.Instituitons.FindAsync(id);

            if (instituiton == null)
            {
                return NotFound();
            }

            return instituiton;
        }

        // PUT: api/Instituitons/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstituiton(int id, Instituiton instituiton)
        {
            if (id != instituiton.Id)
            {
                return BadRequest();
            }

            _context.Entry(instituiton).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstituitonExists(id))
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

        // POST: api/Instituitons
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Instituiton>> PostInstituiton(Instituiton instituiton)
        {
            _context.Instituitons.Add(instituiton);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstituiton", new { id = instituiton.Id }, instituiton);
        }

        // DELETE: api/Instituitons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Instituiton>> DeleteInstituiton(int id)
        {
            var instituiton = await _context.Instituitons.FindAsync(id);
            if (instituiton == null)
            {
                return NotFound();
            }

            _context.Instituitons.Remove(instituiton);
            await _context.SaveChangesAsync();

            return instituiton;
        }

        private bool InstituitonExists(int id)
        {
            return _context.Instituitons.Any(e => e.Id == id);
        }
    }
}
