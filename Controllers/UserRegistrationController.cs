using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Reservation_System.Models;

namespace Travel_Reservation_System.Controllers
{
    public class UserRegistrationController : Controller
    {
        // GET: UserRegistration
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddUser(user data)
        {
            if (data != null)
            {
                OTRSEntities db = new OTRSEntities();
                user tt = new user();

                tt.user_dob = data.user_dob;
                tt.user_email = data.user_email;
                tt.user_location = data.user_location;
                tt.user_password = data.user_password;
                tt.user_confirm_password = data.user_confirm_password;
                tt.user_name = data.user_name;



                db.users.Add(tt);
                db.SaveChanges();
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            return Json(1, JsonRequestBehavior.AllowGet);
        }

    }
}