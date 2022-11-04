using SimpleCRUDAPI.Entities;
using SimpleCRUDAPI.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCRUDAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        IEnumerable<Employee> empList = new List<Employee>
        {
            new Employee{Id=1, FirstName="Kirtesh", LastName="Shah", Address="Vadodara" },
            new Employee{Id=2, FirstName="Nitya", LastName="Shah", Address="Vadodara" },
            new Employee{Id=3, FirstName="Dilip", LastName="Shah", Address="Vadodara" },
            new Employee{Id=4, FirstName="Atul", LastName="Shah", Address="Vadodara" },
            new Employee{Id=5, FirstName="Swati", LastName="Shah", Address="Vadodara" },
            new Employee{Id=6, FirstName="Rashmi", LastName="Shah", Address="Vadodara" },
        };
        public List<Employee> GetAllEmployees()
        {
            return empList.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return empList.FirstOrDefault(x => x.Id == id);
        }
    }
}
