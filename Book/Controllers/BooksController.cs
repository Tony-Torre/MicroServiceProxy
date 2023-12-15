using Book.BLogic;
using Book.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        DataRepository DataRepository;

        public BooksController(DataRepository _DataRepository)
        {
            DataRepository = _DataRepository;
        }

        public IEnumerable<BookModel> GetBooks() 
        {
            return DataRepository.GetBooks();
        }
    }
}
