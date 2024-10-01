using BaragaMemberApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// public class LoginController : Controller
// {
//     public IActionResult Index()
//     {
//         return View();
//     }

//     [HttpPost]
//     public async Task<IActionResult> Index(LoginModel model)
//     {
//         // Example credentials for testing
//         if (model.Username == "test" && model.Password == "password")
//         {
//             var claims = new List<Claim> { new Claim(ClaimTypes.Name, model.Username) };

//             var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//             var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

//             await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
//             return RedirectToAction("Index", "Home"); // Redirect to Home page
//         }

//         ModelState.AddModelError("", "Invalid login attempt.");
//         return View();
//     }


//     public async Task<IActionResult> Logout()
//     {
//         await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
//         return RedirectToAction("Index", "Home");
//     }
// }

public class LoginController : Controller
{
    // Handle GET requests
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    // Handle POST requests for login
    [HttpPost]
    public async Task<IActionResult> Index(LoginModel model)
    {
        if (model.Username == "test" && model.Password == "password")
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, model.Username) };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError("", "Invalid login attempt.");
        return View();
    }
}
