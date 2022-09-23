namespace BookCatalog.Repository;

using BookCatalog.Helpers;
using BookCatalog.Models;
public interface IBookRepository
{
  public Book? GetById(int Id);
  public Book[] GetAll();
  public Book[]? FindInBooks(QueryParameters filter);
}