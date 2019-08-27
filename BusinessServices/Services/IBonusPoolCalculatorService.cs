using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BusinessServices.Services
{
    public interface IBonusPoolCalculatorService
    {
        int Calculate(int totalBonusPool, int totalSalary, int employeeSalary);
    }
}