namespace Store.Models;

public class Vendor
{
  public string Name { get; set; }

  public Vendor(string inputName)
  {
    Name = inputName;
  }
}