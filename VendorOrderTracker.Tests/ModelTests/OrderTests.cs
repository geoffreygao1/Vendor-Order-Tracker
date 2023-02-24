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
      testOrder = new Order("testTitle", "testDescription", "testPrice", "testDate");
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_ReturnsTitleProperty_String()
    {
      Assert.AreEqual("testTitle", testOrder.Title);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsDescriptionProperty_String()
    {
      Assert.AreEqual("testDescription", testOrder.Description);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsPriceProperty_String()
    {
      Assert.AreEqual("testPrice", testOrder.Price);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsDateProperty_String()
    {
      Assert.AreEqual("testDate", testOrder.Date);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsIsPaidProperty_Bool()
    {
      Assert.AreEqual(false, testOrder.IsPaid);
    }
  }
}