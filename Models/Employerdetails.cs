using System.ComponentModel.DataAnnotations;

namespace TopJobs.Models
{
    public class Employerdetails
    {
        [Key]
        public int EmployeeID {  get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeCompany { get; set; }
        [Required]
        public string EmployeeCountry {  get; set; }
        [Required]
        public string EmployeeState {  get; set; }
        [Required]
        public string EmployeeCity {  get; set; }
        [Required]
        public string EmployeePhoneNo { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmployeeEmail { get; set; }
        [Required]
        public string EmployeePassword{ get; set; }
    }
}
