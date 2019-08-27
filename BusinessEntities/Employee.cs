using System;

namespace BusinessEntities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FistName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public string Full_Name { get; set; }
    }
}
