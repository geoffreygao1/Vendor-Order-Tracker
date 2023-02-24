using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Models;
using System.Collections.Generic;
using System;


namespace Store.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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
    public void VendorConstructor_ReturnsVendorIDProperty_Int()
    {
      Assert.AreEqual(1, testVendor.Id);
      Vendor testVendor2 = new Vendor("testName", "testDescription");
      Assert.AreEqual(2, testVendor2.Id);
    }

    [TestMethod]
    public void VendorConstructor_HasOrdersList_Order()
    {
      Order testOrder = new Order("testTitle", "tesDescription", "testDate", "testPrice");
      testVendor.Orders.Add(testOrder);
      Assert.AreEqual(1, testVendor.Orders.Count);
      Assert.AreEqual(typeof(Order), testVendor.Orders[0].GetType());
    }
  }
}