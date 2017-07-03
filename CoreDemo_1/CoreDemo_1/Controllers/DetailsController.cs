using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo_1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            var accountID = User.FindFirst("AccountID").Value;
            int aa = Convert.ToInt32(accountID);

            // User.GetAccountID();
            return View();
        }

        public IActionResult LoginOut()
        {
            HttpContext.Authentication.SignOutAsync("MyCookieMiddlewareInstance");
            return RedirectToAction("Login", "UserInfo");
        }
    }
}