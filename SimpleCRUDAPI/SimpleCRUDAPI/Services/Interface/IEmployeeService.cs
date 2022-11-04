using SimpleCRUDAPI.Entities;
using System.Collections.Generic;

namespace SimpleCRUDAPI.Services.Interface
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
}
