using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebApp.Models;
using System;


namespace WebApp.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void Vendor_StoreVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Chucky");
      Assert.AreEqual("Chucky", newVendor.Name);
      Assert.AreEqual(1, newVendor.Id);
    }
    [TestMethod]
    public void Vendor_StoresOrders_AddOrder()
    {
      Order newOrder = new Order("Test", "For Testing", 12);
      Vendor newVendor = new Vendor("Chucky");
      newVendor.AddOrder(newOrder);
      Assert.AreEqual("Test", newVendor.Orders[0].Title);

    }
    
  }
}