using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using InterviewTestTemplatev2.Models;
using InterviewTestTemplatev2.Repositories;
using InterviewTestTemplatev2.Services;

namespace InterviewTestTemplatev2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IBonusPoolCalculatorService, BonusPoolCalculatorService>();


            container.RegisterType<IBonusPoolCalculatorModel, BonusPoolCalculatorModel>();
            container.RegisterType<IBonusPoolCalculatorResultModel, BonusPoolCalculatorResultModel>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}