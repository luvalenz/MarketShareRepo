using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketShare.Models;
using System.Data;
using System.Data.Entity;

namespace MarketShare.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private MarketShareContext db = new MarketShareContext();

        public ActionResult Index()
        {
            ViewBag.Message = "";
            var productos = db.Productoes.Include(p => p.Empresa).Include(p => p.Categoria);
            return View(productos.ToList());
        }

    }
}
