using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MYAcademy_IdentityEmail.Entities;
using MYAcademy_IdentityEmail.Models;

namespace MYAcademy_IdentityEmail.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }


        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel userLoginViewModel)
        {
            var result=await _signInManager.PasswordSignInAsync(userLoginViewModel.Username, userLoginViewModel.Password,false,false);
            if (result.Succeeded)
            {
                return RedirectToAction("Inbox", "Message");
            }
            if (result.IsNotAllowed)
                ModelState.AddModelError("", "Giriş izni yok (e-posta onayı gerekiyor olabilir).");
            else if (result.IsLockedOut)
                ModelState.AddModelError("", "Hesap kilitlendi.");
            else
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");

            return View(userLoginViewModel);
        }

    }
}
