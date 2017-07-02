using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IServices.IRepository;
using Common;

namespace CoreDemo_1.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeRepository _iemployeerepository;

        public EmployeeController(IEmployeeRepository iemployeerepository)
        {
            _iemployeerepository = iemployeerepository;
        }

        public IActionResult Index()
        {
            byte[] result;
            HttpContext.Session.TryGetValue("CurrentUser", out result);

           object value= ByteConvertHelper.Bytes2Object(result);

            var list= _iemployeerepository.GetAll();
            return View();
        }
    }
}