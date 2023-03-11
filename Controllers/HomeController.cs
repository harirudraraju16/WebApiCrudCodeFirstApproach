using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCrudCodeFirstApproach.Models;

namespace WebApiCrudCodeFirstApproach.Controllers
{
    public class HomeController : ApiController
    {
        EmployeeDBContext EmployeeDB = new EmployeeDBContext();

        [HttpGet]

        public List<Employee> GetEmployees()
        {
            var employees = EmployeeDB.Employees.ToList();
            if (employees != null && employees.Count > 0)
            {
                return employees;
            }
            else
            {
                return new List<Employee>();

            }

        }
        [HttpPost]
        public IHttpActionResult PostData(Employee employee)
        {
            if(employee!=null) 
            {
                EmployeeDB.Employees.Add(employee);
                EmployeeDB.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public string UpdateEmployee(Employee employee) 
        {
            EmployeeDB.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            EmployeeDB.SaveChanges();
            return "Employee Updated in Db";

        }
        [HttpDelete]
        public string DeleteEmployee(int id) 
        {
            Employee employee = EmployeeDB.Employees.Find(id);
            EmployeeDB.Employees.Remove(employee);
            EmployeeDB.SaveChanges();
            return "Employee deleted from DB";
        }

    }
}
