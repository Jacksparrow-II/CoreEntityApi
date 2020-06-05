using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityApi.Model.Entity
{
    public partial class Department
    {
        public Department()
        {
            //Employes = new HashSet<Employes>();
        }

      
        public int DepartmentId { get; set; }
     
        public string DepartmentName { get; set; }

        //public virtual ICollection<Employes> Employes { get; set; }
    }
}
