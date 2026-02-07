using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TopJobs.Models
{
    public class ApplicationForm
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
