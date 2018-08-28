using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDemo.Models
{
    public class EmployeeModel : Employee
    {
        private int _DepartmentId;
        public int DepartmentId {

            get
            {
                return this._DepartmentId;
            }
            set
            {
                this._DepartmentId = value;
            }
        }
    }
    public class EmployeeModelMetaData 
    {

    }
}