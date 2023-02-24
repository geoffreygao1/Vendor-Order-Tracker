using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Models;
using System.Collections.Generic;
using System;


namespace Store.Tests
{
  [TestClass]
  public class VendorTests
  {
    Vendor testVendor;
    [TestInitialize]
    public void TestInitialize()
    {
      testVendor = new Vendor("testName", "testDescription");
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_ReturnsDescriptionProperty_String()
    {
      Assert.AreEqual("testDescription", testVendor.Description);
    }

    [TestMethod]
    public void VendorConstructor_HasOrdersList_Order()
    {
      Order testOrder = new Order();
      testVendor.Orders.Add(testOrder);
      Assert.AreEqual(1, testVendor.Orders.Count);
      Assert.AreEqual(typeof(Order), testVendor.Orders[0].GetType());
    }
  }
}