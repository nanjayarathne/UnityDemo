using DataAccess.Dao;
using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DataAccess.Factory
{
    public class DaoFactory
    {
        private static IUnityContainer mObjUnity = null;
 
        public static IEmployeeDao CreateEmployeeDao()
        {
            if (mObjUnity == null)
            {
                mObjUnity = new UnityContainer();
                mObjUnity.RegisterType<IEmployeeDao, EmployeeDao>("EmployeeDao");
            }
            return mObjUnity.Resolve<IEmployeeDao>("EmployeeDao");
        }
    }
}
