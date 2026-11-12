using Microsoft.AspNetCore.Mvc;

namespace MYAcademy_IdentityEmail.ViewComponents.MessageLayoutViewComponentPartial
{
    public class _MessageLayoutScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
