using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLabVar11.Models
{
    public class FirmContext : DbContext
    {
        public FirmContext() :
            base("FirmContext")
        { }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}