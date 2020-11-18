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
    public class Users_has_EventsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Users_has_EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Users_has_Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users_has_Events>>> GetUsers_has_Events()
        {
            return await _context.Users_has_Events.ToListAsync();
        }

        // GET: api/Users_has_Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users_has_Events>> GetUsers_has_Events(int id)
        {
            var users_has_Events = await _context.Users_has_Events.FindAsync(id);

            if (users_has_Events == null)
            {
                return NotFound();
            }

            return users_has_Events;
        }

        // PUT: api/Users_has_Events/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers_has_Events(int id, Users_has_Events users_has_Events)
        {
            if (id != users_has_Events.Id)
            {
                return BadRequest();
            }

            _context.Entry(users_has_Events).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Users_has_EventsExists(id))
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

        // POST: api/Users_has_Events
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Users_has_Events>> PostUsers_has_Events(Users_has_Events users_has_Events)
        {
            _context.Users_has_Events.Add(users_has_Events);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers_has_Events", new { id = users_has_Events.Id }, users_has_Events);
        }

        // DELETE: api/Users_has_Events/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Users_has_Events>> DeleteUsers_has_Events(int id)
        {
            var users_has_Events = await _context.Users_has_Events.FindAsync(id);
            if (users_has_Events == null)
            {
                return NotFound();
            }

            _context.Users_has_Events.Remove(users_has_Events);
            await _context.SaveChangesAsync();

            return users_has_Events;
        }

        private bool Users_has_EventsExists(int id)
        {
            return _context.Users_has_Events.Any(e => e.Id == id);
        }
    }
}
