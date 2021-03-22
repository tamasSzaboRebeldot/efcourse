using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCourse.Data.IMData;
using EfCourse.Entities;
using EfCourse.Interfaces;

namespace EfCourse.Repository.IMRepository
{
    public class IMEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees;
        public IMEmployeeRepository()
        {
            _employees = IMEmployeeList.Employees;
        }
        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee Get(int id)
        {
            return _employees.FirstOrDefault(s => s.Id == id);
        }

        public Employee Add(Employee employee)
        {
           _employees.Add(employee);
           return employee;
        }

        public bool Update(int id, Employee updEmployee)
        {
            var employee = _employees.FirstOrDefault(s => s.Id == id);
            if (employee == null)
                return false;
            employee.Name = updEmployee.Name;
            employee.BirthDate = updEmployee.BirthDate;
            employee.StartDate = updEmployee.StartDate;
            employee.Gender = updEmployee.Gender;
            employee.IsActive = updEmployee.IsActive;
            return true;
        }

        public void Delete(int id)
        {
            var employee = _employees.FirstOrDefault(s => s.Id == id);
            if(employee == null)
                return;
            _employees.Remove(employee);
        }
    }
}
