using System.Collections.Generic;

namespace Store.Models;

public class Order
{
  public string Title { get; set; }
  public string Description { get; set; }
  public string Price { get; set; }
  public string Date { get; set; }
  public bool IsPaid { get; set; }
  public int Id { get; }
  private static List<Order> _instances = new List<Order> { };

  public Order(string inputTitle, string inputDescription, string inputPrice, string inputDate)
  {
    Title = inputTitle;
    Description = inputDescription;
    Price = inputPrice;
    Date = inputDate;
    IsPaid = false;
    _instances.Add(this);
    Id = _instances.Count;
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }
}

