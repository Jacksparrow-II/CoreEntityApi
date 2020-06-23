using CoreEntityApi.Models.Common;
using System;
using System.Collections.Generic;

namespace CoreEntityApi.Repository
{
    public interface EmpRepo
    {
        public List<Models.Common.Employes> GetItems();
        public int SaveItem(Models.Common.Employes EmployesModel, int EmployeeCode, DateTime Dob);
        public int UpdateItem(Models.Common.Employes EmployesModel, int Id, string Name, int EmployeeCode, DateTime Dob);
        public int DeleteItem(int Id);
        public Models.Common.Employes EmployeeById(int ID);


        public List<Models.Common.Department> GetDepartment();
        public int AddDepartment(Models.Common.Department Department, string DepartmentName);
        public int UpdateDepartment(Models.Common.Department Department, int DepartmentId, string DepartmentName);
        public int DeleteDepartment(int DepartmentId);
        public Models.Common.Department DepartmentById(int DepartmentId);


        public List<Models.Common.Designation> GetDesignation();
        public int AddDesignation(Models.Common.Designation Designation, string DesignationName);
        public int UpdateDesignation(Models.Common.Designation Designation, int DesignationId, string DesignationName);
        public int DeleteDesignation(int DesignationId);
        public Models.Common.Designation DesignationById(int DesignationId);

    }
}
