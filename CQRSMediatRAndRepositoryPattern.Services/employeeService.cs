using CQRSMediatRAndRepositoryPattern.Models;
using System;
using System.Collections.Generic;

namespace CQRSMediatRAndRepositoryPattern.Services
{
    public class employeeService : IemployeeService
    {
        private List<Employee> _employees = new()
        {
            new Employee() { Id = 1, FirstName = "rahim", LastName = "hasan" },
            new Employee() { Id = 2, FirstName = "kahim", LastName = "hasan" },
        };
        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public Employee AddEmployee(Employee employee)
        {
            _employees.Add(employee);
            return employee;
        }
    }

    public interface IemployeeService
    {
        Employee AddEmployee(Employee employee);
        List<Employee> GetEmployees();
    }
}
