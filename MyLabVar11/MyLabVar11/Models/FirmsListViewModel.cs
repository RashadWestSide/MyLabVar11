using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLabVar11.Models
{
    public class FirmsListViewModel
    {
        public IEnumerable<Firm> Firms { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentType { get; set; }
    }
}