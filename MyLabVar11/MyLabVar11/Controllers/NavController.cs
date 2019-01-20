using MyLabVar11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLabVar11.Controllers
{
    public class NavController : Controller
    {
        FirmContext db = new FirmContext();

        public PartialViewResult Menu(string type = null)
        {
            ViewBag.SelectedType = type;

            IEnumerable<string> types = db.Firms
                .Select(firm => firm.TypeFirm)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(types);
        }
    }
}