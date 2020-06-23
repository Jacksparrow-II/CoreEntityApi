using System;
using System.Collections.Generic;

namespace CoreEntityApi.Models.Entity
{
    public partial class Department
    {

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        //public virtual ICollection<Employes> Employes { get; set; }
    }
}
