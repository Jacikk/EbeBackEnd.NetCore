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
    public class SubEvents_has_UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SubEvents_has_UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SubEvents_has_Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubEvents_has_Users>>> GetSubEvents_has_Users()
        {
            return await _context.SubEvents_has_Users.ToListAsync();
        }

        // GET: api/SubEvents_has_Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubEvents_has_Users>> GetSubEvents_has_Users(int id)
        {
            var subEvents_has_Users = await _context.SubEvents_has_Users.FindAsync(id);

            if (subEvents_has_Users == null)
            {
                return NotFound();
            }

            return subEvents_has_Users;
        }

        // PUT: api/SubEvents_has_Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubEvents_has_Users(int id, SubEvents_has_Users subEvents_has_Users)
        {
            if (id != subEvents_has_Users.Id)
            {
                return BadRequest();
            }

            _context.Entry(subEvents_has_Users).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubEvents_has_UsersExists(id))
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

        // POST: api/SubEvents_has_Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<SubEvents_has_Users>> PostSubEvents_has_Users(SubEvents_has_Users subEvents_has_Users)
        {
            _context.SubEvents_has_Users.Add(subEvents_has_Users);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubEvents_has_Users", new { id = subEvents_has_Users.Id }, subEvents_has_Users);
        }

        // DELETE: api/SubEvents_has_Users/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<SubEvents_has_Users>> DeleteSubEvents_has_Users(int id)
        {
            var subEvents_has_Users = await _context.SubEvents_has_Users.FindAsync(id);
            if (subEvents_has_Users == null)
            {
                return NotFound();
            }

            _context.SubEvents_has_Users.Remove(subEvents_has_Users);
            await _context.SaveChangesAsync();

            return subEvents_has_Users;
        }

        private bool SubEvents_has_UsersExists(int id)
        {
            return _context.SubEvents_has_Users.Any(e => e.Id == id);
        }
    }
}
