using System;
using System.Collections.Generic;
using System.Linq;
using Unity;
using BusinessEntities;
using BusinessServices;
using BusinessServices.Data;

namespace BusinessServices.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        [Dependency]
        public MvcInterviewV3Entities DbContext { get; set; }

        public List<HrEmployee> GetHrEmployees()
        {
            return DbContext.HrEmployees.ToList();
        }

        public HrEmployee GetHrEmployee(int id)
        {
            return DbContext.HrEmployees.Where(s => s.ID == id).FirstOrDefault();
        }

        public int GetTotalSalary()
        {
            return DbContext.HrEmployees.Sum(item => item.Salary);
        }

        
    }
}