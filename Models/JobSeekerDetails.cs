using System.ComponentModel.DataAnnotations;

namespace TopJobs.Models
{
    public class JobSeekerDetails
    {
        [Key]
        public int JsId { get; set; }
        [Required]
        public string JsName { get; set; }
        [Required]
        public string JsCountry { get; set; }
        [Required]
        public string JsState { get; set; }
        [Required]
        public string JsCity { get; set; }
        [Required]
        public string JsGender { get; set; }
        [Required]
        public string   JsPhoneNo { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string JsEmail { get; set; }
        [Required]
        public string JsPassword { get; set; }

    }
}
 