using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Reservation_System.Controllers
{
    public class DisplayTrainsController : Controller
    {
        // GET: DisplayTrains
        public ActionResult Index()
        {
            return View();
        }
    }
}