using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly_3.Models;

namespace vidly_3.Controllers
{
    public class moviesController : Controller
    {
        // GET: movies/Ramdom
        public ActionResult Random()
        {
            var movie = new movie() { Name = "sherk" };
            return View(movie);
        }
    }
}