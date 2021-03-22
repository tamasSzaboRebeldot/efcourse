using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCourse.Enums;

namespace EfCourse.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
        public Gender Gender { get; set; }
    }
}
