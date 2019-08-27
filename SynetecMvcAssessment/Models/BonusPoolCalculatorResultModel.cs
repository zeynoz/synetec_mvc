using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Models
{
    public class BonusPoolCalculatorResultModel : IBonusPoolCalculatorResultModel
    {
        public Employee Employee { get; set; }
        public int BonusPoolAllocation { get; set; }
        public bool Status { get; set; }
    }

    public interface IBonusPoolCalculatorResultModel
    {
        Employee Employee { get; set; }
        int BonusPoolAllocation { get; set; }
        bool Status { get; set; }
    }
}