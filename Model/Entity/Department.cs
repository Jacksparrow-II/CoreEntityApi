using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityApi.Model.Entity
{
    public partial class Department
    {
        public Department()
        {
            Employes = new HashSet<Employes>();
        }

        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }

        public virtual ICollection<Employes> Employes { get; set; }
    }
}
