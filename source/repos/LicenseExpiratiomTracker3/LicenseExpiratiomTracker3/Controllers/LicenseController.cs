using LicenseExpiratiomTracker3.Data;
using LicenseExpiratiomTracker3.Models;
using Microsoft.AspNetCore.Mvc;

namespace LicenseExpiratiomTracker3.Controllers
{
    public class LicenseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LicenseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<License> licesnsesList = _db.licensesTable3;
            return View(licesnsesList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(License obj)
        {
            if (ModelState.IsValid)
            {
                _db.licensesTable3.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult GetDelete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _db.licensesTable3.Find(id);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _db.licensesTable3.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.licensesTable3.Remove(obj);
            _db.SaveChanges(true);
            return RedirectToAction("Index");
        }

        public IActionResult GetUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _db.licensesTable3.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(License obj)
        {

            //var objFound = _db.licensesTable3.Find(id);
            //if (obj == null)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                _db.licensesTable3.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
