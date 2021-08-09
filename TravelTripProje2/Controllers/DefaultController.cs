using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje2.Models.Entity;

namespace TravelTripProje2.Controllers
{
    public class DefaultController : Controller
    {
        ProjemDbEntities db = new ProjemDbEntities();
        public ActionResult Index()
        {
            var deger = db.Blog.ToList();
            return View(deger);
        }
        
    }
}