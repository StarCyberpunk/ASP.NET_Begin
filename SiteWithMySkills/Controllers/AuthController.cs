using Microsoft.AspNetCore.Mvc;

namespace SiteWithMySkills.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Auth()
        {
            return View();
        }

    }
}
