using MyLabVar11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLabVar11.Controllers
{
    public class HomeController : Controller
    {
        public int pageSize = 3;
        FirmContext db = new FirmContext();


        public ViewResult List(string type, int page = 1)
        {
            if (User.Identity.IsAuthenticated)
            {
                FirmsListViewModel model = new FirmsListViewModel
                {
                    Firms = db.Firms
                .Where(b => type == null || b.TypeFirm == type)
                .OrderBy(firm => firm.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = pageSize,
                        TotalItems = type == null ?
                        db.Firms.Count() :
                        db.Firms.Where(firm => firm.TypeFirm == type).Count()
                    },
                    CurrentType = type
                };
                return View(model);
            }
            else
            {
                return View("Pereb");
            }
        }

        public ActionResult Pereb()
        {
            return View();
        }

        public ActionResult Description(int id)
        {
            var row = db.Firms.Single(r => r.Id == id);
            var dess = row.DescriptionF;
            ViewBag.DesC = dess;
            return View();
        }


        [HttpGet]
        public ActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public string Feedback(Feedback feedback)
        {
            // Добавляем информацию о отзыве в БД
            db.Feedbacks.Add(feedback);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо," + feedback.Person + ", за отзыв!";
        }

    }
}