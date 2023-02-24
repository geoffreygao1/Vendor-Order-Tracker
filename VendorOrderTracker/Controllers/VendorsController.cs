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
  }
}