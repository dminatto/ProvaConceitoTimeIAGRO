using Microsoft.AspNetCore.Mvc;
using BookCatalog.Repository;
using BookCatalog.Models;

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

  [HttpGet("{id}")]
  public IActionResult Get(int id)
  {
    var book = _repository.GetById(id);

    if (book == null)
    {
      return NotFound();
    }

    return Ok(book);
  }

  [HttpGet("all")]
  public IEnumerable<Book> GetAll()
  {
    return _repository.GetAll();
  }


}
