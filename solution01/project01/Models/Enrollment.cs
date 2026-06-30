using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    internal class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; }  // system generated

        [ForeignKey("Student")]
        public int studentId { get; set; }  // foreign key

        [ForeignKey("Course")]
        public int courseId { get; set; }  // foreign key

        [Required]
        public DateTime enrollmentDate { get; set; } // user input 

        [MaxLength (2)]
        public string finalGrade { get; set; } // user input

        [Required]
        [MaxLength(20)]
        public string status { get; set; }  // default value 
    }
}
