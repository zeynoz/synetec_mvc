using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;

namespace InterviewTestTemplatev2.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(List<Employee> employeeList, int id);
        int GetTotalSalary(List<Employee> employeeList);
    }
}