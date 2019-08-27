using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Services
{
    public class BonusPoolCalculatorService:IBonusPoolCalculatorService
    {
      
        public int CalculateBonusPool(List<Employee> employeeList, int employeeId, int totalBonusPool)
        {
            int employeeSalary = GetEmployeeSalary(employeeList, employeeId);
            int totalSalary = GetTotalSalary(employeeList);
            decimal bonusPercentage = (decimal)employeeSalary / (decimal)totalSalary;
            int bonusAllocation = (int)(bonusPercentage * totalBonusPool);

            return bonusAllocation;

        }

        public int GetEmployeeSalary(List<Employee> employeeList, int employeeId)
        {
            var employee = employeeList.Where(x => x.EmployeeId == employeeId).SingleOrDefault();

            if (employee != null)
            {
                return employee.Salary;
            }

            return 0;

        }
        public int GetTotalSalary(List<Employee> employeeList)
        {
            return employeeList.Sum(x => x.Salary);            
        }               

    }
}