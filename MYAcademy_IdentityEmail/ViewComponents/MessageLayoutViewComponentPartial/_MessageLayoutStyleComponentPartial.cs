using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmail.ViewComponents.MessageLayoutViewComponentPartial
{
    public class _MessageLayoutStyleComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
