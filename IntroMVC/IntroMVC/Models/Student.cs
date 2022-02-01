using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroMVC.Models
{
    public class Student
    {
        [Required]
        [StringLength(50,ErrorMessage = "Name lenght must not exceed 50")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$",ErrorMessage ="Id must follow XX-XXXXX-X")]
        public string Id { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}