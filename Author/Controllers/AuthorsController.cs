using Author.BLogic;
using Author.Models;
using Microsoft.AspNetCore.Mvc;

namespace Author.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : ControllerBase
    {
        private DataRepository _dataRepository;
        public AuthorsController(DataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        
        public IEnumerable<Authors> GetAuthors()
        {
            return _dataRepository.GetAuthors();
        }
    
    }
}
