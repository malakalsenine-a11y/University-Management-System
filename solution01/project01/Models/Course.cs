using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class Course
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }  // system generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; } // user input (unique)

        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; } // user input

        [Required]
        [Range(1,6)]
        public int creditHours { get; set; }  // system generated

        [Required]
        [ForeignKey ("Department")]
        public int departmentId { get; set; }  // foreign key

        [ForeignKey("Instructor")]
        public int? instructorId { get; set; }  // foreign key

        [Required]
        [MaxLength (20)]
        public string semesterOffered { get; set; } // user input


        public Department department { get; set; }  // navigation
        public Instructor instructor { get; set; }  // navigation



    }
}
