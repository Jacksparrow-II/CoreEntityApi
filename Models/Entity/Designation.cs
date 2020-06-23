using System;
using System.Collections.Generic;

namespace CoreEntityApi.Models.Entity
{
    public partial class Designation
    {
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }

        //public virtual ICollection<Employes> Employes { get; set; }
    }
}
