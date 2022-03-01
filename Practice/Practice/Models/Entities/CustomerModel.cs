using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models.Entities
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public Nullable<int> UserId { get; set; }
    }
}