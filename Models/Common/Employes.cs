using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEntityApi.Models.Common
{
    public class Employes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int EmployeeCode { get; set; }
        public string Gender { get; set; }
        public int? Department { get; set; }
        public int? Designation { get; set; }
        public string Dob { get; set; }
        public int Salary { get; set; }
    }
}
