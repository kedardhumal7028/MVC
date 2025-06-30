using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace MyApp.Db.DbOperations
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmplyeeModel model)
        {
            using(var context = new EmployeeDBEntities())
            {           
                Employee emp = new Employee()
                {
                    First_Name = model.FirstName,
                    Last_Name = model.LastName,
                    Email = model.Email,
                    Code = model.Code
                };

                context.Employee.Add(emp);
                context.SaveChanges(); 

                return emp.Id;
            }
        }
    }
}
