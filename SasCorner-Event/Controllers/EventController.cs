using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using SasCorner_Event.Models;

namespace SasCorner_Event.Controllers
{
	public class EventController : Controller
	{
		
        MySqlConnection conn;
        string connstring;
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /<controller>/
        public IActionResult Calendar()
        {

            connstring = "SERVER= 92.204.221.160;PORT=3306;DATABASE=crmcorner;user=yaren;PASSWORD=yagmuryaren123;Charset=utf8mb4";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
            }
            catch (MySqlException e)
            {

            }
            string query = "Select *,DATE_FORMAT(Date, '%d/%m/%y') as Date from Calendar";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader mySqlData = cmd.ExecuteReader();
            while (mySqlData.Read())

            {

                var T = mySqlData["Date"];
                ViewData["events"] = new[]
                {

                new Event{Id=1,Title=mySqlData["Title"]+"",StartDate=T+""},

            };
            }

            return View();
        }
    }
}

