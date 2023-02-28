﻿using WebAPI.Models;

namespace WebAPI.Infra.Repository
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        List<Employee> GetEmployees();
    }
}
