using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Reservation_System.Models;
using Travel_Reservation_System.ViewModel;

namespace Travel_Reservation_System.Controllers
{
    public class SearchTrainController : Controller
    {
        // GET: SearchTrain
        public ActionResult Index1()
        {
            OTRSEntities db = new OTRSEntities();
          
          //var SearchTrain=db.searchtrains(obj.boarding_location,obj.drop_location,obj.boarding_date).Select(Data=>new SearchTrainViewModel
          //      {
                
          //      }
          
            return View();
        }

        public ActionResult SearchTrain(SearchTrainViewModel obj)
        {
            OTRSEntities db = new OTRSEntities();

            var SearchTrain = db.searchtrains(obj.boarding_location, obj.drop_location, obj.boarding_date).Select(data => new tbl_train
            {
                boarding_date = data.boarding_date,

                boarding_time = data.boarding_time,
                boarding_location = data.boarding_location,
                days_of_running = data.days_of_running,
                drop_date = data.drop_date,
                drop_location = data.drop_location,
                seats_available = data.seats_available,
                ticket_price = data.ticket_price,
                drop_time = data.drop_time,
                total_seats = data.total_seats,
                train_name = data.train_name,
                train_number = data.train_number,
                train_status = data.train_status,

            }).ToList();

            //TempData[" train_number"] = train_number;
            return View(SearchTrain);
        }
    }
}
