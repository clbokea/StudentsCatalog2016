using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCatalog2016.Models
{
    public class Student
    {

        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Stupid user Must fill out")]
        [EmailAddress]
        public String Email { get; set; }

    }
}