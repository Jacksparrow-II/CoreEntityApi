using CoreEntityApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreEntityApi.Repository
{

    public class EmployesRepo : EmpRepo
    {
        

        #region Department region

        public List<Models.Common.Department> GetDepartment()
        {
            List<Models.Common.Department> Items = new List<Models.Common.Department>();
            try
            {
                using (var dBContext = new workentityContext())
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

        public int AddDepartment(Models.Common.Department DepartmentModel, string DepartmentName)
        {
            List<Models.Common.Department> Items = new List<Models.Common.Department>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workentityContext())
                {
                    Models.Common.Department get;
                    foreach (var it in dBContext.Department)
                    {
                        get = new Models.Common.Department();
                        get.DepartmentId = it.DepartmentId;
                        get.DepartmentName = it.DepartmentName;
                        Items.Add(get);
                    }

                    Models.Entity.Department emp;
                    //Add record
                    if (DepartmentModel.DepartmentId == 0)
                    {
                        emp = new Models.Entity.Department();
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

        public int UpdateDepartment(Models.Common.Department DepartmentModel, int DepartmentId, string DepartmentName)
        {
            List<Models.Common.Department> Items = new List<Models.Common.Department>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workentityContext())
                {
                    Models.Common.Department get;
                    foreach (var it in dBContext.Department)
                    {
                        get = new Models.Common.Department();
                        get.DepartmentId = it.DepartmentId;
                        get.DepartmentName = it.DepartmentName;
                        Items.Add(get);
                    }

                    Models.Entity.Department emp = new Models.Entity.Department();
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
                using (var dBContext = new workentityContext())
                {
                    Models.Entity.Department emp = new Models.Entity.Department();
                    Models.Common.Department DeleteItem = new Models.Common.Department();
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
                using (var dBContext = new workentityContext())
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

#endregion



        #region Designation region 

        public List<Models.Common.Designation> GetDesignation()
        {
            List<Models.Common.Designation> Items = new List<Models.Common.Designation>();
            try
            {
                using (var dBContext = new workentityContext())
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

        public int AddDesignation(Models.Common.Designation DesignationModel, string DesignationName)
        {
            List<Models.Common.Designation> Items = new List<Models.Common.Designation>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workentityContext())
                {
                    Models.Common.Designation get;
                    foreach (var it in dBContext.Designation)
                    {
                        get = new Models.Common.Designation();
                        get.DesignationId = it.DesignationId;
                        get.DesignationName = it.DesignationName;
                        Items.Add(get);
                    }

                    Models.Entity.Designation emp;
                    //Add record
                    if (DesignationModel.DesignationId == 0)
                    {
                        emp = new Models.Entity.Designation();
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

        public int UpdateDesignation(Models.Common.Designation DesignationModel, int DesignationId, string DesignationName)
        {
            List<Models.Common.Designation> Items = new List<Models.Common.Designation>();
            
            int returnVal = 0;
            try
            {
                using (var dBContext = new workentityContext())
                {
                    Models.Common.Designation get;
                    foreach (var it in dBContext.Designation)
                    {
                        get = new Models.Common.Designation();
                        get.DesignationId = it.DesignationId;
                        get.DesignationName = it.DesignationName;
                        Items.Add(get);
                    }

                    Models.Entity.Designation emp = new Models.Entity.Designation();
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
                using (var dBContext = new workentityContext())
                {
                    Models.Entity.Designation emp = new Models.Entity.Designation();
                    Models.Common.Designation DeleteItem = new Models.Common.Designation();
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
                using (var dBContext = new workentityContext())
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

#endregion



        #region Employes region

        public List<Models.Common.Employes> GetItems()
        {
            List<Models.Common.Employes> Items = new List<Models.Common.Employes>();
            try
            {
                using (var dBContext = new workentityContext())
                {
                    Models.Common.Employes emp;                
                    foreach (var it in dBContext.Employes.ToList())
                    {
                        emp = new Models.Common.Employes();
                        emp.Id = it.Id;
                        emp.Name = it.Name;
                        emp.Email = it.Email;
                        emp.EmployeeCode = it.EmployeeCode;
                        emp.Gender = it.Gender;
                        emp.Department = it.Department;
                        //emp.DepartmentName = it.DepartmentName;
                        emp.Designation = it.Designation;
                        //emp.DesignationName = it.DesignationName;
                        //emp.Dob = it.Dob.ToString("dd-MMM-yyyy");
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


        public int SaveItem(Models.Common.Employes EmployesModel, int EmployeeCode, DateTime Dob)
        {
            List<Models.Common.Employes> Items = new List<Models.Common.Employes>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workentityContext())
                {
                    Models.Common.Employes get;
                    foreach (var it in dBContext.Employes)
                    {
                        get = new Models.Common.Employes();
                        get.Id = it.Id;
                        get.Name = it.Name;
                        get.EmployeeCode = it.EmployeeCode;
                        Items.Add(get);
                    }

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
                        //emp.Dob = Convert.ToDateTime(EmployesModel.Dob);
                        emp.Dob = EmployesModel.Dob;
                        emp.Salary = EmployesModel.Salary;
                        dBContext.Employes.Add(emp);
                        EmployeeCode = emp.EmployeeCode;
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


                    bool Employeexist = Items.Any(asd => asd.EmployeeCode == EmployeeCode);
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

        public int UpdateItem(Models.Common.Employes EmployesModel, int Id, string Name, int EmployeeCode, DateTime Dob)
        {
            List<Models.Common.Employes> Items = new List<Models.Common.Employes>();

            int returnVal = 0;
            try
            {
                using (var dBContext = new workentityContext())
                {
                    Models.Common.Employes get;
                    foreach (var it in dBContext.Employes)
                    {
                        get = new Models.Common.Employes();
                        get.Id = it.Id;
                        get.Name = it.Name;
                        get.EmployeeCode = it.EmployeeCode;
                        Items.Add(get);
                    }

                    Models.Entity.Employes emp = new Models.Entity.Employes();
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
                        //emp.Dob = Convert.ToDateTime(EmployesModel.Dob);
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
                    else if ( Employeexist == true && Employesame == true)
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

                    //bool EmployeName = Items.Any(asd => asd.Name == Name); 
                    //bool EmployeNameexist = Items.Any(asd => (asd.Id == Id) && (asd.Name == Name));
                    //bool Employesame = Items.Any(asd => asd.EmployeeCode == EmployeeCode);
                    //bool Employeexist = Items.Any(asd => (asd.Id == Id) && (asd.EmployeeCode == EmployeeCode));
                    //if (age < 21)
                    //{
                    //    returnVal = -2;
                    //}
                    //else if (Employeexist == true && Employesame == true || EmployeNameexist == true && EmployeName == true)
                    //{
                    //    returnVal = dBContext.SaveChanges();
                    //}
                    //else if (EmployeName == true)
                    //{
                    //    returnVal = -3;
                    //}
                    //else if (Employesame == true)
                    //{
                    //    returnVal = -1;
                    //}
                    //else
                    //{
                    //    returnVal = dBContext.SaveChanges();
                    //}
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
                using (var dBContext = new workentityContext())
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

        public Models.Common.Employes EmployeeById(int Id)
        {
            Models.Common.Employes Employe = new Models.Common.Employes();
            try
            {
                using (var dBContext = new workentityContext())
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
                        //Employe.Dob = emp.Dob.ToString();
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

        #endregion



        #region UserDetail



        #endregion

    }
}
