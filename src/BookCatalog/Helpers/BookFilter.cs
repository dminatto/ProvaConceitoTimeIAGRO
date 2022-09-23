using BookCatalog.Models;

namespace BookCatalog.Helpers;

public static class BookFilter
{
  public static IEnumerable<Predicate<Book>> GenerateQuery(this QueryParameters filter)
  {
    if (filter.Id.HasValue)
      yield return f => f.Id == filter.Id;
    if (!string.IsNullOrWhiteSpace(filter.Name))
      yield return f => f.Name.Contains(filter.Name);
    if (filter.Price.HasValue)
      yield return f => f.Price == filter.Price;
    if (!string.IsNullOrWhiteSpace(filter.Published))
      yield return f => f.Specifications.OriginallyPublished.Contains(filter.Published);
    if (!string.IsNullOrWhiteSpace(filter.Author))
      yield return f => f.Specifications.Author.Contains(filter.Author);
    if (filter.Price.HasValue)
      yield return f => f.Specifications.PageCount == filter.PageCount;
    if (!string.IsNullOrWhiteSpace(filter.Illustrator))
      yield return f => f.Specifications.Illustrators.ToString().Contains(filter.Illustrator);
    if (!string.IsNullOrWhiteSpace(filter.Genre))
      yield return f => f.Specifications.Genres.ToString().Contains(filter.Genre);
  }
}

