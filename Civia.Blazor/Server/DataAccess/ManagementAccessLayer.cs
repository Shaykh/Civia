using Civia.Blazor.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Civia.Blazor.Server.DataAccess
{
    public class ManagementAccessLayer : IManagementAccessLayer
    {
        private ManagementContext _context;

        public ManagementAccessLayer(ManagementContext context)
        {
            _context = context;
        }

        public async Task AddEmployee(Employee employee)
        {
            try
            {
                _context.Employee.Add(employee);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task DeleteEmployee(long id)
        {
            try
            {
                Employee emp = _context.Employee.Find(id);
                _context.Employee.Remove(emp);
               await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            try
            {
                return await _context.Employee.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Employee> GetEmployeeData(long id)
        {
            try
            {
                return await _context.Employee.FindAsync(id);
            }
            catch
            {
                throw;
            }
        }

        public async Task UpdateEmployee(Employee employee)
        {
            try
            {
                _context.Entry(employee).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
