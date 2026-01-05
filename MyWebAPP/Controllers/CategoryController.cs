using Microsoft.AspNetCore.Mvc;
using MyWebAPP.Data;
using MyWebAPP.Models;
using System.Reflection.Metadata.Ecma335;

namespace MyWebAPP.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> Categories = _db.Categories.ToList();
            return View(Categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category Ctg)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(Ctg);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? Category_ID)
        {
            if (Category_ID == null || Category_ID == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _db.Categories.Find(Category_ID);
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        
        [HttpPost]
        public IActionResult Edit(Category Ctg)
        {
            if (ModelState.IsValid)
            {
                var categoryFromDb = _db.Categories.Find(Ctg.Category_ID);

                if (categoryFromDb == null)
                {
                    return NotFound();
                }

                categoryFromDb.Category_Name = Ctg.Category_Name;
                categoryFromDb.Display_Order = Ctg.Display_Order;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Ctg);
        }
        
        public IActionResult Delete(int? Category_ID)
        {
            if (Category_ID == null || Category_ID == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _db.Categories.Find(Category_ID);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category Ctg)
        {
            var categoryFromDb = _db.Categories.Find(Ctg.Category_ID);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(categoryFromDb);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
