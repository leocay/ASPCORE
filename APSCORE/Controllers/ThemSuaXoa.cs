using APSCORE.Entities;
using APSCORE.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using static APSCORE.Service.MySqlService;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace APSCORE.Controllers
{
    [Route("api/")]
    public class ThemSuaXoa : Controller
    {
        private readonly LibraryContext dbContext;
        private readonly FindAllBook findfind;
        public ThemSuaXoa() { 
            this.findfind = new FindAllBook(this.dbContext);
        }

        [HttpGet("get-book")]
        public List<Book> all(int NuId)
        {
            return findfind.FindAll(0);

        }

    }
}
