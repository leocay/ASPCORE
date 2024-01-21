using APSCORE.Service;
using APSCORE.Entities;

namespace APSCORE.Repositories.Book.Interfaces
{
    public interface IBookRepositories
    {
        List<APSCORE.Entities.Book> FindAllBooks();

        APSCORE.Entities.Book FindBookByID(int page);
    }
}
