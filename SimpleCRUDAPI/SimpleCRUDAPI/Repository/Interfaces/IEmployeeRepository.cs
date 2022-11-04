using SimpleCRUDAPI.Entities;
using System.Collections.Generic;

namespace SimpleCRUDAPI.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
}
