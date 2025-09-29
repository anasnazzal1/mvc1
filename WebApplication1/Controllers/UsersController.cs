using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
       
        public ViewResult getEmployee()
        {
            List<string> names = new List<string>()
        {
            "anas","ahmad","mohammad","mahmoud","osaama"
        };
            return View("index",names) ;
        }
    }
}
