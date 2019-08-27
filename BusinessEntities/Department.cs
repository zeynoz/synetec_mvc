using System;

namespace BusinessEntities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? BonusPoolAllocationPerc { get; set; }
    }

}
