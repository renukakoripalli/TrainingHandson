using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Models;
using SampleApp.Repositories;

namespace SampleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeController(IEmployeeRepository rep)
        {
            _repo = rep;
        }
        [HttpPost]
        [Route("AddEmp")]
        public IActionResult Post(Employees obj)
        {
            try
            {
                _repo.AddEmp(obj);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteEmp/{EmpId}")]
        public IActionResult Delete(int EmpId)
        {
            try
            {
                _repo.DeleteEmp(EmpId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }


        }
        [HttpPut]
        [Route("EditProfile")]
        public IActionResult EditProfile(Employees obj)
        {
            try
            {
                _repo.EditProfile(obj);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetProfile/{EmpId}")]
        public IActionResult GetProfile(int EmpId)
        {
            try
            {
                return Ok(_repo.GetById(EmpId));
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetEmp")]
        public IActionResult GetEmployees()
        {
            try
            {
                return Ok(_repo.GetAll());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }



    }

}