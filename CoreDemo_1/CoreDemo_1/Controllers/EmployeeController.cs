using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IServices.IRepository;

namespace CoreDemo_1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _iemployeerepository;

        public EmployeeController(IEmployeeRepository iemployeerepository)
        {
            _iemployeerepository = iemployeerepository;
        }

        public IActionResult Index()
        {
             var list= _iemployeerepository.GetAll();
            return View();
        }
    }
}