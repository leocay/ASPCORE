using APSCORE.Entities;
using APSCORE.Service;
using APSCORE.Service.EditBook.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using static APSCORE.Service.MySqlService;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace APSCORE.Controllers
{
    [Route("api/")]
    public class ThemSuaXoa : Controller
    {
        private readonly IEditBook editBook;

        public ThemSuaXoa(IEditBook editBook) { 
            this.editBook = editBook;
        }

        [HttpGet("get-book")]
        public List<Book> all()
        {
            return editBook.FindAll();

        }

        //[HttpGet("add-book")]
        //public void add()
        //{
        //    findfind.addBook();
        //}

        //[HttpGet("del-book")]
        //public void del()
        //{
        //    findfind.delete();
        //}


        //[HttpGet("edit-book")]
        //public void edit()
        //{
        //    findfind.edit();
        //}
    }
}
