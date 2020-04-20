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
    public class RoomDetailsController : Controller
    {
        private readonly DataContext _context;

        public RoomDetailsController(DataContext context)
        {
            _context = context;
        }

        // GET: RoomDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomDetails.ToListAsync());
        }

        // GET: RoomDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomDetail = await _context.RoomDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomDetail == null)
            {
                return NotFound();
            }

            return View(roomDetail);
        }

        // GET: RoomDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AdmissionDate")] RoomDetail roomDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomDetail);
        }

        // GET: RoomDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomDetail = await _context.RoomDetails.FindAsync(id);
            if (roomDetail == null)
            {
                return NotFound();
            }
            return View(roomDetail);
        }

        // POST: RoomDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AdmissionDate")] RoomDetail roomDetail)
        {
            if (id != roomDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomDetailExists(roomDetail.Id))
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
            return View(roomDetail);
        }

        // GET: RoomDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomDetail = await _context.RoomDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomDetail == null)
            {
                return NotFound();
            }

            return View(roomDetail);
        }

        // POST: RoomDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomDetail = await _context.RoomDetails.FindAsync(id);
            _context.RoomDetails.Remove(roomDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomDetailExists(int id)
        {
            return _context.RoomDetails.Any(e => e.Id == id);
        }
    }
}
