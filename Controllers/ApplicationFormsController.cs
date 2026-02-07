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
    public class ApplicationFormsController : ControllerBase
    {
        private readonly TopJobsDbContext _context;

        public ApplicationFormsController(TopJobsDbContext context)
        {
            _context = context;
        }

        // GET: api/ApplicationForms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationForm>>> GetApplicationForms()
        {
            return await _context.ApplicationForms.ToListAsync();
        }

        // GET: api/ApplicationForms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationForm>> GetApplicationForm(int id)
        {
            var applicationForm = await _context.ApplicationForms.FindAsync(id);

            if (applicationForm == null)
            {
                return NotFound();
            }

            return applicationForm;
        }

        // PUT: api/ApplicationForms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationForm(int id, ApplicationForm applicationForm)
        {
            if (id != applicationForm.applicationId)
            {
                return BadRequest();
            }

            _context.Entry(applicationForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationFormExists(id))
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

        // POST: api/ApplicationForms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApplicationForm>> PostApplicationForm(ApplicationForm applicationForm)
        {
            _context.ApplicationForms.Add(applicationForm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplicationForm", new { id = applicationForm.applicationId }, applicationForm);
        }

        // DELETE: api/ApplicationForms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationForm(int id)
        {
            var applicationForm = await _context.ApplicationForms.FindAsync(id);
            if (applicationForm == null)
            {
                return NotFound();
            }

            _context.ApplicationForms.Remove(applicationForm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApplicationFormExists(int id)
        {
            return _context.ApplicationForms.Any(e => e.applicationId == id);
        }
    }
}
