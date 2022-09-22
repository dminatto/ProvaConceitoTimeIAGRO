using BookCatalog.Models;

namespace BookCatalog.Repository;

public class BookRepository : IBookRepository
{
  protected readonly List<Book> _context;
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


}
