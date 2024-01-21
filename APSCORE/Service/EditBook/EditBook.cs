using APSCORE.Entities;
using APSCORE.Repositories.Book.Interfaces;
using APSCORE.Service.EditBook.Interface;

namespace APSCORE.Service.EditBook
{
    public class EditBook : IEditBook
    {

        private readonly IBookRepositories bookRepositories;
        public EditBook(IBookRepositories bookRepositories) 
        {
            this.bookRepositories = bookRepositories;

        }

        public List<Book> FindAll()
        {
            return bookRepositories.FindAllBooks();

        }
    }
}
