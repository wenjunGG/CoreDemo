using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Common;

namespace CoreDemo_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //检查用户信息
                
                if (model.UserName=="lwj"&&model.Password=="123")
                {
                    //记录Session
                    HttpContext.Session.Set("CurrentUser", ByteConvertHelper.Object2Bytes("lwj"));
                   // 跳转到系统首页
                    return RedirectToAction("Index", "Employee");
                }
                ModelState.AddModelError("", "用户名或密码错误。");
                return View();
            }
            return View(model);
        }
    }
}