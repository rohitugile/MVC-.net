using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Synechron.EventsPortal.Models
{
    public class Employee
    {
        public int employee_ID { get; set; }
        public string employee_name { get; set; }
        public string employee_address { get; set; }
        public string employee_city { get; set; }
        public string employee_zipcode { get; set; }
        public string employee_country { get; set; }
        public string employee_phone { get; set; }
        public string employee_email { get; set; }
        public string employee_skillsets { get; set; }
        public string employee_avatar { get; set; }
    }
}