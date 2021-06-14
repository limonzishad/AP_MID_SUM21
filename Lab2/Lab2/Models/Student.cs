using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insert Your Name")]
        [MaxLength(5, ErrorMessage = "Max Length 5")]
        public string Name { get; set; }

        public string Dob { get; set; }

        [Required]
        [Range(100, 200)]
        public int Credit { get; set; }
        [Range(0, 4)]
        public double CGPA { get; set; }
        public int Deptid { get; set; }
    }
}