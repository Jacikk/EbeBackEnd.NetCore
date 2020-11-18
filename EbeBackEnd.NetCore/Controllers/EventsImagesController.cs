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
    public class EventsImagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventsImagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EventsImages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventsImages>>> GetEventsImages()
        {
            return await _context.EventsImages.ToListAsync();
        }

        // GET: api/EventsImages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventsImages>> GetEventsImages(int id)
        {
            var eventsImages = await _context.EventsImages.FindAsync(id);

            if (eventsImages == null)
            {
                return NotFound();
            }

            return eventsImages;
        }

        // PUT: api/EventsImages/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventsImages(int id, EventsImages eventsImages)
        {
            if (id != eventsImages.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventsImages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventsImagesExists(id))
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

        // POST: api/EventsImages
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<EventsImages>> PostEventsImages(EventsImages eventsImages)
        {
            _context.EventsImages.Add(eventsImages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventsImages", new { id = eventsImages.Id }, eventsImages);
        }

        // DELETE: api/EventsImages/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<EventsImages>> DeleteEventsImages(int id)
        {
            var eventsImages = await _context.EventsImages.FindAsync(id);
            if (eventsImages == null)
            {
                return NotFound();
            }

            _context.EventsImages.Remove(eventsImages);
            await _context.SaveChangesAsync();

            return eventsImages;
        }

        private bool EventsImagesExists(int id)
        {
            return _context.EventsImages.Any(e => e.Id == id);
        }
    }
}
