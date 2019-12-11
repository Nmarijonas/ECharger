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
    public class AtsiliepimaiController : Controller
    {
        private readonly EChargerInternationalContext _context;

        public AtsiliepimaiController(EChargerInternationalContext context)
        {
            _context = context;
        }

        // GET: Atsiliepimai
        public async Task<IActionResult> Index()
        {
            var eChargerInternationalContext = _context.Atsiliepimas.Include(a => a.FkAiksteleidAiksteleNavigation).Include(a => a.FkKlientasidKlientasNavigation);
            return View(await eChargerInternationalContext.ToListAsync());
        }

        // GET: Atsiliepimai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atsiliepimas = await _context.Atsiliepimas
                .Include(a => a.FkAiksteleidAiksteleNavigation)
                .Include(a => a.FkKlientasidKlientasNavigation)
                .FirstOrDefaultAsync(m => m.IdAtsiliepimas == id);
            if (atsiliepimas == null)
            {
                return NotFound();
            }

            return View(atsiliepimas);
        }

        // GET: Atsiliepimai/Create
        public IActionResult Create(int id)
        {
            var model = new Atsiliepimas();
            model.FkAiksteleidAikstele = id;
            ViewData["FkAiksteleidAikstele"] = new SelectList(_context.Aikstele, "IdAikstele", "Aprasymas");
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas");
            return View(model);
        }

        // POST: Atsiliepimai/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Aprasymas,Data,IdAtsiliepimas,FkKlientasidKlientas,FkAiksteleidAikstele")] Atsiliepimas atsiliepimas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atsiliepimas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkAiksteleidAikstele"] = new SelectList(_context.Aikstele, "IdAikstele", "Aprasymas", atsiliepimas.FkAiksteleidAikstele);
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", atsiliepimas.FkKlientasidKlientas);
            return View(atsiliepimas);
        }

        // GET: Atsiliepimai/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atsiliepimas = await _context.Atsiliepimas.FindAsync(id);
            if (atsiliepimas == null)
            {
                return NotFound();
            }
            ViewData["FkAiksteleidAikstele"] = new SelectList(_context.Aikstele, "IdAikstele", "Aprasymas", atsiliepimas.FkAiksteleidAikstele);
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", atsiliepimas.FkKlientasidKlientas);
            return View(atsiliepimas);
        }

        // POST: Atsiliepimai/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Aprasymas,Data,IdAtsiliepimas,FkKlientasidKlientas,FkAiksteleidAikstele")] Atsiliepimas atsiliepimas)
        {
            if (id != atsiliepimas.IdAtsiliepimas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atsiliepimas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtsiliepimasExists(atsiliepimas.IdAtsiliepimas))
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
            ViewData["FkAiksteleidAikstele"] = new SelectList(_context.Aikstele, "IdAikstele", "Aprasymas", atsiliepimas.FkAiksteleidAikstele);
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", atsiliepimas.FkKlientasidKlientas);
            return View(atsiliepimas);
        }

        // GET: Atsiliepimai/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var atsiliepimas = await _context.Atsiliepimas
                .Include(a => a.FkAiksteleidAiksteleNavigation)
                .Include(a => a.FkKlientasidKlientasNavigation)
                .FirstOrDefaultAsync(m => m.IdAtsiliepimas == id);
            if (atsiliepimas == null)
            {
                return NotFound();
            }

            return View(atsiliepimas);
        }

        // POST: Atsiliepimai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var atsiliepimas = await _context.Atsiliepimas.FindAsync(id);
            _context.Atsiliepimas.Remove(atsiliepimas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtsiliepimasExists(int id)
        {
            return _context.Atsiliepimas.Any(e => e.IdAtsiliepimas == id);
        }
    }
}
