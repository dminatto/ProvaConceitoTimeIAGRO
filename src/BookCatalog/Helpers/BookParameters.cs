using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Helpers;
[BindProperties]
public class BookParameters
{
  public int? Id { get; set; }
  public string? Name { get; set; }
  public double? Price { get; set; }
  public string? Published { get; set; }
  public string? Author { get; set; }
  public int? PageCount { get; set; }

  public string? Illustrator { get; set; }
  public string? Genre { get; set; }

}
