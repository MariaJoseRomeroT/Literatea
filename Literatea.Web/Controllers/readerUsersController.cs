using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Literatea.Web.Data;
using Literatea.Web.Data.Entities;

namespace Literatea.Web.Controllers
{
    public class readerUsersController : Controller
    {
        private readonly DataContext _context;

        public readerUsersController(DataContext context)
        {
            _context = context;
        }

        // GET: readerUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.readerUsers.ToListAsync());
        }

        // GET: readerUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readerUser = await _context.readerUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (readerUser == null)
            {
                return NotFound();
            }

            return View(readerUser);
        }

        // GET: readerUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: readerUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Birthdate,Email,Password")] readerUser readerUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(readerUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(readerUser);
        }

        // GET: readerUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readerUser = await _context.readerUsers.FindAsync(id);
            if (readerUser == null)
            {
                return NotFound();
            }
            return View(readerUser);
        }

        // POST: readerUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Birthdate,Email,Password")] readerUser readerUser)
        {
            if (id != readerUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(readerUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!readerUserExists(readerUser.Id))
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

        // GET: readerUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readerUser = await _context.readerUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (readerUser == null)
            {
                return NotFound();
            }

            return View(readerUser);
        }

        // POST: readerUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var readerUser = await _context.readerUsers.FindAsync(id);
            _context.readerUsers.Remove(readerUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool readerUserExists(int id)
        {
            return _context.readerUsers.Any(e => e.Id == id);
        }
    }
}
