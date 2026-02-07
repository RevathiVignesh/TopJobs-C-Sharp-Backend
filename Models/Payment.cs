using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopJobs.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]

        [Required]
        public string MembershipType {  get; set; }
        [Required]
        public DateOnly DateOfPayment { get; set;}
        [Required]
        public DateOnly Endofmembership { get; set; }
        
    }
}
