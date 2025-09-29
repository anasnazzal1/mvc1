using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data; // Make sure this namespace matches your DbContext location
using System.Linq;

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
    }
}
