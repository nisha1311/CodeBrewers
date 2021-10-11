using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Reservation_System.Models;
using Travel_Reservation_System.ViewModel;

namespace Travel_Reservation_System.Controllers
{
    public class TrainScheduleController : Controller
    {
       

        // GET: TrainSchedule
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public  JsonResult AddTrain(tbl_train data)
        {
            if (data != null)
            {
                OTRSEntities db = new OTRSEntities();
                tbl_train tt = new tbl_train();
                tt.drop_date = data.drop_date;
                tt.boarding_time = data.boarding_time;

                tt.train_number = data.train_number;
                tt.train_name= data.train_name;
                tt.train_status = data.train_status;
                tt.ticket_price = data.ticket_price;
                tt.total_seats = data.total_seats;
                tt.seats_available = data.seats_available;
                tt.boarding_location = data.boarding_location;
                tt.drop_location = data.drop_location;
                tt.boarding_date = data.boarding_date;
                tt.drop_time = data.drop_time;
                tt.days_of_running = data.days_of_running;
                if (data.train_number > 0)
                {
                    db.Entry(tt).State = EntityState.Modified;
                   // db.Entry(tbl_train).State = EntityState.Modified;
                   // db.tbl_train.(tt);
                    db.SaveChanges();
                }
                else
                {
                    db.tbl_train.Add(tt);
                    db.SaveChanges();
                }



              
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            return Json(1, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTrainList(int? id)
        {
            OTRSEntities db = new OTRSEntities();
            //List<train> tt = new List<train>();
            var GetData = db.GetTrain(id).Select(data => new GetTrainViewModel
            {

                BoardingDate = data.boardDate,

                boarding_time = data.boardingtime,
                boarding_location = data.boarding_location,
                days_of_running = data.days_of_running,
                DropDate = data.dropDate,
                drop_location = data.drop_location,
                seats_available = data.seats_available,
                ticket_price = data.ticket_price,
                drop_time = data.droptime,
                total_seats = data.total_seats,
                train_name = data.train_name,
                train_number = data.train_number,
                train_status = data.train_status,




            }).ToList();
            return Json(GetData, JsonRequestBehavior.AllowGet);

        }

        public JsonResult DeleteTrainByID(int? ID)
        {
            OTRSEntities db = new OTRSEntities();
            var data=db.tbl_train.Find(ID);
            if(data!=null)
            {
                db.tbl_train.Remove(data);
                db.SaveChanges();
            }

            return Json(1, JsonRequestBehavior.AllowGet);
        }
       

    }
}