using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interface;
using DataAccess.Model;

namespace DataAccess.Dao
{
    public class EmployeeDao : IEmployeeDao
    {
        //private static EmployeeDao instance;

        //private EmployeeDao() { }

        //public static EmployeeDao GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new EmployeeDao();
        //    }
        //    return instance;
        //}

        public Employee AddEmployee(Employee employee)
        {
            using (EmployeeEntities en = new EmployeeEntities())
            {
                en.Employees.Add(employee);
                en.SaveChanges();

                return employee;
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            using (EmployeeEntities en = new EmployeeEntities())
            {
                return en.Employees.ToList();
            }
        }

        public Employee GetEmployee(int id)
        {
            using (EmployeeEntities en = new EmployeeEntities())
            {
                return en.Employees.Where(e=>e.ID==id).FirstOrDefault();
            }
        }
    }
}
