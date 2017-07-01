using IServices;
using IServices.IRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Services.Repository
{
    public class EmployeeRepository : EntityBaseRepository<Employee>, IEmployeeRepository
    {
       public EmployeeRepository(ManageEmployeesContext context) : base(context) { }

        public override IQueryable<Employee> GetAll()
        {
            Employee em = new Employee();
            em.FirstName = "lwj";
            List<Employee> list = new List<Employee>();
            list.Add(em);
            return list.AsQueryable();
        }
    }
}
