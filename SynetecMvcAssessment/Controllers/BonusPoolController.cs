using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewTestTemplatev2.Data;

using InterviewTestTemplatev2.Repositories;
using InterviewTestTemplatev2.Models;
using InterviewTestTemplatev2.Services;
using BusinessEntities;

namespace InterviewTestTemplatev2.Controllers
{
    public class BonusPoolController : Controller
    {
        private readonly IBonusPoolCalculatorService bonusPoolCalculatorService;
        private IEmployeeRepository employeeRepository;
        readonly IDepartmentRepository departmentRepository;

        private IBonusPoolCalculatorModel bonusPoolCalculatorModel;
        private IBonusPoolCalculatorResultModel bonusPoolCalculatorResultModel;

        public BonusPoolController(
            IEmployeeRepository employeeRepository,
            IDepartmentRepository departmentRepository,
            IBonusPoolCalculatorService bonusPoolCalculatorService,
            IBonusPoolCalculatorModel bonusPoolCalculatorModel,
            IBonusPoolCalculatorResultModel bonusPoolCalculatorResultModel
            )
        {
            this.bonusPoolCalculatorService = bonusPoolCalculatorService;
            this.employeeRepository = employeeRepository;
            this.departmentRepository = departmentRepository;

            this.bonusPoolCalculatorModel = bonusPoolCalculatorModel;
            this.bonusPoolCalculatorResultModel = bonusPoolCalculatorResultModel;
        }


        // GET: BonusPool
        public ActionResult Index()
        {
            bonusPoolCalculatorModel.AllEmployees = employeeRepository.GetEmployees();

            return View(bonusPoolCalculatorModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate(BonusPoolCalculatorModel model)
        {
            int selectedEmployeeId = model.SelectedEmployeeId;
            int totalBonusPool = model.BonusPoolAmount;

            var employees = employeeRepository.GetEmployees();
            var employee = employeeRepository.GetEmployee(employees, selectedEmployeeId);

            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMessage = "Please check BonusPoolAmount !!";

                bonusPoolCalculatorResultModel.Employee = employee;
                bonusPoolCalculatorResultModel.BonusPoolAllocation = 0;

                return View(bonusPoolCalculatorResultModel);
            }

           

            //load the details of the selected employee using the ID
           

            //get the total salary budget for the company       
            int bonusAllocation = bonusPoolCalculatorService.CalculateBonusPool(employees, selectedEmployeeId, totalBonusPool);
            
            bonusPoolCalculatorResultModel.Employee = employee;
            bonusPoolCalculatorResultModel.BonusPoolAllocation = bonusAllocation;
            
            return View(bonusPoolCalculatorResultModel);
        }
    }
}