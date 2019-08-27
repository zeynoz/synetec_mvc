using System.Collections.Generic;
using InterviewTestTemplatev2.Controllers;
using InterviewTestTemplatev2.Data;
using InterviewTestTemplatev2.Models;
using InterviewTestTemplatev2.Repositories;
using InterviewTestTemplatev2.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;
using BusinessEntities;

namespace SynetecMvcAssessment.Test
{
    [TestClass]
    public class UnitTestBonusPoolController
    {
        #region Private Members

        private BonusPoolController Target { get; set; }
        
        private EmployeeRepository EmployeeRepository { get; set; }
        private DepartmentRepository DepartmentRepository { get; set; }

        private BonusPoolCalculatorService BonusPoolCalculatorService { get; set; }
        private BonusPoolCalculatorModel BonusPoolCalculatorModel { get; set; }
        private BonusPoolCalculatorResultModel BonusPoolCalculatorResultModel { get; set; }


        Mock<IEmployeeRepository> MockEmployeeRepository { get; set; }
        Mock<IDepartmentRepository> MockDepartmentRepository { get; set; }
        Mock<IBonusPoolCalculatorService> MockBonusPoolCalculatorService { get; set; }


        #endregion

        [TestInitialize]
        public void Setup()
        { 
            MockEmployeeRepository = new Mock<IEmployeeRepository>();
            MockDepartmentRepository = new Mock<IDepartmentRepository>();
            

            EmployeeRepository = new EmployeeRepository();
            DepartmentRepository = new DepartmentRepository();
            BonusPoolCalculatorService = new BonusPoolCalculatorService();
            BonusPoolCalculatorModel = new BonusPoolCalculatorModel();
            BonusPoolCalculatorResultModel = new BonusPoolCalculatorResultModel();            

            Target = new BonusPoolController(EmployeeRepository, DepartmentRepository, BonusPoolCalculatorService, BonusPoolCalculatorModel, BonusPoolCalculatorResultModel);
        }

        [TestMethod]
        public void TestCalculateBonus()
        {

            var Entries = new List<Employee>()
                {
                    new Employee()
                    {
                        EmployeeId = 1,
                        Salary = 60000
                    },
                    new Employee()
                    {
                        EmployeeId = 2,
                        Salary = 90000
                    },
                    new Employee()
                    {
                        EmployeeId = 3,
                        Salary = 504750
                    },
                };
                                    
            int selectedEmployeeId = 1;
            int totalBonusPool = 1000; 

            Mock<IEmployeeRepository> mockEmployeeRepository = new Mock<IEmployeeRepository>();
            mockEmployeeRepository.Setup(s => s.GetEmployees()).Returns(() => Entries);

            int bonusAllocation = BonusPoolCalculatorService.CalculateBonusPool(Entries, selectedEmployeeId, totalBonusPool);                                 

            Assert.AreEqual(bonusAllocation, 91);
            


        }
    }

     
}
