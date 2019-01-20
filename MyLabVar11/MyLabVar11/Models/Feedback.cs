using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLabVar11.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string FeedText { get; set; }
        public string Person { get; set; }
        public string Email { get; set; }
    }
}