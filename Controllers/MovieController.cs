using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAssignment01.Models;

namespace MVCAssignment01.Controllers
{
    public class MovieController : Controller
    {
        MovieContext mc = new MovieContext();

        // GET: Movie
        public ActionResult Index()
        {
            return View(mc.Movies.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            mc.Movies.Add(movie);
            mc.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Movie m = mc.Movies.Find(Id);
            return View(m);
        }

        [HttpPost]
        public ActionResult Edit(Movie m)
        {
            Movie mm = mc.Movies.Find(m.MovieId);
            mm.MovieName = m.MovieName;
            mm.DateofRelease = m.DateofRelease; 
            mc.SaveChanges();
            return View(mm);
        }
        public ActionResult Details(int id)
        {
            Movie m = mc.Movies.Find(id);
            return View(m);
        }
        public ActionResult Delete(int id)
        {
            Movie m = mc.Movies.Find(id);
            mc.Movies.Remove(m);
            mc.SaveChanges();
            return View(m);
        }

        public ActionResult disply()
        {
            return View();
        }
    }
}
