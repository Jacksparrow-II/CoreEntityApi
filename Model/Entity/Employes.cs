using System;
using System.Collections.Generic;

namespace CoreEntityApi.Model.Entity
{
    public partial class Employes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int EmployeeCode { get; set; }
        public string Gender { get; set; }
        public int? Department { get; set; }
        //public string DepartmentName { get; set; }
        public int? Designation { get; set; }
        //public string DesignationName { get; set; }
        public string Dob { get; set; }
        public int Salary { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual Designation DesignationNavigation { get; set; }
    }
}
