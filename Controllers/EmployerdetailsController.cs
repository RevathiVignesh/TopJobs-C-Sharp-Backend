using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TopJobs.Models;

namespace TopJobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerdetailsController : ControllerBase
    {
        private readonly TopJobsDbContext _context;

        public EmployerdetailsController(TopJobsDbContext context)
        {
            _context = context;
        }

        // GET: api/Employerdetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employerdetails>>> GetEmpdetails()
        {
            return await _context.Empdetails.ToListAsync();
        }

        // GET: api/Employerdetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employerdetails>> GetEmployerdetails(int id)
        {
            var employerdetails = await _context.Empdetails.FindAsync(id);

            if (employerdetails == null)
            {
                return NotFound();
            }

            return employerdetails;
        }
        [HttpGet("email/{email}")]
        public async Task<ActionResult<Employerdetails>> GetEmployeridbyemail(string email)
        {
            var employerdetails = await _context.Empdetails.FirstOrDefaultAsync(e => e.EmployeeEmail == email);

            if (employerdetails == null)
            {
                return NotFound();
            }

            return employerdetails;
        }

        // PUT: api/Employerdetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployerdetails(int id, Employerdetails employerdetails)
        {
            if (id != employerdetails.EmployeeID)
            {
                return BadRequest();
            }

            _context.Entry(employerdetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployerdetailsExists(id))
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

        // POST: api/Employerdetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employerdetails>> PostEmployerdetails(Employerdetails employerdetails)
        {
            _context.Empdetails.Add(employerdetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployerdetails", new { id = employerdetails.EmployeeID }, employerdetails);
        }

        // DELETE: api/Employerdetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployerdetails(int id)
        {
            var employerdetails = await _context.Empdetails.FindAsync(id);
            if (employerdetails == null)
            {
                return NotFound();
            }

            _context.Empdetails.Remove(employerdetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployerdetailsExists(int id)
        {
            return _context.Empdetails.Any(e => e.EmployeeID == id);
        }
    }
}
