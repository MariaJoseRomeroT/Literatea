namespace Literatea.Web.Controllers
{
    using Literatea.Web.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    public class UsersController : Controller
    {
        private readonly DataContext dataContext;

        public UsersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await dataContext.Users.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
