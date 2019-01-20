using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLabVar11.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}