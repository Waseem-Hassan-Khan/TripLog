using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class HomeController : Controller
    {
        private string connString = "Server=(localdb);Database=TripLog;Integrated Security=True;";

        public ActionResult Index()
        {
            List<TripLogModel> tripLogs = new List<TripLogModel>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM TripLogs", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TripLogModel tripLog = new TripLogModel
                            {
                                TripId = (int)reader["TripId"],
                                Destination = (string)reader["Destination"],
                                StartDate = (DateTime)reader["StartDate"],
                                EndDate = (DateTime)reader["EndDate"],
                                Accommodation = (string)reader["Accommodation"],
                                AccommodationPhone = (string)reader["AccommodationPhone"],
                                AccommodationEmail = (string)reader["AccommodationEmail"],
                                ThingToDo1 = (string)reader["ThingToDo1"],
                                ThingToDo2 = (string)reader["ThingToDo2"],
                                ThingToDo3 = (string)reader["ThingToDo3"]
                            };

                            tripLogs.Add(tripLog);
                        }
                    }
                }
            }

            return View(tripLogs);
        }
    }
}
