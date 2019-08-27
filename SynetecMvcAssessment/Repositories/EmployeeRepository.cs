using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;
using InterviewTestTemplatev2.Data;
using Unity;

namespace InterviewTestTemplatev2.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        [Dependency]
        public MvcInterviewV3Entities1 DbContext { get; set; }

        public List<Employee> GetEmployees()
        {
            var result = DbContext.HrEmployees.ToList();


            var employeeList = result.Select(e => new Employee
            {
                EmployeeId = e.ID,
                FistName = e.FistName,
                SecondName = e.SecondName, 
                DateOfBirth = e.DateOfBirth,
                DepartmentId = e.HrDepartmentId,
                JobTitle = e.JobTitle,
                Salary = e.Salary,
                Full_Name = e.Full_Name

            }).ToList();

            return employeeList;
        }

        public Employee GetEmployee(List<Employee> employeeList ,int id)
        {
            return employeeList.Where(x => x.EmployeeId == id).SingleOrDefault();
            //return DbContext.HrEmployees.Where(s => s.ID == id).FirstOrDefault();
        }

        public int GetTotalSalary(List<Employee> employeeList)
        {
            return employeeList.Sum(x => x.Salary);
            //return DbContext.HrEmployees.Sum(item => item.Salary);
        }

       
    }
}