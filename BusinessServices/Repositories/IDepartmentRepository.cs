using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessServices.Data;

namespace BusinessServices.Repositories
{
    public interface IDepartmentRepository
    {
        List<HrDepartment> GetHrDepartments();
        HrDepartment GetHrDepartment(int id);
    }
}