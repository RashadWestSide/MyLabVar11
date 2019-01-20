using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLabVar11.Models
{
    public class LoginAuth
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class Register
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}