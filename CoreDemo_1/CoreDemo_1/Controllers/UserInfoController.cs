using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Security.Claims;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo_1.Controllers
{
    public class UserInfoController : Controller
    {
       
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Details");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Login(LoginModel model)
        {
            var identity = new ClaimsIdentity("AccountLogin");
            identity.AddClaim(new Claim(ClaimTypes.Name, "Test"));
            identity.AddClaim(new Claim("AccountID", "1"));
            identity.AddClaim(new Claim("Modules", "1,2,3"));
            identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
             HttpContext.Authentication.SignInAsync("MyCookieMiddlewareInstance",principal, 
                new AuthenticationProperties {
                   IsPersistent = true, ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
                });
            return RedirectToAction("Index", "UserInfo");
        }

        //没有权限页面
        public IActionResult NoOpertion()
        {
            return View();
        }
    }
}