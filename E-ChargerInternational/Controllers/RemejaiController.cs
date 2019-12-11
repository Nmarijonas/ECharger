using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EChargerInternational.EChargerInternational;

namespace EChargerInternational.Controllers
{
    public class RemejaiController : Controller
    {
        private readonly EChargerInternationalContext _context;

        public RemejaiController(EChargerInternationalContext context)
        {
            _context = context;
        }

        // GET: Remejai
        public async Task<IActionResult> Index()
        {
            return View(await _context.Remejai.ToListAsync());
        }

        // GET: Remejai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remejai = await _context.Remejai
                .FirstOrDefaultAsync(m => m.IdRemėjai == id);
            if (remejai == null)
            {
                return NotFound();
            }

            return View(remejai);
        }

        // GET: Remejai/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Remejai/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pavadinimas,SkirtosLesos,Data,Salis,Aprasymas,IdRemėjai")] Remejai remejai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(remejai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(remejai);
        }

        // GET: Remejai/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remejai = await _context.Remejai.FindAsync(id);
            if (remejai == null)
            {
                return NotFound();
            }
            return View(remejai);
        }

        // POST: Remejai/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pavadinimas,SkirtosLesos,Data,Salis,Aprasymas,IdRemėjai")] Remejai remejai)
        {
            if (id != remejai.IdRemėjai)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(remejai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RemejaiExists(remejai.IdRemėjai))
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
            return View(remejai);
        }

        // GET: Remejai/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remejai = await _context.Remejai
                .FirstOrDefaultAsync(m => m.IdRemėjai == id);
            if (remejai == null)
            {
                return NotFound();
            }

            return View(remejai);
        }

        // POST: Remejai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var remejai = await _context.Remejai.FindAsync(id);
            _context.Remejai.Remove(remejai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RemejaiExists(int id)
        {
            return _context.Remejai.Any(e => e.IdRemėjai == id);
        }
    }
}
