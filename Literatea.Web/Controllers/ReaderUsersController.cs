using Literatea.Web.Data;
using Literatea.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Literatea.Web.Controllers
{
    public class ReaderUsersController : Controller
    {
        private readonly DataContext datacontext;

        public ReaderUsersController(DataContext datacontext)
        {
            this.datacontext = datacontext;
        }

        // GET: ReaderUsers
        public async Task<IActionResult> Index()
        {
            return View(await datacontext.ReaderUsers.ToListAsync());
        }

        // GET: ReaderUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readerUser = await datacontext.ReaderUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (readerUser == null)
            {
                return NotFound();
            }

            return View(readerUser);
        }

        // GET: ReaderUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReaderUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ReaderUser readerUser)
        {
            if (ModelState.IsValid)
            {
                datacontext.Add(readerUser);
                await datacontext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(readerUser);
        }

        // GET: ReaderUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readerUser = await datacontext.ReaderUsers.FindAsync(id);
            if (readerUser == null)
            {
                return NotFound();
            }
            return View(readerUser);
        }

        // POST: ReaderUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ReaderUser readerUser)
        {
            if (id != readerUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    datacontext.Update(readerUser);
                    await datacontext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReaderUserExists(readerUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(readerUser);
        }

        // GET: ReaderUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readerUser = await datacontext.ReaderUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (readerUser == null)
            {
                return NotFound();
            }

            return View(readerUser);
        }

        // POST: ReaderUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var readerUser = await datacontext.ReaderUsers.FindAsync(id);
            datacontext.ReaderUsers.Remove(readerUser);
            await datacontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReaderUserExists(int id)
        {
            return datacontext.ReaderUsers.Any(e => e.Id == id);
        }
    }
}
