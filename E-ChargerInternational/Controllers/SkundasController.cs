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
    public class SkundasController : Controller
    {
        private readonly EChargerInternationalContext _context;

        public SkundasController(EChargerInternationalContext context)
        {
            _context = context;
        }

        // GET: Skundas
        public async Task<IActionResult> Index()
        {
            var eChargerInternationalContext = _context.Skundas.Include(s => s.BusenaNavigation).Include(s => s.FkKlientasidKlientas1Navigation).Include(s => s.FkKlientasidKlientasNavigation);
            return View(await eChargerInternationalContext.ToListAsync());
        }

        // GET: Skundas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skundas = await _context.Skundas
                .Include(s => s.BusenaNavigation)
                .Include(s => s.FkKlientasidKlientas1Navigation)
                .Include(s => s.FkKlientasidKlientasNavigation)
                .FirstOrDefaultAsync(m => m.IdSkundas == id);
            if (skundas == null)
            {
                return NotFound();
            }

            return View(skundas);
        }

        // GET: Skundas/Create
        public IActionResult Create()
        {
            ViewData["Busena"] = new SelectList(_context.SkundoBusena, "IdSkundoBusena", "Name");
            ViewData["FkKlientasidKlientas1"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas");
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas");
            return View();
        }

        // POST: Skundas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Aprasymas,Data,Busena,IdSkundas,FkKlientasidKlientas,FkKlientasidKlientas1")] Skundas skundas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skundas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Busena"] = new SelectList(_context.SkundoBusena, "IdSkundoBusena", "Name", skundas.Busena);
            ViewData["FkKlientasidKlientas1"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", skundas.FkKlientasidKlientas1);
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", skundas.FkKlientasidKlientas);
            return View(skundas);
        }

        // GET: Skundas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skundas = await _context.Skundas.FindAsync(id);
            if (skundas == null)
            {
                return NotFound();
            }
            ViewData["Busena"] = new SelectList(_context.SkundoBusena, "IdSkundoBusena", "Name", skundas.Busena);
            ViewData["FkKlientasidKlientas1"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", skundas.FkKlientasidKlientas1);
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", skundas.FkKlientasidKlientas);
            return View(skundas);
        }

        // POST: Skundas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Aprasymas,Data,Busena,IdSkundas,FkKlientasidKlientas,FkKlientasidKlientas1")] Skundas skundas)
        {
            if (id != skundas.IdSkundas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skundas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkundasExists(skundas.IdSkundas))
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
            ViewData["Busena"] = new SelectList(_context.SkundoBusena, "IdSkundoBusena", "Name", skundas.Busena);
            ViewData["FkKlientasidKlientas1"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", skundas.FkKlientasidKlientas1);
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", skundas.FkKlientasidKlientas);
            return View(skundas);
        }

        // GET: Skundas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skundas = await _context.Skundas
                .Include(s => s.BusenaNavigation)
                .Include(s => s.FkKlientasidKlientas1Navigation)
                .Include(s => s.FkKlientasidKlientasNavigation)
                .FirstOrDefaultAsync(m => m.IdSkundas == id);
            if (skundas == null)
            {
                return NotFound();
            }

            return View(skundas);
        }

        // POST: Skundas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skundas = await _context.Skundas.FindAsync(id);
            _context.Skundas.Remove(skundas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkundasExists(int id)
        {
            return _context.Skundas.Any(e => e.IdSkundas == id);
        }
    }
}
