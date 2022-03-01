using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice.Models.Entities
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please provide username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Pleae provide password")]
        public string Password { get; set; }
        public string Type { get; set; }
    }
}