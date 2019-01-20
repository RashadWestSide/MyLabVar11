using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLabVar11.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("FirmContext")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }

}