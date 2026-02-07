using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopJobs.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        [Required]
        public string JobDesigntion { get; set; }
        [Required]
        public string RolesandResponsibility {  get; set; }
        [Required]
        public string Skillsneeded { get; set; }
        [Required]
        public int JobSalary { get; set; }
        [Required]
        public string Eligibility { get; set;}
        [Required]
        public int Experience {  get; set; }
        [Required]
        public string JobCountry { get; set; }
        [Required]
        public string JobState { get; set; }
        [Required]
        public string JobCity { get; set; }
        [Required]
        public string JobStatus { get; set;}

    }
}
