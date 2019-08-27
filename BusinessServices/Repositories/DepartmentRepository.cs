using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using BusinessEntities;
using BusinessServices.Data;

namespace BusinessServices.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        [Dependency]
        public MvcInterviewV3Entities DbContext { get; set; }

        public List<HrDepartment> GetHrDepartments()
        {
            return DbContext.HrDepartments.ToList();
        }

        public HrDepartment GetHrDepartment(int id)
        {
            return DbContext.HrDepartments.Where(s => s.ID == id).FirstOrDefault();
        }
    }
}