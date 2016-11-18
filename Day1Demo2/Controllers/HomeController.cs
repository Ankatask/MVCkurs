using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1Demo2.Models;

namespace Day1Demo2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RSVP()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RSVP(Guest g)
        {
            //Kontrollera att modellens krav för validering är uppfyllda
            if(ModelState.IsValid)
            {
                return View("Thanks", g);
            }
            else
            {
                return View();
            }
        }
	}
}