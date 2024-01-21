using System.ComponentModel.DataAnnotations.Schema;

namespace APSCORE.Entities
{
    public class Book
    {

        private string iSBN;
        private string title;
        private string author;
        private string language;
        private int pages;

        public Book()
        {

        }
        public Book(string iSBN, string title, string author, string language, int pages)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            Language = language;
            Pages = pages;
        }

        public string ISBN { get => iSBN; set => iSBN = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Language { get => language; set => language = value; }
        public int Pages { get => pages; set => pages = value; }

    }
}
