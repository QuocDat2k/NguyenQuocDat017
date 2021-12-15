using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenQuocDat017.Models;

namespace NguyenQuocDat017.Controllers
{
    public class NQD017Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public NQD017Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: NQD017
        public async Task<IActionResult> Index()
        {
            return View(await _context.NQD017.ToListAsync());
        }

        // GET: NQD017/Details
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nQD017 = await _context.NQD017
                .FirstOrDefaultAsync(m => m.NQDId == id);
            if (nQD017 == null)
            {
                return NotFound();
            }

            return View(nQD017);
        }

        // GET: NQD017/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NQD017/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] NQD017 nQD017)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nQD017);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nQD017);
        }

        // GET: NQD017/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nQD017 = await _context.NQD017.FindAsync(id);
            if (nQD017 == null)
            {
                return NotFound();
            }
            return View(nQD017);
        }

        // POST: NQD017/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] NQD017 nQD017)
        {
            if (id != nQD017.NQDId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nQD017);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NQD017Exists(nQD017.CompanyId))
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
            return View(nQD017);
        }

        // GET: nQD017/Delete
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nQD017 = await _context.NQD017
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (nQD017 == null)
            {
                return NotFound();
            }

            return View(nQD017);
        }

        // POST: NQD017/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nQD017 = await _context.NQD017.FindAsync(id);
            _context.nQD017.Remove(nQD017);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NQD017Exists(string id)
        {
            return _context.NQD017.Any(e => e.CompanyId == id);
        }
    }
}