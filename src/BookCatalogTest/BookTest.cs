using BookCatalog.Controllers;
using BookCatalog.Models;
using BookCatalog.Repository;

namespace BookCatalogTest;

public class BookTest
{
  [Theory(DisplayName = "Deve testar a função  CalculateShipping")]
  [MemberData(nameof(shouldCalculateTheCorrectShippingPriceData))]
  public void ShouldCalculateTheCorrectShippingPrice(Book book, double shippingValue)
  {
    var result = book.CalculateShipping();
    result.Should().Be(shippingValue.ToString("n2"));
  }

  public readonly static TheoryData<Book, double> shouldCalculateTheCorrectShippingPriceData = new()
  {
    {
        new Book { Id = 2, Name = "", Price = 150.00 },
        30.00
    },
    {
        new Book { Id = 2, Name = "", Price = 10.00 },
        2.00
    }
  };

  [Theory(DisplayName = "Deve testar a função Get")]
  [MemberData(nameof(ShouldFindBookByIdData))]
  public void ShouldFindBookById(int bookId, Book book)
  {
    Mock<IBookRepository> _repository = new Mock<IBookRepository>();
    _repository.Setup(m => m.GetById(bookId)).Returns(book);

    var result = _repository.Object.GetById(bookId);
    result.Should().BeEquivalentTo(book);
  }

  public readonly static TheoryData<int, Book> ShouldFindBookByIdData = new()
   {
     {
         2,
         new Book { Id = 2, Name = "Brave New World", Price = 150.00 }
       },
       {
         6,
         new Book { Id = 6, Name = "1984", Price = 95.00 }
       }
 };

  [Theory(DisplayName = "Deve testar a função GetAll")]
  [MemberData(nameof(ShouldFindAllBooksData))]
  public void ShouldFindAllBooks(List<Book> books)
  {
    Mock<IBookRepository> _repository = new Mock<IBookRepository>();
    _repository.Setup(m => m.GetAll()).Returns(books.ToArray());

    var result = _repository.Object.GetAll();
    result.Should().BeEquivalentTo(books);
  }

  public readonly static TheoryData<List<Book>> ShouldFindAllBooksData = new()
     {
       new List<Book>{
         new Book { Id = 2, Name = "Brave New World", Price = 150.00 },
         new Book { Id = 5, Name = "Damian", Price = 10.00 },
         new Book { Id = 6, Name = "1984", Price = 95.00 },
         }
   };
}
