using System.Collections.Generic;

namespace Store.Models;

public class Vendor
{
  public string Name { get; set; }
  public string Description { get; set; }
  public List<Order> Orders = new List<Order>() { };
  public Vendor(string inputName, string inputDescription)
  {
    Name = inputName;
    Description = inputDescription;
  }
}