using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using Service.Interface;
using DataAccess.Interface;
using DataAccess.Dao;
using Service.Factory;
using DataAccess.Factory;

namespace Service.Service
{
    class EmployeeFakeService : IEmployeeService
    {
        private IEmployeeDao employeeDao;
        public EmployeeFakeService()
        {
            this.employeeDao = DaoFactory.CreateEmployeeDao();
            //this.employeeDao = new EmployeeDao();
        }

        public Employee AddEmployee(Employee employee)
        {
            return employeeDao.AddEmployee(employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeDao.GetAllEmployees();
            //return new List<Employee>() { new Employee() { ID = 1, FirstName = "na", LastName = "laka" } };
        }

        public Employee GetEmployee(int id)
        {
            return employeeDao.GetEmployee(id);
        }
    }
}
