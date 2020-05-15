using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CoreEntityApi.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEntityApi.Repository
{

    public class EmployesRepo : EmpRepo
    {

// ------------------------------------Department Area--------------------------------------------------
        public List<Model.Common.Department> GetDepartment()
        {
            List<Model.Common.Department> Items = new List<Model.Common.Department>();
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Department emp;
                    foreach (var it in dBContext.Department)
                    {
                        emp = new Model.Common.Department();
                        emp.DepartmentId = it.DepartmentId;
                        emp.DepartmentName = it.DepartmentName;
                        Items.Add(emp);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Items;
        }

        public int AddDepartment(Model.Common.Department DepartmentModel)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Department emp;
                    //Add record
                    if (DepartmentModel.DepartmentId == 0)
                    {
                        emp = new Model.Entity.Department();
                        emp.DepartmentName = DepartmentModel.DepartmentName;
                        dBContext.Department.Add(emp);
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int UpdateDepartment(Model.Common.Department DepartmentModel)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Department emp = new Model.Entity.Department();
                    //Add record
                    {
                        emp = dBContext.Department.FirstOrDefault(asd => asd.DepartmentId == DepartmentModel.DepartmentId);
                        if (emp != null)
                        {
                            //emp = new Employes();
                            emp.DepartmentId = DepartmentModel.DepartmentId;
                            emp.DepartmentName = DepartmentModel.DepartmentName;
                            dBContext.Department.Update(emp);
                        }
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int DeleteDepartment(int DepartmentId)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Department emp = new Model.Entity.Department();
                    Model.Common.Department DeleteItem = new Model.Common.Department();
                    //Add record
                    {
                        emp = dBContext.Department.FirstOrDefault(asd => asd.DepartmentId == DepartmentId);
                        if (emp != null)
                        {
                            //emp = new Employes();
                            //emp.Id = EmployesModel.Id;
                            dBContext.Department.Remove(emp);
                        }
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        // ------------------------------------ Designation Area --------------------------------------------------

        public List<Model.Common.Designation> GetDesignation()
        {
            List<Model.Common.Designation> Items = new List<Model.Common.Designation>();
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Designation emp;
                    foreach (var it in dBContext.Designation)
                    {
                        emp = new Model.Common.Designation();
                        emp.DesignationId = it.DesignationId;
                        emp.DesignationName = it.DesignationName;
                        Items.Add(emp);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Items;
        }

        public int AddDesignation(Model.Common.Designation DesignationModel)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Designation emp;
                    //Add record
                    if (DesignationModel.DesignationId == 0)
                    {
                        emp = new Model.Entity.Designation();
                        emp.DesignationName = DesignationModel.DesignationName;
                        dBContext.Designation.Add(emp);
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int UpdateDesignation(Model.Common.Designation DesignationModel)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Designation emp = new Model.Entity.Designation();
                    //Add record
                    {
                        emp = dBContext.Designation.FirstOrDefault(asd => asd.DesignationId == DesignationModel.DesignationId);
                        if (emp != null)
                        {
                            //emp = new Employes();
                            emp.DesignationId = DesignationModel.DesignationId;
                            emp.DesignationName = DesignationModel.DesignationName;
                            dBContext.Designation.Update(emp);
                        }
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int DeleteDesignation(int DesignationId)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Designation emp = new Model.Entity.Designation();
                    Model.Common.Designation DeleteItem = new Model.Common.Designation();
                    //Add record
                    {
                        emp = dBContext.Designation.FirstOrDefault(asd => asd.DesignationId == DesignationId);
                        if (emp != null)
                        {
                            //emp = new Employes();
                            //emp.Id = EmployesModel.Id;
                            dBContext.Designation.Remove(emp);
                        }
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        // ------------------------------------ Employes Area --------------------------------------------------

        public List<Model.Common.Employes> GetItems()
        {
            List<Model.Common.Employes> Items = new List<Model.Common.Employes>();
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Employes emp;                
                    foreach (var it in dBContext.Employes)
                    {
                        emp = new Model.Common.Employes();
                        emp.Id = it.Id;
                        emp.Name = it.Name;
                        emp.Email = it.Email;
                        emp.EmployeeCode = it.EmployeeCode;
                        emp.Gender = it.Gender;
                        emp.Department = it.Department;
                        //emp.DepartmentName = it.DepartmentName;
                        emp.Designation = it.Designation;
                        //emp.DesignationName = it.DesignationName;
                        emp.Dob = it.Dob;
                        emp.Salary = it.Salary;
                        Items.Add(emp);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Items;
        }


        public int SaveItem(Model.Common.Employes EmployesModel)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Employes emp;
                    //Add record
                    if (EmployesModel.Id == 0)
                    {
                        emp = new Model.Entity.Employes();
                        emp.Name = EmployesModel.Name;
                        emp.Email = EmployesModel.Email;
                        emp.EmployeeCode = EmployesModel.EmployeeCode;
                        emp.Gender = EmployesModel.Gender;
                        emp.Department = EmployesModel.Department;
                        emp.Designation = EmployesModel.Designation;
                        emp.Dob = EmployesModel.Dob;
                        emp.Salary = EmployesModel.Salary;
                        dBContext.Employes.Add(emp);
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int UpdateItem(Model.Common.Employes EmployesModel)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Employes emp = new Model.Entity.Employes();
                    //Add record
                    {
                        emp = dBContext.Employes.FirstOrDefault(asd => asd.Id == EmployesModel.Id);
                        if (emp != null)
                        {
                            //emp = new Employes();
                            emp.Id = EmployesModel.Id;
                            emp.Name = EmployesModel.Name;
                            emp.Email = EmployesModel.Email;
                            emp.EmployeeCode = EmployesModel.EmployeeCode;
                            emp.Gender = EmployesModel.Gender;
                            emp.Department = EmployesModel.Department;
                            emp.Designation = EmployesModel.Designation;
                            emp.Dob = EmployesModel.Dob;
                            emp.Salary = EmployesModel.Salary;
                            dBContext.Employes.Update(emp);
                        }
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int DeleteItem(int Id)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Entity.Employes emp = new Model.Entity.Employes();
                    Model.Common.Employes DeleteItem = new Model.Common.Employes();
                    //Add record
                    {
                        emp = dBContext.Employes.FirstOrDefault(asd => asd.Id == Id);
                        if (emp != null)
                        {
                            //emp = new Employes();
                            //emp.Id = EmployesModel.Id;
                            dBContext.Employes.Remove(emp);
                        }
                    }
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

    }
}
