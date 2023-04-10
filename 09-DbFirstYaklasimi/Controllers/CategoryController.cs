using _09_DbFirstYaklasimi.Models;
using Microsoft.AspNetCore.Mvc;

namespace _09_DbFirstYaklasimi.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext context = new NorthwindContext();
        public IActionResult Index()
        {
            var list = context.Categories.ToList();

            return View(list);
        }
        public IActionResult Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }
        public IActionResult Edit(int id)
        { 
            //var category = context.Categories.FirstOrDefault(x => x.CategoryId == id);
            var category = context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Update(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(category);
        }
        public IActionResult Delete(int id)
        {
            var category = context.Categories.FirstOrDefault(x => x.CategoryId == id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            
                context.Categories.Remove(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            

            
        }
    }
}
