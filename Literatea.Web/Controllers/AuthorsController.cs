namespace Literatea.Web.Controllers
{
using Literatea.Web.Data;
using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class AuthorsController : Controller
    {
        private readonly DataContext dataContext;

        public AuthorsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await dataContext.Authors.ToListAsync());
        }
    }
}
