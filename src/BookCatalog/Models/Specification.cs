

using System.Text.Json.Serialization;

namespace BookCatalog.Models;

public class Specification
{
  [JsonPropertyNameAttribute("Originally published")]
  public string? OriginallyPublished { get; set; }

  public string Author { get; set; }

  [JsonPropertyNameAttribute("Page Count")]
  public int? PageCount { get; set; }

  [JsonPropertyNameAttribute("Illustrator")]
  public object Illustrators { get; set; }

  public object Genres { get; set; }

}
