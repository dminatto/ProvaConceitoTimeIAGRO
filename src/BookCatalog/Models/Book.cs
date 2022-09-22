
namespace BookCatalog.Models;


public class Book
{
  private const int ShippingTax = 20;
  public int Id { get; set; }
  public string Name { get; set; }

  public double Price { get; set; }
  public Specification Specifications { get; set; }

  public double CalculateShipping()
  {
    return (Price * ShippingTax) / 100;
  }

}
