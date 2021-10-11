using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Reservation_System.Models;
using Travel_Reservation_System.ViewModel;

namespace Travel_Reservation_System.Controllers
{
    public class ViewTicketController : Controller
    {
        // GET: ViewTicket
        public ActionResult Index(int? id)
        {
            OTRSEntities db = new OTRSEntities();
            var data1 = db.sp_View_Ticket(1003).Select(data => new ViewTicketViewModel
            {
                user_name = data.user_name,
                user_email = data.user_email,
                boarding_date = data.boardDate,
                drop_date = data.dropDate,
                drop_location = data.drop_location,
                booKingID=data.booking_id,
                NoofSeat=data.number_of_seats,
                TrainName=data.train_name
            }).FirstOrDefault();
            

           // return Json(data1, JsonRequestBehavior.AllowGet);
            return View(data1);
        }
        //public JsonResult ViewTicket()

        //{
           
        //}
    }
}