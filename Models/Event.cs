using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Synechron.EventsPortal.Models
{

    public class Event
    {
        public int event_id { get; set; }
        public string event_code { get; set; }
        public string event_name { get; set; }
        public string event_description { get; set; }
        public DateTime event_startDate { get; set; }
        public DateTime event_endDate { get; set; }
        public decimal event_fees { get; set; }
        public int event_totalSeats { get; set; }
        public int event_availableSeats { get; set; }
        public string event_logo { get; set; }
    }

}