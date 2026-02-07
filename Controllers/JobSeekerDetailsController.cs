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
    public class JobSeekerDetailsController : ControllerBase
    {
        private readonly TopJobsDbContext _context;

        public JobSeekerDetailsController(TopJobsDbContext context)
        {
            _context = context;
        }

        // GET: api/JobSeekerDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobSeekerDetails>>> GetJsdetails()
        {
            return await _context.Jsdetails.ToListAsync();
        }

        // GET: api/JobSeekerDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobSeekerDetails>> GetJobSeekerDetails(int id)
        {
            var jobSeekerDetails = await _context.Jsdetails.FindAsync(id);

            if (jobSeekerDetails == null)
            {
                return NotFound();
            }

            return jobSeekerDetails;
        }
        [HttpGet("email/{email}")]
        public async Task<ActionResult<JobSeekerDetails>> GetJobseekerbyemail(string email)
        {
            var jsdetails = await _context.Jsdetails.FirstOrDefaultAsync(e => e.JsEmail == email);

            if (jsdetails == null)
            {
                return NotFound();
            }

            return jsdetails;
        }
        // PUT: api/JobSeekerDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobSeekerDetails(int id, JobSeekerDetails jobSeekerDetails)
        {
            if (id != jobSeekerDetails.JsId)
            {
                return BadRequest();
            }

            _context.Entry(jobSeekerDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobSeekerDetailsExists(id))
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

        // POST: api/JobSeekerDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobSeekerDetails>> PostJobSeekerDetails(JobSeekerDetails jobSeekerDetails)
        {
            _context.Jsdetails.Add(jobSeekerDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobSeekerDetails", new { id = jobSeekerDetails.JsId }, jobSeekerDetails);
        }

        // DELETE: api/JobSeekerDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobSeekerDetails(int id)
        {
            var jobSeekerDetails = await _context.Jsdetails.FindAsync(id);
            if (jobSeekerDetails == null)
            {
                return NotFound();
            }

            _context.Jsdetails.Remove(jobSeekerDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobSeekerDetailsExists(int id)
        {
            return _context.Jsdetails.Any(e => e.JsId == id);
        }
    }
}
