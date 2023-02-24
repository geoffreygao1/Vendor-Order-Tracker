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
  }
}