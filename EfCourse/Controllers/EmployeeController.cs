using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCourse.Entities;
using EfCourse.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EfCourse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeRepository.GetAllEmployees();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return _employeeRepository.Get(id);
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            _employeeRepository.Add(value);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Employee value)
        {
            return _employeeRepository.Update(id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeRepository.Delete(id);
        }
    }
}
