using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketShare.Models;

namespace MarketShare.Controllers
{
    public class ProductoController : Controller
    {
        private MarketShareContext db = new MarketShareContext();

        //
        // GET: /Producto/

        public ActionResult Index()
        {
            var productoes = db.Productoes.Include(p => p.Empresa).Include(p => p.Categoria);
            return View(productoes.ToList());
        }

        //
        // GET: /Producto/Details/5

        public ActionResult Details(int id = 0)
        {
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        //
        // GET: /Producto/Create

        public ActionResult Create()
        {
            ViewBag.EmpresaID = new SelectList(db.Empresas, "EmpresaID", "Nombre");
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "Nombre");
            return View();
        }

        //
        // POST: /Producto/Create

        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Productoes.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpresaID = new SelectList(db.Empresas, "EmpresaID", "Nombre", producto.EmpresaID);
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "Nombre", producto.CategoriaID);
            return View(producto);
        }

        //
        // GET: /Producto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpresaID = new SelectList(db.Empresas, "EmpresaID", "Nombre", producto.EmpresaID);
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "Nombre", producto.CategoriaID);
            return View(producto);
        }

        //
        // POST: /Producto/Edit/5

        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpresaID = new SelectList(db.Empresas, "EmpresaID", "Nombre", producto.EmpresaID);
            ViewBag.CategoriaID = new SelectList(db.Categorias, "CategoriaID", "Nombre", producto.CategoriaID);
            return View(producto);
        }

        //
        // GET: /Producto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Producto producto = db.Productoes.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        //
        // POST: /Producto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = db.Productoes.Find(id);
            db.Productoes.Remove(producto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}