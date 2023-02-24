namespace Store.Models;

public class Vendor
{
  public string Name { get; set; }
  public string Description { get; set; }

  public Vendor(string inputName, string inputDescription)
  {
    Name = inputName;
    Description = inputDescription;
  }
}