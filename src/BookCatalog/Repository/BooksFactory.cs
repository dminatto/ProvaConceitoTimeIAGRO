using System.Text.Json;
using BookCatalog.Models;

namespace BookCatalog.Repository;

public class BooksFactory
{
  public static List<Book> Populate(string path)
  {
    List<Book> books = new List<Book>();

    using (StreamReader r = new StreamReader(path))
    {
      string json = r.ReadToEnd();
      books = JsonSerializer.Deserialize<List<Book>>(json,
      new JsonSerializerOptions
      {
        PropertyNameCaseInsensitive = true
      })!;

      return books;

    }
  }
}
