using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Reservation_System.ViewModel
{
    public class ViewTicketViewModel
    {
       
      
      

        public string drop_location { get; set; }
        public string boarding_date { get; set; }
        public string drop_date { get; set; }
       
        public string user_name { get; set; }
        public string user_email { get; set; }
        public int? booKingID { get; set; }
       public int? NoofSeat { get; set; }
        public string TrainName { get; set; }
       


    }
}