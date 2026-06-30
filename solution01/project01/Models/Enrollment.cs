using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    internal class Enrollment
    {

        public int enrollmentId { get; set; }  // system generated

        public int studentId { get; set; }  // foreign key

        public int courseId { get; set; }  // foreign key

        public DateTime enrollmentDate { get; set; } // user input 


        public string finalGrade { get; set; } // user input

        [MaxLength(20)]
        public string status { get; set; }  // default value 
    }
}
