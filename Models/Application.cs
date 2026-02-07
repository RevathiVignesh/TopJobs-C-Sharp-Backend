using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopJobs.Models
{
    public class Application
    {
        [Key]
        public int applicationId { get; set; }
        public int jobId { get; set; }
        [ForeignKey("JobId")]
        [Required]
        public int JsId { get; set; }
        [Required]
        public string status { get; set; }
    }
}
