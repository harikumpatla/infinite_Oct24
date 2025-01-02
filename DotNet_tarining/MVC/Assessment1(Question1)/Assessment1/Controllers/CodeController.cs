using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Assessment1.Models;

namespace Assessment1.Controllers
{
    public class CodeController : Controller
    {
        private northwindEntities db = new northwindEntities();

        public ActionResult CustomersInGermany()
        {
            var customersInGermany = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(customersInGermany);
        }

        public ActionResult CustomerDetails(int orderId)
        {
            var customerDetails = db.Orders
                .Where(o => o.OrderID == orderId)
                .Select(o => o.Customer)
                .FirstOrDefault();
            return View(customerDetails);
        }
        // GET: Code
        public ActionResult Index()
        {
            return View();
        }
    }
}