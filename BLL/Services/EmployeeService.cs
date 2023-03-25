using DAL.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static object Get() {
            return EmployeeRepo.Get();
        }

        public static bool Create(Employee employee)
        {
            return EmployeeRepo.Create(employee);
        }

        public static bool Update(Employee employee)
        {
            return EmployeeRepo.Update(employee);
        }

        public static bool Delete(int id)
        {
            return EmployeeRepo.Delete(id);
        }
    }
}
