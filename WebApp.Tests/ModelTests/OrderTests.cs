using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebApp.Models;
using System;


namespace WebApp.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_StoreOrder_Order()
    {
      Order newOrder = new Order("Test", "For Testing", 12);
      Assert.AreEqual("Test", newOrder.Title);
      Assert.AreEqual("For Testing", newOrder.Description);
      Assert.AreEqual(12, newOrder.Date);
      Assert.AreEqual(1, newOrder.Id);
    }
  }
}