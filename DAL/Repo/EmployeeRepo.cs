using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class EmployeeRepo
    {
        static DataContext context;


        public EmployeeRepo()
        {
            context = new DataContext();
        }

        public static List<Employee> Get()
        {
            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= 10; i++)
            {
                employees.Add(new Employee() { Id = i, Name = "E-" + i});
            }

            return context.Employees.ToList();
            //return employees;
        }

        public static Employee Get(int id)
        {
            return context.Employees.Find(id);
        }

        public static bool Create(Employee employee)
        {
            context.Employees.Add(employee);

            return context.SaveChanges() > 0;
        }

        public static bool Update(Employee employee)
        {
            var employeeExists = Get(employee.Id);

            context.Entry(employeeExists).CurrentValues.SetValues(employee);

            return context.SaveChanges() > 0;
        }

        public static bool Delete(int id)
        {
            var employeeExists = Get(id);

            context.Employees.Remove(employeeExists);

            return context.SaveChanges() > 0;
        }
    }
}
