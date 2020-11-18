using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EBE_BackEnd.Data;
using EBE_BackEnd.Models;
using Microsoft.AspNetCore.Authorization;

namespace EbeBackEnd.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubEventsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SubEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubEvents>>> GetSubEvents()
        {
            return await _context.SubEvents.ToListAsync();
        }

        // GET: api/SubEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubEvents>> GetSubEvents(int id)
        {
            var subEvents = await _context.SubEvents.FindAsync(id);

            if (subEvents == null)
            {
                return NotFound();
            }

            return subEvents;
        }

        // PUT: api/SubEvents/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubEvents(int id, SubEvents subEvents)
        {
            if (id != subEvents.Id)
            {
                return BadRequest();
            }

            _context.Entry(subEvents).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubEventsExists(id))
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

        // POST: api/SubEvents
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<SubEvents>> PostSubEvents(SubEvents subEvents)
        {
            _context.SubEvents.Add(subEvents);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubEvents", new { id = subEvents.Id }, subEvents);
        }

        // DELETE: api/SubEvents/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<SubEvents>> DeleteSubEvents(int id)
        {
            var subEvents = await _context.SubEvents.FindAsync(id);
            if (subEvents == null)
            {
                return NotFound();
            }

            _context.SubEvents.Remove(subEvents);
            await _context.SaveChangesAsync();

            return subEvents;
        }

        private bool SubEventsExists(int id)
        {
            return _context.SubEvents.Any(e => e.Id == id);
        }
    }
}
