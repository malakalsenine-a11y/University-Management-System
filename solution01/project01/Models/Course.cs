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


        public string courseCode { get; set; } // user input

        public string courseTitle { get; set; } // user input

        public int creditHours { get; set; }  // system generated

        public int departmentId { get; set; }  // foreign key

        public int coinstructorIdurseId { get; set; }  // foreign key

        public string semesterOffered { get; set; } // user input

    }
}
