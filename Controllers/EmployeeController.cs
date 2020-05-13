using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CoreEntityApi.Models.Common;
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

        [HttpGet("GetDepartment")]
        public List<Models.Common.Department> GetDepartment()
        {
            //**** move this below code to dependency injection ***
            //ItemRepo itemrepo = new ItemRepo();
            //**************************************************
            return _EmpRepo.GetDepartment();
        }

        [HttpGet("GetDesignation")]
        public List<Models.Common.Designation> GetDesignation()
        {
            //**** move this below code to dependency injection ***
            //ItemRepo itemrepo = new ItemRepo();
            //**************************************************
            return _EmpRepo.GetDesignation();
        }

        [HttpGet("GetItems")]
        public List<Models.Common.Employes> GetItems()
        {
            //**** move this below code to dependency injection ***
            //ItemRepo itemrepo = new ItemRepo();
            //**************************************************
            return _EmpRepo.GetItems();
        }

        [HttpPost("SaveItem")]
        public int SaveItem([FromBody] Employes Employes)
        {
            //**** move this below code to dependency injection ****
            //ItemRepo itemrepo = new ItemRepo();
            //*************************************************
            return _EmpRepo.SaveItem(Employes);
        }

        [HttpPost("UpdateItem")]
        public int UpdateItem([FromBody] Employes Employes)
        {
            //**** move this below code to dependency injection ****
            //ItemRepo itemrepo = new ItemRepo();
            //*************************************************
            return _EmpRepo.UpdateItem(Employes);
        }

        [HttpDelete("DeleteItem/{Id}")]
        public int DeleteItem(int Id)
        {
            //**** move this below code to dependency injection ****
            //ItemRepo itemrepo = new ItemRepo();
            //*************************************************
            return _EmpRepo.DeleteItem(Id);
        }

    }
}