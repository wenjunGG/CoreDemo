using IServices;
using IServices.IRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Repository
{
    public class ContractRepository : EntityBaseRepository<Contract>, IContractRepository
    {
        public ContractRepository(ManageEmployeesContext context) : base(context) { }
    }
}
