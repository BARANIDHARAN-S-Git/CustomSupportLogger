using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace CustomSupportLogger.Controllers
{
    public class HomeController : Controller
    {
        Validation v = null;
        AddCustomerComplaints a=null;

        public HomeController()
        {
            v= new Validation();
            a= new AddCustomerComplaints();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            bool result = v.UserValidation(Convert.ToInt32(Request["UserId"]), Request["Password"]);
            if (result)
            {
                return RedirectToAction("CustomerComplaints");
            }
            return RedirectToAction("Login");

        }

        public ActionResult CustomerComplaints()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerComplaints(FormCollection collection)
        {
            CustLogInfo l=new CustLogInfo();
            l.LogId = Convert.ToInt32(Request["LogId"]);
            l.CustEmail = Request["CustEmail"];
            l.CustName = Request["CustName"];
            l.LogStatus = Request["LogStatus"];
            l.UserId = Convert.ToInt32(Request["UserId"]);
            l.Description = Request["Description"];
            a.Add(l);
            return RedirectToAction("Login");
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