using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
  public class WebAppController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
      [HttpGet("/vendors/new")]
      public ActionResult New()
      {
        return View();
      }
      [HttpPost("/vendors")]
      public ActionResult Create(string vendorName)
      {
        Vendors newVendor = new Vendor(vendorName);
        return RedirectToAction("Index");
      }
      [HttpGet("vendors/{id}")]
      public ActionResult Show(int Id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor selectedVendor = Vendor.Find(id);
        List<Order> vendorOrders = selectedVendor.Order;
        model.Add("vendor", selectedVendor);
        model.Add("order", VendorOrder);
        return View(model);
      }
      [HttpPost("/vendors/{VendorId}/orders")]
      public ActionResult Create(int vendorId, string orderDescription)
      {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(VendorId);
      Orders newOrder = new Orders(ordersDescription);
      foundVendor.AddOrders(newOrders);
      List<Orders> VendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
      }
    }



}