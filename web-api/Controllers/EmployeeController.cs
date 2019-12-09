using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api.Repositories;
using web_api.Models;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployeeList() {
            var result = employeeRepository.GetEmployeeList();
            return result;
        }

        [HttpGet("{empId}")]
        public IEnumerable<Employee> GetEmployeeDetailsById(int empId) {
            var result = employeeRepository.GetEmployeeDetails(empId);
            return result;
        }
    }
}
