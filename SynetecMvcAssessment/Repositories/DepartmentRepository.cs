using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InterviewTestTemplatev2.Models;
using InterviewTestTemplatev2.Data;

using Unity;
using BusinessEntities;

namespace InterviewTestTemplatev2.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        [Dependency]
        public MvcInterviewV3Entities1 DbContext { get; set; }

        public List<Department> GetHrDepartments()
        {
            var result = DbContext.HrDepartments;

            var departmantList = result.Select(d => new Department
                                        {
                                            DepartmentId = d.ID,
                                            Title = d.Title,
                                            Description = d.Description,
                                            BonusPoolAllocationPerc = d.BonusPoolAllocationPerc

                                        }).ToList();

            return departmantList;
        }

        public Department GetHrDepartment(int id)
        {
            var result = DbContext.HrDepartments.Where(s => s.ID == id);

            var departmant = result.Select(d => new Department
                    {
                        DepartmentId = d.ID,
                        Title = d.Title,
                        Description = d.Description,
                        BonusPoolAllocationPerc = d.BonusPoolAllocationPerc

                    }).FirstOrDefault();                        
             
            return departmant;
        }
    }
}