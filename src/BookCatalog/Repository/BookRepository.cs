using BookCatalog.Helpers;
using BookCatalog.Models;

namespace BookCatalog.Repository;

public class BookRepository : IBookRepository
{
  public readonly List<Book> _context;
  public BookRepository()
  {
    _context = BooksFactory.Populate("./Repository/books.json");
  }
  public Book? GetById(int Id)
  {
    return this._context.Find(b => b.Id == Id);
  }

  public Book[] GetAll()
  {
    return this._context.ToArray();
  }

  public Book[]? FindInBooks(QueryParameters? filter)
  {
    var predicates = BookFilter.GenerateQuery(filter);
    return this._context.Where(a => predicates.All(p => p(a))).ToArray();
  }
}
