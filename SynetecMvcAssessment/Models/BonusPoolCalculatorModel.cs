using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Models
{
    public class BonusPoolCalculatorModel : IBonusPoolCalculatorModel
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int BonusPoolAmount { get; set; }
        public List<Employee> AllEmployees { get; set; }        
        public int SelectedEmployeeId { get; set; }
    }

    public interface IBonusPoolCalculatorModel
    {
        int BonusPoolAmount { get; set; }
        List<Employee> AllEmployees { get; set; }
        int SelectedEmployeeId { get; set; }
    }
}