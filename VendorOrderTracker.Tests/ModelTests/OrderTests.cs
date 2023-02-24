using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Models;
using System.Collections.Generic;
using System;


namespace Store.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    Order testOrder;
    [TestInitialize]
    public void TestInitialize()
    {
      testOrder = new Order("testTitle", "testDescription", "testDate", "testPrice");
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

  }
}