using CoreEntityApi.Models.Common;
using System.Collections.Generic;

namespace CoreEntityApi.Repository
{
    public interface EmpRepo
    {
        public List<Models.Common.Employes> GetItems();
        public int SaveItem(Models.Common.Employes EmployesModel);
        public int UpdateItem(Models.Common.Employes EmployesModel);
        public int DeleteItem(int Id);
        public List<Models.Common.Department> GetDepartment();
        public List<Models.Common.Designation> GetDesignation();
    }
}
