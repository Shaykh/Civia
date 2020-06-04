using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Civia.Blazor.Server.DataAccess;
using Civia.Blazor.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Civia.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //IManagementAccessLayer _employee;
        private readonly ManagementContext _context;
        /*
        public EmployeeController(IManagementAccessLayer employee)
        {
            _employee = employee;
        }
        */
        public EmployeeController(ManagementContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Index()
        {
            //return await _employee.GetAllEmployees();
            return await _context.Employee.ToListAsync();
        }

        [HttpPost]
        public async Task Create([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employee.Add(employee);

                await _context.SaveChangesAsync();
            }
            //return this._employee.AddEmployee(employee);
        }

        [HttpGet("{id}")]
        public async Task<Employee> Details(int id)
        {
            return await _context.Employee.FindAsync(id);
            //return await _employee.GetEmployeeData(id);
        }

        [HttpPut]
        public async Task Edit([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(employee).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
                //await _employee.UpdateEmployee(employee);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Employee emp = _context.Employee.Find(id);
            _context.Employee.Remove(emp);
            await _context.SaveChangesAsync();
        }
    }
}
