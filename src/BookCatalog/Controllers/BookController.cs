using Microsoft.AspNetCore.Mvc;
using BookCatalog.Repository;
using BookCatalog.Models;
using BookCatalog.Helpers;

namespace BookCatalog.Controllers;

[ApiController]
[Route("books")]
public class BookController : ControllerBase
{
  private readonly IBookRepository _repository;

  public BookController(IBookRepository repository)
  {
    _repository = repository;
  }

  [HttpGet("")]
  public IEnumerable<Book> Find([FromQuery] BookParameters? filter)
  {
    return _repository.FindInBooks(filter);
  }

  [HttpGet("{id}/shipping")]
  public IActionResult GetShippingValue(int id)
  {
    var book = _repository.GetById(id);

    if (book == null)
    {
      return NotFound();
    }

    return Ok(book.CalculateShipping());
  }
}
