using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessServices.Services
{
    public class BonusPoolCalculatorService:IBonusPoolCalculatorService
    {
        public int Calculate(int totalBonusPool, int totalSalary, int employeeSalary)
        {
            decimal bonusPercentage = (decimal)employeeSalary / (decimal)totalSalary;
            int bonusAllocation = (int)(bonusPercentage * totalBonusPool);

            return bonusAllocation;
        }
    }
}