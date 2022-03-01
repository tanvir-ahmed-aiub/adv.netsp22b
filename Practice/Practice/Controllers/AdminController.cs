using Practice.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Practice.Models.Entities;
using Practice.Auth;

namespace Practice.Controllers
{
    [AdminAccess]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            
            Entities db = new Entities();
            var orders = db.Orders.ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderModel>();
                cfg.CreateMap<Customer, CustomerModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<OrderModel>>(orders);
            return View(data);
        }
        public ActionResult Process(int id) {
            Entities db = new Entities();
            var order = (from o in db.Orders
                         where o.Id == id
                         select o).FirstOrDefault();
            order.Status = "Processing";
            foreach (var od in order.Orderdetails)
            {
                var orderedQty = od.Qty;
                od.Product.Qty -= orderedQty;
            }
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        public ActionResult Cancel(int id) {
            Entities db = new Entities();
            var order = (from o in db.Orders
                         where o.Id == id
                         select o).FirstOrDefault();
            if (order.Status == "Processing") {
                foreach (var od in order.Orderdetails)
                {
                    var orderedQty = od.Qty;
                    od.Product.Qty += orderedQty;
                }
            }
            order.Status = "Cancelled";
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}