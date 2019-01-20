using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyLabVar11.Models;

namespace MyLabVar11.Controllers
{
    public class FeedbacksController : Controller
    {
        private FirmContext db = new FirmContext();

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await db.Feedbacks.ToListAsync());
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feedback feedback = await db.Feedbacks.FindAsync(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }


        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feedback feedback = await db.Feedbacks.FindAsync(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }

        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Feedback feedback = await db.Feedbacks.FindAsync(id);
            db.Feedbacks.Remove(feedback);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
