using System;
using System.Collections.Generic;

namespace CoreEntityApi.Model.Entity
{
    public partial class Designation
    {
        public Designation()
        {
            Employes = new HashSet<Employes>();
        }

        public int DesignationId { get; set; }
        public string DesignationName { get; set; }

        public virtual ICollection<Employes> Employes { get; set; }
    }
}
