using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityApi.Model.Entity
{
    public partial class Designation
    {
        public Designation()
        {
            Employes = new HashSet<Employes>();
        }

        [Key]
        public int DesignationId { get; set; }
        [Required]
        public string DesignationName { get; set; }

        public virtual ICollection<Employes> Employes { get; set; }
    }
}
