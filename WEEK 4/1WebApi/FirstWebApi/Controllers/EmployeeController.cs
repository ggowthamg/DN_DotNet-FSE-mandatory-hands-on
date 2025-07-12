using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FirstWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApi.Controllers
{
    [Authorize(Roles = "Admin")] // 🔒 JWT Role-Based Authorization
    [ApiController]
    [Route("api/emp")]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        // In-memory employee list
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John", Role = "Developer" },
            new Employee { Id = 2, Name = "Jane", Role = "Tester" },
            new Employee { Id = 3, Name = "Smith", Role = "Manager" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Created("", $"Employee '{employee.Name}' with Role '{employee.Role}' added successfully.");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existing = employees.FirstOrDefault(e => e.Id == id);
            if (existing == null)
                return BadRequest("Invalid employee id");

            existing.Name = updatedEmp.Name;
            existing.Role = updatedEmp.Role;
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return BadRequest("Employee not found");

            employees.Remove(employee);
            return Ok($"Employee with id {id} has been deleted.");
        }
    }
}
