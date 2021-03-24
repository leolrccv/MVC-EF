using MVCEF.Dal;
using MVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEF.Controllers
{
    public class PizzaController : Controller
    {
        private LanchoneteContext db = new LanchoneteContext();

        // GET: Dog
        public ActionResult Index()
        {
            return View(db.Pizzas.ToList());
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza pizza) {
            if (ModelState.IsValid) {
                db.Pizzas.Add(pizza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Edit(int id) {
            return View(db.Pizzas.First(d => d.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pizza pizza) {
            if (ModelState.IsValid) {
                Pizza pizzaUpdate = db.Pizzas.First(d => d.Id == pizza.Id);
                pizzaUpdate.Descricao = pizza.Descricao;
                pizzaUpdate.Valor = pizza.Valor;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pizza);
        }

        public ActionResult Details(int id) {
            return View(db.Pizzas.First(d => d.Id == id));
        }

        public ActionResult Delete(int id) {
            return View(db.Pizzas.First(d => d.Id == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id) {
            db.Pizzas.Remove(db.Pizzas.First(d => d.Id == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}