using MySql.Data.MySqlClient;
using Synechron.EventsPortal.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Synechron.EventsPortal.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Emp()
        {
            List<Employee> employees = new List<Employee>();

            string connectionString = "Data Source = 127.0.0.1; PORT = 3306 ; Database = synechron ; User Id = root; Password=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employees;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    { 
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                employee_ID = reader.GetInt32("employee_ID"),
                                employee_name = reader.GetString("employee_name"),
                                employee_address = reader.GetString("employee_address"),
                                employee_city = reader.GetString("employee_city"),
                                employee_zipcode = reader.GetString("employee_zipcode"),
                                employee_country = reader.GetString("employee_country"),
                                employee_phone = reader.GetString("employee_phone"),
                                employee_email = reader.GetString("employee_email"),
                                employee_skillsets = reader.GetString("employee_skillsets"),
                                employee_avatar = reader.GetString("employee_avatar")
                            };

                            employees.Add(employee);
                        }
                    }
                }
            }

            return View("Employees",employees);
        }
    }
}