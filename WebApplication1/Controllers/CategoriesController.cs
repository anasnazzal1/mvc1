using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data; // Make sure this namespace matches your DbContext location
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        
        public ViewResult Index()
        {
            var categores = context.Categories.ToList();
            return View("index", categores);
        }
        public ViewResult details(int id) {

            var data = context.Categories.Find(id);

            return View("details", data);
        }

        public ViewResult Create(Category c)
        {
            if (ModelState.IsValid) // 🔹 تحقق من صحة البيانات قبل الحفظ
            {
                context.Categories.Add(c);
                context.SaveChanges();

                var categories = context.Categories.ToList();
                return View("Index", categories); // 🔹 عرض القائمة بعد الإضافة
            }

            return View(c); // 🔹 في حالة البيانات غير صحيحة، يرجع لنفس الـ View
        }
        public IActionResult delete(int id) { 
        var item = context.Categories.Find(id);
            context.Categories.Remove(item);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult update(int id)
        {
                var item = context.Categories.Find(id);
                return View(item);

            
        }
        [HttpPost]
        public IActionResult update(Category c)
        {
            if (ModelState.IsValid) { 
            context.Categories.Update(c);
                context.SaveChanges();  
                return RedirectToAction("Index");
            
            }

            return View(c);


        }

    }
}
