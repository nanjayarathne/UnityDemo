using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Service.Interface;
using Service.Service;
using DataAccess.Interface;
using DataAccess.Dao;

namespace Service.Factory
{
    public class ServiceFactory
    {
        private static IUnityContainer mObjUnity = null;

        /// <summary>
        /// This method is used for genarete Customer service dynamicaly
        /// </summary>
        /// <param name="mType"></param>
        /// <returns></returns>
        public static IEmployeeService CreateEmployeeService()
        {
            if (mObjUnity == null)
            {
                mObjUnity = new UnityContainer();
                mObjUnity.RegisterType<IEmployeeService, EmployeeFakeService>("EmployeeFakeService");
            }
            return mObjUnity.Resolve<IEmployeeService>("EmployeeFakeService");
        }

    }
}

