using CoreEmployeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmployeMVC.Controllers
{
    public class EmployeController : Controller
    {
        private readonly ConnectionStringClass _con;

        public EmployeController(ConnectionStringClass con)
        {
            _con = con;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() {

            return View();
        }

        
        [HttpPost]
        public IActionResult Create(EmployeClass employeClass)
        {
            if (ModelState.IsValid) {
                _con.Add(employeClass);
                _con.SaveChanges();
                ModelState.Clear();
            }
            return View(new EmployeClass());
        }


        public ActionResult EmployeList()
        {

            var result = _con.Employe.ToList();


            return View(result);
        }
    }
}
