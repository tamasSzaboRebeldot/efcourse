using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCourse.Entities;

namespace EfCourse.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee Get(int id);
        Employee Add(Employee employee);
        bool Update(int id, Employee employee);
        void Delete(int id);
    }
}
