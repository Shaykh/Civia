using Civia.Blazor.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Civia.Blazor.Server.DataAccess
{
    public interface IManagementAccessLayer
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task<Employee> GetEmployeeData(long id);
        Task DeleteEmployee(long id);
    }
}
