using Microsoft.AspNetCore.Mvc;
using Store.Models;
using System.Collections.Generic;

namespace Store.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("order", order);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}/delete")]
    public ActionResult Delete(int vendorId, int orderId)
    {
      return RedirectToAction("Index");
    }
  }
}