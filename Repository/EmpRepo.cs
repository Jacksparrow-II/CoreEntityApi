using CoreEntityApi.Models.Common;
using System;
using System.Collections.Generic;

namespace CoreEntityApi.Repository
{
    public interface EmpRepo
    {
        public List<Model.Common.Employes> GetItems();
        public int SaveItem(Model.Common.Employes EmployesModel, string Name, DateTime Dob);
        public int UpdateItem(Model.Common.Employes EmployesModel, int Id, string Name, int EmployeeCode, DateTime Dob);
        public int DeleteItem(int Id);
        public Models.Common.Employes EmployeeById(int ID);


        public List<Model.Common.Department> GetDepartment();
        public int AddDepartment(Model.Common.Department Department, string DepartmentName);
        public int UpdateDepartment(Model.Common.Department Department, int DepartmentId, string DepartmentName);
        public int DeleteDepartment(int DepartmentId);
        public Models.Common.Department DepartmentById(int DepartmentId);

        public List<Model.Common.Designation> GetDesignation();
        public int AddDesignation(Model.Common.Designation Designation, string DesignationName);
        public int UpdateDesignation(Model.Common.Designation Designation, int DesignationId, string DesignationName);
        public int DeleteDesignation(int DesignationId);
        public Models.Common.Designation DesignationById(int DesignationId);

    }
}
