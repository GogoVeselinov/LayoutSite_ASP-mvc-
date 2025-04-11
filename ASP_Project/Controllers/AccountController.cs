using Microsoft.AspNetCore.Mvc;

namespace ASP_Project.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
