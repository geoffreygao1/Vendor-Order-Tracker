using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
  public class VendorsController : Controller
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
    public ActionResult Create(string inputName, string inputDescription)
    {
      Vendor newVendor = new Vendor(inputName, inputDescription);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAllVendors()
    {
      Vendor.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/{id}/delete")]
    public ActionResult DeleteVendor(int id)
    {
      Vendor.DeleteVendor(id);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string inputTitle, string inputDescription, string inputPrice, string inputDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(inputTitle, inputDescription, inputPrice, inputDate);
      foundVendor.Orders.Add(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

    [HttpPost("/vendors/{vendorId}/orders/delete")]
    public ActionResult DeleteAllOrders(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      vendor.DeleteAllOrders();
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Order> vendorOrders = vendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", vendor);
      return View("Show", model);
    }
  }
}