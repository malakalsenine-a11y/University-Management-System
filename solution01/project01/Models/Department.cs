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
        public string departmentName { get; set; } // user input

        [Required]
        [MaxLength(150)]
        public string building { get; set; } // user input

        public decimal budget { get; set; } // user input

        public int headInstructorId { get; set; } // Foreign Key 

    }
}
