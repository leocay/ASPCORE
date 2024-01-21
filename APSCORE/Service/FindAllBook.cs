using APSCORE.Entities;
using static APSCORE.Service.MySqlService;

namespace APSCORE.Service
{
    public class FindAllBook
    {
        private readonly LibraryContext dbContext;

        public FindAllBook(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public List<Book> FindAll(int bookId)
        {
            if (bookId == 0)
            {
                List<Book> model = dbContext.Book.ToList();
                return model;
            }
            else
            {
                List<Book> model = dbContext.Book.ToList();
                return model;
            }


        }
    }
}
