using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityApi.Model.Entity
{
    public partial class Employes
    {
        //[Key]
        public int Id { get; set; }
        //[Required]
        public string Name { get; set; }
        //[Required]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Required]
        public int EmployeeCode { get; set; }
        //[Required]
        public string Gender { get; set; }
        //[Required]
        public int? Department { get; set; }
        //public string DepartmentName { get; set; }
        //[Required]
        public int? Designation { get; set; }
        //public string DesignationName { get; set; }
        //[Required]
        public string Dob { get; set; }
        //[Required]
        public int Salary { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual Designation DesignationNavigation { get; set; }
    }
}
