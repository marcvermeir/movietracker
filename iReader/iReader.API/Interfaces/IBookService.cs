using iReader.API.Entities;
using iReader.API.Models.Books;

namespace iReader.API.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book GetById(long id);
        void Create(CreateRequest request);
        void Update(UpdateRequest request);
        void Delete(long id);
    }
}
