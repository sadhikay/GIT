using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public static string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key.ToLower()].ToString();
        }

        public ActionResult Index()
        {
            return View("About");
        }

        public ActionResult About()
        {
           return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult GetData(string name)
        {
            string ConnectionString = GetConnectionString("myDB");

            List<Data> list = new List<Data>();
            SqlConnection conn;
            SqlDataReader rdr;
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts$ where Name =" + name, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    list.Add(new Data()
                    {
                        //Name = rdr["Name"].ToString(),
                        //Balance = rdr["Balance"].ToString(),
                        //Number = rdr["Balance"].ToString(),
                        Name = "hello",
                        Balance = 555.33,
                        Number = 5662,
                    });
                }
                rdr.Close();


            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}