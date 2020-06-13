﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CoreEntityApi.Model.Common;
using CoreEntityApi.Repository;


namespace CoreEntityApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmpRepo _EmpRepo;
        public EmployeeController(EmpRepo EmployesRepo)
        {
            _EmpRepo = EmployesRepo;
        }

        //************************************** Department *****************************************//

        [HttpGet("GetDepartment")]
        public List<Model.Common.Department> GetDepartment()
        {
            //**** move this below code to dependency injection ***
            return _EmpRepo.GetDepartment();
        }

        [HttpPost("AddDepartment")]
        public int AddDepartment([FromBody] Department Department, string DepartmentName)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.AddDepartment(Department, DepartmentName);
        }

        [HttpPost("UpdateDepartment/{DepartmentId}")]
        public int UpdateDepartment([FromBody] Department Department, int DepartmentId, string DepartmentName)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.UpdateDepartment(Department,DepartmentId, DepartmentName);
        }

        [HttpDelete("DeleteDepartment/{DepartmentId}")]
        public int DeleteDepartment(int DepartmentId)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.DeleteDepartment(DepartmentId);
        }

        [HttpGet("DepartmentById/{DepartmentId}")]
        public Models.Common.Department DepartmentById(int DepartmentId)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.DepartmentById(DepartmentId);
        }

        //************************************** Designation ****************************************//


        [HttpGet("GetDesignation")]
        public List<Model.Common.Designation> GetDesignation()
        {
            //**** move this below code to dependency injection ***
            return _EmpRepo.GetDesignation();
        }

        [HttpPost("AddDesignation")]
        public int AddDesignation([FromBody] Designation Designation, string DesignationName)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.AddDesignation(Designation, DesignationName);
        }

        [HttpPost("UpdateDesignation/{DesignationId}")]
        public int UpdateDesignation([FromBody] Designation Designation, int DesignationId, string DesignationName)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.UpdateDesignation(Designation,DesignationId, DesignationName);
        }

        [HttpDelete("DeleteDesignation/{DesignationId}")]
        public int DeleteDesignation(int DesignationId)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.DeleteDesignation(DesignationId);
        }

         [HttpGet("DesignationById/{DesignationId}")]
        public Models.Common.Designation DesignationById(int DesignationId)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.DesignationById(DesignationId);
        }

        //************************************** Employes ****************************************//


        [HttpGet("GetItems")]
        public List<Model.Common.Employes> GetItems()
        {
            //**** move this below code to dependency injection ***
            return _EmpRepo.GetItems();
        }

        [HttpPost("SaveItem")]
        public int SaveItem([FromBody] Employes Employes, string Name, DateTime Dob)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.SaveItem(Employes, Name, Dob);
        }

        [HttpPost("UpdateItem/{ID}")]
        public int UpdateItem([FromBody] Employes Employes, int Id, string Name, int EmployeeCode, DateTime Dob)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.UpdateItem(Employes, Id, Name, EmployeeCode, Dob);
        }

        [HttpDelete("DeleteItem/{Id}")]
        public int DeleteItem(int Id)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.DeleteItem(Id);
        }

        [HttpGet("EmployeeById/{Id}")]
        public Models.Common.Employes EmployeeById(int Id)
        {
            //**** move this below code to dependency injection ****
            return _EmpRepo.EmployeeById(Id);
        }

    }
}