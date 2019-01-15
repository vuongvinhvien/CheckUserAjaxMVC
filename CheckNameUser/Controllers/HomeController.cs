using Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckNameUser.Controllers
{
    public class HomeController : Controller
    {
        EFCnn db = new EFCnn();


        [HttpPost]
        public ActionResult CheckUserNameAvailablity(string userdata)
        {
            System.Threading.Thread.Sleep(200);
            var SearchData = db.Users.Where(x=>x.Name == userdata).SingleOrDefault();
            if(SearchData != null)
            {

                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}