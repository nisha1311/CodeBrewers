using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Reservation_System.Models;

namespace Travel_Reservation_System.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        public ActionResult Index()
        
        
        {
            return View();
        }
       [HttpPost]
        public ActionResult Index(login_ obj)
        {
            if(obj!=null)
            {
                OTRSEntities db = new OTRSEntities();
                var data=db.login_.FirstOrDefault(x => x.email == obj.email && x.password==obj.password);
              if(data != null)
                {
                    if (data.IsAdmin == true)
                    {
                        return View("../TrainSchedule/Index");
                    }
                }
              else
                {
                        return View("../SearchTrain/Index1");
                }
            }
            return View();
        }
    }
}