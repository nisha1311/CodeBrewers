using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Reservation_System.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index(int? id)
        {
            ViewBag.PaymentID = id;
            return View();
        }
    }
}