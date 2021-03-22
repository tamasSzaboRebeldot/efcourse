using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCourse.Entities;
using EfCourse.Enums;

namespace EfCourse.Data.IMData
{
    public static class IMEmployeeList
    {
        public static List<Employee> Employees =>
            new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    BirthDate = new DateTime(1990, 02, 28),
                    IsActive = true,
                    Name = "Luke Cage",
                    StartDate = new DateTime(2016, 03, 02),
                    Gender = Gender.Male
                },
                new Employee()
                {
                    Id = 2,
                    BirthDate = new DateTime(1995, 06, 14),
                    IsActive = true,
                    Name = "Jessica Jones",
                    StartDate = new DateTime(2015, 09, 12),
                    Gender = Gender.Female
                },
                new Employee()
                {
                    Id = 3,
                    BirthDate = new DateTime(1979, 06, 28),
                    IsActive = true,
                    Name = "Matt Murdock",
                    StartDate = new DateTime(2020, 03, 19),
                    Gender = Gender.Male
                },
                new Employee()
                {
                    Id = 4,
                    BirthDate = new DateTime(1985, 10, 16),
                    IsActive = true,
                    Name = "Danny Rand",
                    StartDate = new DateTime(2008, 07, 07),
                    Gender = Gender.Male
                },
                new Employee()
                {
                    Id = 5,
                    BirthDate = new DateTime(1994, 04, 23),
                    IsActive = false,
                    Name = "Frank Castle",
                    StartDate = new DateTime(2018, 04, 12),
                    Gender = Gender.Male
                }
            };
    }
}
