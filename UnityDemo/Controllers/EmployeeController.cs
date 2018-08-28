using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityDemo.Models;
using Service.Factory;
using DataAccess.Model;
using AutoMapper;

namespace UnityDemo.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeService objEmployeeService = null;

        public EmployeeController()
        {
            objEmployeeService = ServiceFactory.CreateEmployeeService();
            //Mapper.Initialize(cfg => {
            //    cfg.CreateMap<EmployeeModel, Employee>();
            //});
        }
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> empList = objEmployeeService.GetAllEmployees().ToList();
            //List<EmployeeModel> list = Mapper.Map<List<Employee>, List<EmployeeModel>>(empList);
            //Mapper.AssertConfigurationIsValid();
            //list = (List<EmployeeModel>)objEmployeeService.GetAllEmployees().ToList();
            return View(empList);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            Employee emp = objEmployeeService.GetEmployee(id);
           
            EmployeeModel model = Mapper.Map<EmployeeModel>(emp);
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
