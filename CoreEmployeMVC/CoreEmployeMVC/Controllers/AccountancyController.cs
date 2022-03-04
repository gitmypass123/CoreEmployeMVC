using CoreEmployeMVC.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmployeMVC.Controllers
{
    public class AccountancyController : Controller
    {
        private readonly ConnectionStringClass _con;

        
        public AccountancyController(ConnectionStringClass con)
        {
            _con = con;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ADD()
        {

            string[] WeekDay = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun", "Mon ", "Tue ", "Wed ", "Thur ", "Fri ", "Sat ", "Sun ", "Mon  " };
            ViewData["WeekDay"] = WeekDay;

            string[] WeekDay2 = { "Tue", "Wed", "Thur", "Fri", "Sat", "Sun", "Mon", "Tue ", "Wed ", "Thur ", "Fri ", "Sat ", "Sun ", "Mon ", "Tue  ", "Wed  " };
            ViewData["WeekDay2List"] = WeekDay2;




            string[] month = { "-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-10", "-11", "-12", "-13", "-14", "-15" };
            ViewData["Month"] = month;

            string[] month2 = { "-16", "-17", "-18", "-19", "-20", "-21", "-22", "23", "-24", "-25", "-26", "-27", "-28", "-29", "-30", "-31" };
            ViewData["Month2"] = month2;



            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Deprtmet> dt = _dbConn.Query<Deprtmet>("dbo.departmetName", commandType: CommandType.StoredProcedure).ToList();

                ViewBag.departmetName = new SelectList(dt, "projectID", "DepartmentName");

            }


            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Deprtmet> dt = _dbConn.Query<Deprtmet>("dbo.ProjectName", commandType: CommandType.StoredProcedure).ToList();

                ViewBag.CategoriesList = new SelectList(dt, "projectID", "ProjectName");

            }



            return View();



        }


        [HttpPost]
        public IActionResult ADD(ProjectClass projectClass)
        {
            if (ModelState.IsValid)
            {
                _con.Add(projectClass);
                _con.SaveChanges();
                ModelState.Clear();
            }


            string[] WeekDay = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun", "Mon ", "Tue ", "Wed ", "Thur ", "Fri ", "Sat ", "Sun ", "Mon  " };
            ViewData["WeekDay"] = WeekDay;

            string[] WeekDay2 = { "Tue", "Wed", "Thur", "Fri", "Sat", "Sun", "Mon", "Tue ", "Wed ", "Thur ", "Fri ", "Sat ", "Sun ", "Mon ", "Tue  ", "Wed  " };
            ViewData["WeekDay2List"] = WeekDay2;












            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Deprtmet> dt = _dbConn.Query<Deprtmet>("dbo.departmetName", commandType: CommandType.StoredProcedure).ToList();

                ViewBag.departmetName = new SelectList(dt, "projectID", "DepartmentName");

            }

            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Deprtmet> dt = _dbConn.Query<Deprtmet>("dbo.ProjectName", commandType: CommandType.StoredProcedure).ToList();

                ViewBag.CategoriesList = new SelectList(dt, "projectID", "ProjectName");

            }




            return View(new ProjectClass());
        }

    }
}
