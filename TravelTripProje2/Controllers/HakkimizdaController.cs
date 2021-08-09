using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje2.Models.Entity;


namespace TravelTripProje2.Controllers
{
    public class HakkimizdaController : Controller
    {

        ProjemDbEntities db = new ProjemDbEntities();
        // GET: Hakkimizda
        public ActionResult Index()
        {
            var deger = db.Hakkimizda.ToList();
            return View(deger);
        }
    }
}