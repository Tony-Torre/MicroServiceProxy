using Author.Models;
namespace Author.BLogic
{
    public class DataRepository
    {
        private List<Authors> authors = new();

        public DataRepository() {
            authors.Add(new Authors
            {
                Id = 1,
                Name = "Test",
                Category = "Test",
            });
            authors.Add(new Authors
            {
                Id = 2,
                Name = "Test",
                Category = "Test",
            });
            authors.Add(new Authors
            {
                Id = 3,
                Name = "Test",
                Category = "Test",
            });
        }
        public List<Authors> GetAuthors() => authors;
    }
}
