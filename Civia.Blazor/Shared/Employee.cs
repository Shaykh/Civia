using System.ComponentModel.DataAnnotations;

namespace Civia.Blazor.Shared.Models
{
    public class Employee
    {
        public long EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
    }
}
