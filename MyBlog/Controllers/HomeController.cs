using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult ViewCustomer(string name, string telephonenumber)
        {
            Customer customer = new Customer();
            customer.ID = Guid.NewGuid().ToString();
            customer.Name = name;
            customer.TelephoneNumber = telephonenumber;

            return View(customer);
        }

        public ActionResult AddCustomer()
        {
            return View();
        }
    }
}