using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}