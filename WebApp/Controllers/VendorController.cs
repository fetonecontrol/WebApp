using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
      [HttpGet("/vendor/new")]
      public ActionResult New()
      {
        return View();
      }
      [HttpPost("/vendor")]
      public ActionResult Create(string vendorName)
      {
        Vendor newVendor = new Vendor(vendorName);
        return RedirectToAction("Index");
      }
      [HttpGet("vendor/{id}")]
      public ActionResult Show(int Id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor selectedVendor = Vendor.Find(Id);
        List<Order> vendorOrders = selectedVendor.Orders;
        model.Add("vendor", selectedVendor);
        model.Add("order", vendorOrders);
        return View(model);
      }
      [HttpPost("/vendor/{VendorId}/order")]
      public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderDate)
      {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
      }
    }



}