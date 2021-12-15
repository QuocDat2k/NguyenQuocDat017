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
    public class CompanyNQD017Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public CompanyNController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: CompanyNQD017
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyNQD017Controller.ToListAsync());
        }

        // GET: CompanyNQD017/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNQD0017 = await _context.CompanyNQD0017
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (companyNQD0017 == null)
            {
                return NotFound();
            }

            return View(companyNQD0017);
        }

        // GET: companyNQD0017/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: companyNQD0017/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyNQD0017 companyNQD0017)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNQD0017);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNQD0017);
        }

        // GET: companyNQD0017/Edit
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNQD0017 = await _context.companyNQD0017.FindAsync(id);
            if (companyNQD0017 == null)
            {
                return NotFound();
            }
            return View(companyNQD0017);
        }

        // POST: companyNQD0017/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyNQD0017 companyNQD0017)
        {
            if (id != companyNQD0017.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyNQD0017);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyNQD0017Exists(companyNQD0017.CompanyNQD0017))
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
            return View(companyNQD0017);
        }

        // GET: companyNQD0017/Delete
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyNQD0017 = await _context.CompanyNQD0017
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (companyNQD0017 == null)
            {
                return NotFound();
            }

            return View(companyNQD0017);
        }

        // POST: companyNQD0017/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companyNQD0017 = await _context.CompanyNQD0017.FindAsync(id);
            _context.CompanyNQD0017.Remove(companyNQD0017);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyNQD0017Exists(string id)
        {
            return _context.CompanyNQD0017.Any(e => e.UniversityId == id);
        }
    }
}