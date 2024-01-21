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

        public void addBook()
        {
            dbContext.Add(new Book
            {
                ISBN = "978-1547247762",
                Title = "co len linh",
                Author = "mrlk",
                Language = "vn",
                Pages = 111,

            });
            dbContext.SaveChanges();
        }

        public void delete()
        {
            var item = dbContext.Book.Where(x => x.Language == "vn").FirstOrDefault();
            dbContext.Book.Remove(item);

            dbContext.SaveChanges();
        }
        public void edit()
        {
            var item = dbContext.Book.Where(x => x.Pages == 416).FirstOrDefault();
            item.Pages = 555;

            dbContext.SaveChanges();
        }
    }
}
