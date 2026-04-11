using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        [Required]
        public required string Name {  get; set; }
        public int Age { get; set; }
    }
}
