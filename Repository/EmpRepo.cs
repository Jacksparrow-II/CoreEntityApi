using CoreEntityApi.Models.Common;
using System.Collections.Generic;

namespace CoreEntityApi.Repository
{
    public interface EmpRepo
    {
        public List<Model.Common.Employes> GetItems();
        public int SaveItem(Model.Common.Employes EmployesModel);
        public int UpdateItem(Model.Common.Employes EmployesModel);
        public int DeleteItem(int Id);

        public List<Model.Common.Department> GetDepartment();
        public int AddDepartment(Model.Common.Department Department);
        public int UpdateDepartment(Model.Common.Department Department);
        public int DeleteDepartment(int DepartmentId);

        public List<Model.Common.Designation> GetDesignation();
        public int AddDesignation(Model.Common.Designation Designation);
        public int UpdateDesignation(Model.Common.Designation Designation);
        public int DeleteDesignation(int DesignationId);

    }
}
