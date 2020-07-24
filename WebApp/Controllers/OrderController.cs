using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using System.Collections.Generic;

namespace WebApp.Controllers
{
public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorID}/order")]
    public ActionResult New(int vendorID)
    {
      Order order = Order.Find(vendorId);
      return View(order);
    }
    [HttpGet("/vendor/vendorId/order/orderId")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
      [HttpPost("order/delete")]
      public ActionResult DeleteAll()
      {
        Order.ClearAll();
        return View();
      }
  }
    
} 