using MySql.Data.MySqlClient;
using Synechron.EventsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Synechron.EventsPortal.Controllers
{
    public class EventsController : Controller
    {
        // GET: Eventslt
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Event()
        {
            List<Event> events = new List<Event>();

            string connectionString = "Data Source = 127.0.0.1; PORT = 3306 ; Database = synechron ; User Id = root; Password=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Events;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event Event = new Event
                            {
                                event_id = reader.GetInt32("event_id"),
                                event_code = reader.GetString("event_code"),
                                event_name = reader.GetString("event_name"),
                                event_description = reader.GetString("event_description"),
                                event_startDate = reader.GetDateTime("event_startDate"),
                                event_endDate = reader.GetDateTime("event_endDate"),
                                event_fees = reader.GetDecimal("event_fees"),
                                event_totalSeats = reader.GetInt32("event_totalSeats"),
                                event_availableSeats = reader.GetInt32("event_availableSeats"),
                                event_logo = reader.GetString("event_logo")
                            };

                            events.Add(Event);
                        }
                    }
                }
            }

            return View("Events", events);
        }
    }
}