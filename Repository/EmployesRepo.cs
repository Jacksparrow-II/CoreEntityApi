using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CoreEntityApi.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreEntityApi.Models.Entity;

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

        public int AddDepartment(Model.Common.Department DepartmentModel, string DepartmentName)
        {
            List<Model.Common.Department> Items = new List<Model.Common.Department>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Department get;
                    foreach (var it in dBContext.Department)
                    {
                        get = new Model.Common.Department();
                        get.DepartmentId = it.DepartmentId;
                        get.DepartmentName = it.DepartmentName;
                        Items.Add(get);
                    }

                    Model.Entity.Department emp;
                    //Add record
                    if (DepartmentModel.DepartmentId == 0)
                    {
                        emp = new Model.Entity.Department();
                        emp.DepartmentName = DepartmentModel.DepartmentName;
                        dBContext.Department.Add(emp);
                        DepartmentName = emp.DepartmentName;
                    }

                    bool departmentexist = Items.Any(asd => asd.DepartmentName == DepartmentName);
                    if (departmentexist == true)
                    {
                        returnVal = -1;
                    }
                    else
                    {
                        returnVal = dBContext.SaveChanges();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int UpdateDepartment(Model.Common.Department DepartmentModel, int DepartmentId, string DepartmentName)
        {
            List<Model.Common.Department> Items = new List<Model.Common.Department>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Department get;
                    foreach (var it in dBContext.Department)
                    {
                        get = new Model.Common.Department();
                        get.DepartmentId = it.DepartmentId;
                        get.DepartmentName = it.DepartmentName;
                        Items.Add(get);
                    }

                    Model.Entity.Department emp = new Model.Entity.Department();
                    //Add record
                    
                        emp = dBContext.Department.FirstOrDefault(asd => asd.DepartmentId == DepartmentModel.DepartmentId);
                        if (emp != null)
                        {
                            //emp = new Employes();
                            emp.DepartmentId = DepartmentModel.DepartmentId;
                            emp.DepartmentName = DepartmentModel.DepartmentName;
                            dBContext.Department.Update(emp);
                            DepartmentId = emp.DepartmentId;
                            DepartmentName = emp.DepartmentName;
                        }

                    bool departmentsame = Items.Any(asd => asd.DepartmentName == DepartmentName);
                    bool departmentexist = Items.Any(asd => (asd.DepartmentId == DepartmentId) && (asd.DepartmentName == DepartmentName));
                    if (departmentexist == true)
                    {
                        returnVal = dBContext.SaveChanges();
                    }
                    else if (departmentsame == true)
                    {
                        returnVal = -1;
                    }
                    else
                    {
                        returnVal = dBContext.SaveChanges();
                    }
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

        public Models.Common.Department DepartmentById(int DepartmentId)
        {
            Models.Common.Department departments = new Models.Common.Department();
            try
            {
                using (var dBContext = new workContext())
                {
                    var dep = dBContext.Department.Where(x => x.DepartmentId == DepartmentId).SingleOrDefault();

                    if (dep != null)
                    {
                        departments.DepartmentId = dep.DepartmentId;
                        departments.DepartmentName = dep.DepartmentName;

                    }
                    return departments;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

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

        public int AddDesignation(Model.Common.Designation DesignationModel, string DesignationName)
        {
            List<Model.Common.Designation> Items = new List<Model.Common.Designation>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Designation get;
                    foreach (var it in dBContext.Designation)
                    {
                        get = new Model.Common.Designation();
                        get.DesignationId = it.DesignationId;
                        get.DesignationName = it.DesignationName;
                        Items.Add(get);
                    }

                    Model.Entity.Designation emp;
                    //Add record
                    if (DesignationModel.DesignationId == 0)
                    {
                        emp = new Model.Entity.Designation();
                        emp.DesignationName = DesignationModel.DesignationName;
                        dBContext.Designation.Add(emp);
                        DesignationName = emp.DesignationName;
                    }

                    bool Designationexist = Items.Any(asd => asd.DesignationName == DesignationName);
                    if (Designationexist == true)
                    {
                        returnVal = -1;
                    }
                    else
                    {
                        returnVal = dBContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int UpdateDesignation(Model.Common.Designation DesignationModel, int DesignationId, string DesignationName)
        {
            List<Model.Common.Designation> Items = new List<Model.Common.Designation>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Designation get;
                    foreach (var it in dBContext.Designation)
                    {
                        get = new Model.Common.Designation();
                        get.DesignationId = it.DesignationId;
                        get.DesignationName = it.DesignationName;
                        Items.Add(get);
                    }

                    Model.Entity.Designation emp = new Model.Entity.Designation();
                    //Add record
                    
                        emp = dBContext.Designation.FirstOrDefault(asd => asd.DesignationId == DesignationModel.DesignationId);
                        if (emp != null)
                        {
                            //emp = new Employes();
                            emp.DesignationId = DesignationModel.DesignationId;
                            emp.DesignationName = DesignationModel.DesignationName;
                            dBContext.Designation.Update(emp);
                            DesignationId = emp.DesignationId;
                            DesignationName = emp.DesignationName;
                        }

                    bool Designationsame = Items.Any(asd => asd.DesignationName == DesignationName);
                    bool Designationexist = Items.Any(asd => (asd.DesignationId == DesignationId) && (asd.DesignationName == DesignationName));
                    if (Designationexist == true)
                    {
                        returnVal = dBContext.SaveChanges();
                    }
                    else if (Designationsame == true)
                    {
                        returnVal = -1;
                    }
                    else
                    {
                        returnVal = dBContext.SaveChanges();
                    }
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

        public Models.Common.Designation DesignationById(int DesignationId)
        {
            Models.Common.Designation Designations = new Models.Common.Designation();
            try
            {
                using (var dBContext = new workContext())
                {
                    var Des = dBContext.Designation.Where(x => x.DesignationId == DesignationId).SingleOrDefault();

                    if (Des != null)
                    {
                        Designations.DesignationId = Des.DesignationId;
                        Designations.DesignationName = Des.DesignationName;

                    }
                    return Designations;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

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
                    foreach (var it in dBContext.Employes.ToList())
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

                        if (emp.Designation != null)
                        {
                            var des = dBContext.Designation.FirstOrDefault(x => x.DesignationId == emp.Designation);
                            if(des != null)
                            {
                                emp.DesignationName = des.DesignationName;
                            }
                            
                        }

                        if (emp.Department != null)
                        {
                            var dep = dBContext.Department.FirstOrDefault(x => x.DepartmentId == emp.Department);
                            if (dep != null)
                            {
                                emp.DepartmentName = dep.DepartmentName;
                            }
                            
                        }

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


        public int SaveItem(Model.Common.Employes EmployesModel, string Name, DateTime Dob)
        {
            List<Model.Common.Employes> Items = new List<Model.Common.Employes>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Employes get;
                    foreach (var it in dBContext.Employes)
                    {
                        get = new Model.Common.Employes();
                        get.Id = it.Id;
                        get.Name = it.Name;
                        Items.Add(get);
                    }

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
                        Name = emp.Name;
                        Dob = Convert.ToDateTime(EmployesModel.Dob);
                    }

                    //DateTime Now = DateTime.Now;
                    //int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
                    //DateTime PastYearDate = Dob.AddYears(Years);
                    //int Months = 0;
                    //for (int i = 1; i <= 12; i++)
                    //{
                    //    if (PastYearDate.AddMonths(i) == Now)
                    //    {
                    //        Months = i;
                    //        break;
                    //    }
                    //    else if (PastYearDate.AddMonths(i) > Now)
                    //    {
                    //        Months = i - 1;
                    //        break;
                    //    }
                    //}

                    DateTime Now = DateTime.Now;
                    int age = 0;
                    age = DateTime.Now.Year - Dob.Year;
                    if (DateTime.Now.DayOfYear < Dob.DayOfYear + 1)
                    {
                        age = age - 1;
                    }


                    bool Employeexist = Items.Any(asd => asd.Name == Name);
                    if (Employeexist == true)
                    {
                        returnVal = -1;
                    }
                    else if (age < 21)
                    {
                        returnVal = -2;
                    }
                    else
                    {
                        returnVal = dBContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return returnVal;
        }

        public int UpdateItem(Model.Common.Employes EmployesModel, int Id, string Name, int EmployeeCode, DateTime Dob)
        {
            List<Model.Common.Employes> Items = new List<Model.Common.Employes>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workContext())
                {
                    Model.Common.Employes get;
                    foreach (var it in dBContext.Employes)
                    {
                        get = new Model.Common.Employes();
                        get.Id = it.Id;
                        get.Name = it.Name;
                        get.EmployeeCode = it.EmployeeCode;
                        Items.Add(get);
                    }

                    Model.Entity.Employes emp = new Model.Entity.Employes();
                    //Update record
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
                            Id = emp.Id;
                            EmployeeCode = emp.EmployeeCode;
                            Name = emp.Name;
                            Dob = Convert.ToDateTime(EmployesModel.Dob);
                        }


                    DateTime Now = DateTime.Now;
                    int age = 0;
                    age = DateTime.Now.Year - Dob.Year;
                    if (DateTime.Now.DayOfYear < Dob.DayOfYear + 1)
                    {
                        age = age - 1;
                    }

                    bool Employesame = Items.Any(asd => asd.EmployeeCode == EmployeeCode);
                    bool Employeexist = Items.Any(asd => (asd.Id == Id) && (asd.EmployeeCode == EmployeeCode));
                    if (age < 21)
                    {
                        returnVal = -2;
                    }
                    else if (Employeexist == true && Employesame == true)
                    {
                        returnVal = dBContext.SaveChanges();
                    }
                    else if(Employesame == true)
                    {
                        returnVal = -1;
                    }
                    else
                    {
                        returnVal = dBContext.SaveChanges();
                    }

                    
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

        public Models.Common.Employes EmployeeById(int Id)
        {
            Models.Common.Employes Employe = new Models.Common.Employes();
            try
            {
                using (var dBContext = new workContext())
                {
                    var emp = dBContext.Employes.Where(x => x.Id == Id).SingleOrDefault();

                    if (emp != null)
                    {
                        Employe.Id = emp.Id;
                        Employe.Name = emp.Name;
                        Employe.Email = emp.Email;
                        Employe.EmployeeCode = emp.EmployeeCode;
                        Employe.Gender = emp.Gender;
                        Employe.Department = emp.Department;
                        Employe.Designation = emp.Designation;
                        Employe.Dob = emp.Dob;
                        Employe.Salary = emp.Salary;

                    }
                    return Employe;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

    }
}
