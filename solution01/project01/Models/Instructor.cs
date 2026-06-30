using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; }  // system generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } // user input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } // user input ( unique)

        [MaxLength(20)]
        public string? officeNumber { get; set; }  // user input (optional)

        [Required]
        public DateTime hireDate { get; set; } // user input 

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal salary { get; set; } // user input

        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; }  // user input 

        public IList<Course> courses { get; set; }  // Relationships

        public Department Department { get; set; }  //Relationships



    }
}
