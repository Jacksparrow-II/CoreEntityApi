﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityApi.Models.Common
{
    public class Employes
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
        public int? Department { get; set; }
        public string DepartmentName { get; set; }
        public int? Designation { get; set; }
        public string DesignationName { get; set; }
        //[Required]
        public DateTime Dob { get; set; }
     
        public int Salary { get; set; }



    }
}
