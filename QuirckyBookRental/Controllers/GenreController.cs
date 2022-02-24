using QuirkyBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuirkyBookRental.Controllers
{
    public class GenreController : Controller
    {

        private ApplicationDbContext db;

        public GenreController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Genre
        public ActionResult Index()
        {
            return View(db.Genres.ToList());
        }

        //Get Action
        public ActionResult Create()
        {
            return View();
        }

        //Post Action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            if(ModelState.IsValid)
            {
                db.Genres.Add(genre);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

       public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Genre genre = db.Genres.Find(id);

            if(genre == null)
            {
                return HttpNotFound();
            }

            return View();
        }    


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}