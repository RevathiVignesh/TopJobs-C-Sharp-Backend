using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopJobs.Models
{
    public class Resume
    {
        [Key]
        public int ResumeId { get; set; }
        [Required]
        public int JsId { get; set; }
        [ForeignKey("JsId")]

        [Required]
        public string Skills { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        public string Summary { get; set; }
        public int tenpercentage { get; set; }
        public string tenyear { get; set; }
        public int twelvepercentage { get; set; }
        public string twelveyear { get; set; }
        public int ugpercentage { get; set; }
        public string ugyear { get; set; }
        public int pgpercentage { get; set; }
        public string pgyear { get; set; }


    }
}
