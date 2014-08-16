using System.Data;
using System.Linq;
using System.Web.Mvc;
using WineCellar.DAL;
using WineCellar.Models;

namespace WineCellar.Controllers
{
    public class WineController : Controller
    {
        private readonly IWineContext db;

        public WineController()
        {
        }

        public WineController(IWineContext db)
        {
            this.db = db;
        }

        //
        // GET: /Wine/

        public ActionResult Index()
        {
            return View(db.Wines.ToList());
        }

        //
        // GET: /Wine/Details/5

        public ActionResult Details(int id = 0)
        {
            Wine wine = db.Wines.Find(id);
            if (wine == null)
            {
                return HttpNotFound();
            }
            return View(wine);
        }

        //
        // GET: /Wine/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Wine/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Wine wine)
        {
            if (ModelState.IsValid)
            {
                db.Wines.Add(wine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wine);
        }

        //
        // GET: /Wine/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Wine wine = db.Wines.Find(id);
            if (wine == null)
            {
                return HttpNotFound();
            }
            return View(wine);
        }

        //
        // POST: /Wine/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Wine wine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wine);
        }

        //
        // GET: /Wine/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Wine wine = db.Wines.Find(id);
            if (wine == null)
            {
                return HttpNotFound();
            }
            return View(wine);
        }

        //
        // POST: /Wine/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wine wine = db.Wines.Find(id);
            db.Wines.Remove(wine);
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