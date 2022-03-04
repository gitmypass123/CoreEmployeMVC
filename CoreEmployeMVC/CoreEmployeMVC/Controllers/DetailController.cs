using CoreEmployeMVC.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmployeMVC.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult AllworksHours()
        {


            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Detail> dt = _dbConn.Query<Detail>("dbo.Depantment&Name&Activity&AllWork", commandType: CommandType.StoredProcedure).ToList();
                //return results.ToList();
                return View(dt);
            }
        }


        public ActionResult TotalWorkHr()
        {

            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Detail> dt = _dbConn.Query<Detail>("dbo.totalWorkHr", commandType: CommandType.StoredProcedure).ToList();
                //return results.ToList();
                return View(dt);
            }

        }




        public ActionResult AllOTHour()
        {


            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Detail> dt = _dbConn.Query<Detail>("dbo.Depantment&Name&Activity&AllOT", commandType: CommandType.StoredProcedure).ToList();
                //return results.ToList();
                return View(dt);
            }
        }


        public ActionResult TotalOTHr()
        {


            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Detail> dt = _dbConn.Query<Detail>("dbo.TotalOTHr", commandType: CommandType.StoredProcedure).ToList();
                //return results.ToList();
                return View(dt);
            }

        }


        public ActionResult FinalTotal()
        {

            using (IDbConnection _dbConn = new SqlConnection("Data Source = PCW; Database = EmployeManagement; User ID = sa; Password = 123"))
            {
                //using dapper (Entities Frame wok ekee use karranna puluwan wannee eyata aithi sql ,table only ,but apata eeeta amatharawa ee table walata adala sql query tikak use karranna ooni unama thamai dapper ORM eka use karaanee )
                List<Detail> dt = _dbConn.Query<Detail>("dbo.finalTotal", commandType: CommandType.StoredProcedure).ToList();
                //return results.ToList();
                return View(dt);
            }

        }
    }
}
