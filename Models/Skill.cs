using System.ComponentModel.DataAnnotations;

namespace TopJobs.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        [Required]
        public string SkillName { get; set;}
    }
}
