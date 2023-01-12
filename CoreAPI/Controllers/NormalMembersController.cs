using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreAPI.Models;

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NormalMembersController : ControllerBase
    {
        private readonly ispanMsit145shibaContext _context;

        public NormalMembersController(ispanMsit145shibaContext context)
        {
            _context = context;
        }

        // GET: api/NormalMembers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NormalMember>>> GetNormalMember()
        {
            return await _context.NormalMembers.ToListAsync();
        }

        // GET: api/NormalMembers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NormalMember>> GetNormalMember(int id)
        {
            var normalMember = await _context.NormalMembers.FindAsync(id);

            if (normalMember == null)
            {
                return NotFound();
            }

            return normalMember;
        }

        // PUT: api/NormalMembers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNormalMember(int id, NormalMember normalMember)
        {
            if (id != normalMember.Fid)
            {
                return BadRequest();
            }

            _context.Entry(normalMember).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NormalMemberExists(id))
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

        // POST: api/NormalMembers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NormalMember>> PostNormalMember(NormalMember normalMember)
        {
            _context.NormalMembers.Add(normalMember);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNormalMember", new { id = normalMember.Fid }, normalMember);
        }

        // DELETE: api/NormalMembers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNormalMember(int id)
        {
            var normalMember = await _context.NormalMembers.FindAsync(id);
            if (normalMember == null)
            {
                return NotFound();
            }

            _context.NormalMembers.Remove(normalMember);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NormalMemberExists(int id)
        {
            return _context.NormalMembers.Any(e => e.Fid == id);
        }
    }
}
