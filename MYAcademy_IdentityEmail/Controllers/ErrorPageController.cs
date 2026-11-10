using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmail.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page401()
        {
            return View();
        }
        public IActionResult Page403()
        {
            return View();
        }
        public IActionResult Page404()
        {
            return View();
        }
    }
}
