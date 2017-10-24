using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AlintaTestEvgeny.Models.Movie;
using AlintaTestEvgeny.RESTful;

namespace AlintaTestEvgeny.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var model = MovieCharacter.GetList();

            return View(model);
        }
    }
}