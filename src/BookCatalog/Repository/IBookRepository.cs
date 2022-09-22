namespace BookCatalog.Repository;
using BookCatalog.Models;
public interface IBookRepository
{
  public Book? GetById(int Id);
  public Book[] GetAll();
}