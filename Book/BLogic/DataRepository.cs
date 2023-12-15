using Book.Controllers;
using Book.Models;

namespace Book.BLogic
{
    public class DataRepository
    {
        private List<BookModel> Books = new();

        public DataRepository() 
        {
            Books.Add(new BookModel
            {
                Id = 1,
                Name = "Name",
                Description = "Description",
            });
            Books.Add(new BookModel
            {
                Id = 2,
                Name = "Name",
                Description = "Description",
            });
            Books.Add(new BookModel
            {
                Id = 3,
                Name = "Name",
                Description = "Description",
            });
        }

        public List<BookModel> GetBooks() => Books;
    }
}
