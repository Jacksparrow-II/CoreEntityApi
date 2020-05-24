using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreEntityApi.Model.Common
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }

        [Required]
        public string DesignationName { get; set; }

        public virtual ICollection<Employes> Employes { get; set; }
    }
}
