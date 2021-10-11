using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Reservation_System.ViewModel
{
    public class SearchTrainViewModel
    {
        public int train_number { get; set; }

        public int? train_numberInt { get; set; }
        public string train_name { get; set; }
        public string train_status { get; set; }
        public decimal ticket_price { get; set; }
        public int total_seats { get; set; }
        public int seats_available { get; set; }
        public string boarding_location { get; set; }
        public string drop_location { get; set; }
        public System.DateTime boarding_date { get; set; }
        public System.DateTime drop_date { get; set; }
        public System.TimeSpan boarding_time { get; set; }
        public System.TimeSpan drop_time { get; set; }
        public int days_of_running { get; set; }
    }
}