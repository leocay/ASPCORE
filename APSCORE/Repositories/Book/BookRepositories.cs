using APSCORE.Repositories.Book.Interfaces;
using APSCORE.Entities;
using static APSCORE.Service.MySqlService;
using System.Net;

namespace APSCORE.Repositories.Book
{
    public class BookRepositories : IBookRepositories
    {
        private readonly LibraryContext dbContext;

        public BookRepositories(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<APSCORE.Entities.Book> FindAllBooks()
        {

            List<APSCORE.Entities.Book> model = dbContext.Book.ToList();
            return model;

        }

        public APSCORE.Entities.Book FindBookByID(int page)
        {

            APSCORE.Entities.Book model = dbContext.Book.Where(x => x.Pages == page).FirstOrDefault();
            return model;

        }


    }
}
