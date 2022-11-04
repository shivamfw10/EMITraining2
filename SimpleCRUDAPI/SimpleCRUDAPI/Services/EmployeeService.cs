using SimpleCRUDAPI.Entities;
using SimpleCRUDAPI.Repository.Interfaces;
using SimpleCRUDAPI.Services.Interface;
using System.Collections.Generic;

namespace SimpleCRUDAPI.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }
    }
}
