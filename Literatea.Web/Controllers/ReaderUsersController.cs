namespace Literatea.Web.Controllers
{
    using Literatea.Web.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class ReaderUsersController : Controller
    {
        private readonly DataContext dataContext;

        public ReaderUsersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await dataContext.ReaderUsers.ToListAsync());  
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
