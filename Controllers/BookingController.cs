using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Reservation_System.Models;

namespace Travel_Reservation_System.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index(int? id)
        
        {
            ViewBag.TrainID = id;
            return View();
        }
        public JsonResult CheckAmount(int? ID)

        {
            OTRSEntities db = new OTRSEntities();
            var data = db.tbl_train.Find(ID);
            
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}