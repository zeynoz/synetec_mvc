using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;
using BusinessServices.Data;

namespace BusinessServices.Repositories
{
    public interface IEmployeeRepository
    {
        List<HrEmployee> GetHrEmployees();
        HrEmployee GetHrEmployee(int id);
        int GetTotalSalary();
    }
}