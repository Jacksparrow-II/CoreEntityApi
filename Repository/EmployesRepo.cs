using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CoreEntityApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEntityApi.Repository
{

    public class EmployesRepo : EmpRepo
    {
        public List<Models.Common.Department> GetDepartment()
        {
            List<Models.Common.Department> Items = new List<Models.Common.Department>();
            try
            {
                using (var dBContext = new NisargEmployeeContext())
                {
                    Models.Common.Department emp;
                    foreach (var it in dBContext.Department)
                    {
                        emp = new Models.Common.Department();
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

        public List<Models.Common.Designation> GetDesignation()
        {
            List<Models.Common.Designation> Items = new List<Models.Common.Designation>();
            try
            {
                using (var dBContext = new NisargEmployeeContext())
                {
                    Models.Common.Designation emp;
                    foreach (var it in dBContext.Designation)
                    {
                        emp = new Models.Common.Designation();
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

        public List<Models.Common.Employes> GetItems()
        {
            List<Models.Common.Employes> Items = new List<Models.Common.Employes>();
            try
            {
                using (var dBContext = new NisargEmployeeContext())
                {
                    Models.Common.Employes emp;                
                    foreach (var it in dBContext.Employes)
                    {
                        emp = new Models.Common.Employes();
                        emp.Id = it.Id;
                        emp.Name = it.Name;
                        emp.Email = it.Email;
                        emp.EmployeeCode = it.EmployeeCode;
                        emp.Gender = it.Gender;
                        emp.Department = it.Department;
                        emp.Designation = it.Designation;
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


        public int SaveItem(Models.Common.Employes EmployesModel)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new NisargEmployeeContext())
                {
                    Models.Entity.Employes emp;
                    //Add record
                    if (EmployesModel.Id == 0)
                    {
                        emp = new Models.Entity.Employes();
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
                    //else //edit record
                    //{
                    //    emp = dBContext.Employes.FirstOrDefault(x => x.Id == EmployesModel.Id);
                    //    if (emp != null)
                    //    {
                    //        emp = new Employes();
                    //        emp.Id = EmployesModel.Id;
                    //        emp.Name = EmployesModel.Name;
                    //        emp.Email = EmployesModel.Email;
                    //        emp.EmployeeCode = EmployesModel.EmployeeCode;
                    //        emp.Gender = EmployesModel.Gender;
                    //        emp.Department = EmployesModel.Department;
                    //        emp.Designation = EmployesModel.Designation;
                    //        emp.Dob = EmployesModel.Dob;
                    //        emp.Salary = EmployesModel.Salary;
                    //    }
                    //}
                    returnVal = dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int UpdateItem(Models.Common.Employes EmployesModel)
        {
            int returnVal = 0;
            try
            {
                using (var dBContext = new NisargEmployeeContext())
                {
                    Models.Entity.Employes emp = new Models.Entity.Employes();
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
                using (var dBContext = new NisargEmployeeContext())
                {
                    Models.Entity.Employes emp = new Models.Entity.Employes();
                    Models.Common.Employes DeleteItem = new Models.Common.Employes();
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
