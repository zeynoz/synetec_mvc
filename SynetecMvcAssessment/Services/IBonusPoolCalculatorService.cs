using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Services
{
    public interface IBonusPoolCalculatorService
    {        
        int CalculateBonusPool(List<Employee> employeeList, int employeeId, int totalBonusPool);
        int GetEmployeeSalary(List<Employee> employeeList, int employeeId);
        int GetTotalSalary(List<Employee> employeeList);
    }
}