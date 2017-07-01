using IServices;
using IServices.IRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class DepartmentRepository : EntityBaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ManageEmployeesContext context) : base(context) { }
    }
}
