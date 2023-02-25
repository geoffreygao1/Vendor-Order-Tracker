using System.Collections.Generic;

namespace Store.Models;

public class Vendor
{
  public string Name { get; set; }
  public string Description { get; set; }
  public int Id { get; }
  private static List<Vendor> _instances = new List<Vendor> { };

  public List<Order> Orders = new List<Order>() { };
  public Vendor(string inputName, string inputDescription)
  {
    Name = inputName;
    Description = inputDescription;
    _instances.Add(this);
    Id = _instances.Count;
  }

  public static List<Vendor> GetAll()
  {
    return _instances;
  }
  public static Vendor Find(int searchId)
  {
    return _instances[searchId - 1];
  }

  public static void Delete(int searchId)
  {
    _instances.RemoveAt(searchId - 1);
  }
  public static void ClearAll()
  {
    _instances.Clear();
  }
}