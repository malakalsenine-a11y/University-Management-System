using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId { get; set; }  // system generated

        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; } // user input (unique)

        [MaxLength(150)]
        public string? building { get; set; } // user input (Optional)

        [Required]
        [Range(0, double.MaxValue)]
        public decimal budget { get; set; } // user input

        [ForeignKey ("Instructor")]
        public int? headInstructorId { get; set; } // Foreign Key 

        public Instructor headInstructor  { get; set; }  //navigation
    }
}
