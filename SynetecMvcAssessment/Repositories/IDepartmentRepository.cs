using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessEntities;
using InterviewTestTemplatev2.Data;

namespace InterviewTestTemplatev2.Repositories
{
    public interface IDepartmentRepository
    {
        List<Department> GetHrDepartments();
        Department GetHrDepartment(int id);
    }
}