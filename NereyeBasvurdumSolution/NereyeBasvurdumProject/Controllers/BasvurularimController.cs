using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NereyeBasvurdumProject.Models;

namespace NereyeBasvurdumProject.Controllers
{
    public class BasvurularimController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BasvurularimController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Basvurularim
        public async Task<IActionResult> Index()
        {
            return View(await _context.Basvurularim.ToListAsync());
        }

        // GET: Basvurularim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basvurularim = await _context.Basvurularim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (basvurularim == null)
            {
                return NotFound();
            }

            return View(basvurularim);
        }

        // GET: Basvurularim/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Basvurularim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sirket,Lokasyon,Pozisyon,Deneyim,Araci,BasvuruTarihi,Durum")] Basvurularim basvurularim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basvurularim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(basvurularim);
        }

        // GET: Basvurularim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basvurularim = await _context.Basvurularim.FindAsync(id);
            if (basvurularim == null)
            {
                return NotFound();
            }
            return View(basvurularim);
        }

        // POST: Basvurularim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sirket,Lokasyon,Pozisyon,Deneyim,Araci,BasvuruTarihi,Durum")] Basvurularim basvurularim)
        {
            if (id != basvurularim.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basvurularim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BasvurularimExists(basvurularim.Id))
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
            return View(basvurularim);
        }

        // GET: Basvurularim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basvurularim = await _context.Basvurularim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (basvurularim == null)
            {
                return NotFound();
            }

            return View(basvurularim);
        }

        // POST: Basvurularim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var basvurularim = await _context.Basvurularim.FindAsync(id);
            if (basvurularim != null)
            {
                _context.Basvurularim.Remove(basvurularim);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BasvurularimExists(int id)
        {
            return _context.Basvurularim.Any(e => e.Id == id);
        }
    }
}
