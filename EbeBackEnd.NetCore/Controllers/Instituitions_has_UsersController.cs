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
    public class Instituitions_has_UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Instituitions_has_UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Instituitions_has_Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instituitions_has_Users>>> GetInstituitions_has_Users()
        {
            return await _context.Instituitions_has_Users.ToListAsync();
        }

        // GET: api/Instituitions_has_Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instituitions_has_Users>> GetInstituitions_has_Users(int id)
        {
            var instituitions_has_Users = await _context.Instituitions_has_Users.FindAsync(id);

            if (instituitions_has_Users == null)
            {
                return NotFound();
            }

            return instituitions_has_Users;
        }

        // PUT: api/Instituitions_has_Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstituitions_has_Users(int id, Instituitions_has_Users instituitions_has_Users)
        {
            if (id != instituitions_has_Users.Id)
            {
                return BadRequest();
            }

            _context.Entry(instituitions_has_Users).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Instituitions_has_UsersExists(id))
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

        // POST: api/Instituitions_has_Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Instituitions_has_Users>> PostInstituitions_has_Users(Instituitions_has_Users instituitions_has_Users)
        {
            _context.Instituitions_has_Users.Add(instituitions_has_Users);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstituitions_has_Users", new { id = instituitions_has_Users.Id }, instituitions_has_Users);
        }

        // DELETE: api/Instituitions_has_Users/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Instituitions_has_Users>> DeleteInstituitions_has_Users(int id)
        {
            var instituitions_has_Users = await _context.Instituitions_has_Users.FindAsync(id);
            if (instituitions_has_Users == null)
            {
                return NotFound();
            }

            _context.Instituitions_has_Users.Remove(instituitions_has_Users);
            await _context.SaveChangesAsync();

            return instituitions_has_Users;
        }

        private bool Instituitions_has_UsersExists(int id)
        {
            return _context.Instituitions_has_Users.Any(e => e.Id == id);
        }
    }
}
