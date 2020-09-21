using System;
using System.Collections.Generic;

namespace CoreEntityApi.Models1.Entity
{
    public partial class Department
    {
        public Department()
        {
            Employes = new HashSet<Employes>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Employes> Employes { get; set; }
    }
}
