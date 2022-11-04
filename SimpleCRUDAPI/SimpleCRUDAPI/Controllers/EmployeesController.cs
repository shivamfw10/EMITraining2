using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCRUDAPI.Entities;
using SimpleCRUDAPI.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [ProducesResponseType(StatusCodes.Status400BadRequest)] //Bad Request
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Employee>))]
        [HttpGet]

        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            var result = _employeeService.GetAllEmployees().ToList();
            if (result == null)
            {
                return NotFound();
            }

            else
            {
                return Ok(result);
            }
        }
        [HttpGet("{id:int}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var result = _employeeService.GetEmployeeById(id);
            if (result == null)
            {
                return NotFound();
            }

            else
            {
                return Ok(result);
            }
        }
    }
}
