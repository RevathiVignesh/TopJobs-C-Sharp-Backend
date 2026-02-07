using System.ComponentModel.DataAnnotations;

namespace TopJobs.Models
{
    public class Login
    {
        [Key]
        public string Emailid { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
