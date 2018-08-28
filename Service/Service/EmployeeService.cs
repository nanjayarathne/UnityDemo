using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Dao;
using DataAccess.Model;
using Service.Interface;
using DataAccess.Interface;
using Service.Factory;

namespace Service.Service
{
   
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeDao employeeDao;
        public EmployeeService()
        {
            //this.employeeDao = ServiceFactory.CreateEmployeeDao();
            this.employeeDao = new EmployeeDao();
        }

        public Employee AddEmployee(Employee employee)
        {
            return employeeDao.AddEmployee(employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeDao.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return employeeDao.GetEmployee(id);
        }
    }
}
