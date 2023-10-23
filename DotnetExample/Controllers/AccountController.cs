using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;

namespace DotnetExample.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl = "https://localhost:44343/")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }

        public IActionResult Logout()
        {
            return SignOut(new AuthenticationProperties { RedirectUri = "/" });
        }
    }
}