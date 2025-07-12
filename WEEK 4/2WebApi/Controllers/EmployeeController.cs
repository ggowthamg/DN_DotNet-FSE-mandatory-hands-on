using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Models;
using System.Collections.Generic;
using System;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            // Simulate an exception to trigger the custom exception filter
            throw new Exception("This is a test exception for logging.");

            // If you want to return data normally, comment the above line and uncomment below:
            /*
            var employees = new List<string> {
                "John", "Jane", "Smith"
            };
            return Ok(employees);
            */
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            return Created("", $"Employee '{employee.Name}' with Role '{employee.Role}' added successfully.");
        }
    }
}
