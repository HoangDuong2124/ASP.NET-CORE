using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public string? EmployeeId { get; set; }
        [Required]
        public string? EmployeeName { get; set; }
        [Required]
        public string? Department { get; set; }
        public decimal Salary { get; set; }
    }
}