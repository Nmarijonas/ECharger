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
    public class AikstelesController : Controller
    {
        private readonly EChargerInternationalContext _context;

        public AikstelesController(EChargerInternationalContext context)
        {
            _context = context;
        }

        // GET: Aiksteles
        public async Task<IActionResult> Index()
        {
            var eChargerInternationalContext = _context.Aikstele.Include(a => a.FkKlientasidKlientasNavigation);
            return View(await eChargerInternationalContext.ToListAsync());
        }

        // GET: Aiksteles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aikstele = await _context.Aikstele
                .Include(a => a.FkKlientasidKlientasNavigation)
                .FirstOrDefaultAsync(m => m.IdAikstele == id);
            if (aikstele == null)
            {
                return NotFound();
            }

            return View(aikstele);
        }

        // GET: Aiksteles/Create
        public IActionResult Create()
        {
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas");
            return View();
        }

        // POST: Aiksteles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pavadinimas,TelefonoNumeris,DarboPradzia,DarboPabaiga,Saugoma,ElektrosKaina,PapildomasMokestis,PapildomoMokescioAprasymas,Miestas,Gatve,NamoNr,KoordinateX,KoordinateY,PastoKodas,Aprasymas,IdAikstele,FkKlientasidKlientas")] Aikstele aikstele)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aikstele);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", aikstele.FkKlientasidKlientas);
            return View(aikstele);
        }

        // GET: Aiksteles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aikstele = await _context.Aikstele.FindAsync(id);
            if (aikstele == null)
            {
                return NotFound();
            }
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", aikstele.FkKlientasidKlientas);
            return View(aikstele);
        }

        // POST: Aiksteles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pavadinimas,TelefonoNumeris,DarboPradzia,DarboPabaiga,Saugoma,ElektrosKaina,PapildomasMokestis,PapildomoMokescioAprasymas,Miestas,Gatve,NamoNr,KoordinateX,KoordinateY,PastoKodas,Aprasymas,IdAikstele,FkKlientasidKlientas")] Aikstele aikstele)
        {
            if (id != aikstele.IdAikstele)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aikstele);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AiksteleExists(aikstele.IdAikstele))
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
            ViewData["FkKlientasidKlientas"] = new SelectList(_context.Klientas, "IdKlientas", "Aprasymas", aikstele.FkKlientasidKlientas);
            return View(aikstele);
        }

        // GET: Aiksteles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aikstele = await _context.Aikstele
                .Include(a => a.FkKlientasidKlientasNavigation)
                .FirstOrDefaultAsync(m => m.IdAikstele == id);
            if (aikstele == null)
            {
                return NotFound();
            }

            return View(aikstele);
        }

        // POST: Aiksteles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aikstele = await _context.Aikstele.FindAsync(id);
            _context.Aikstele.Remove(aikstele);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AiksteleExists(int id)
        {
            return _context.Aikstele.Any(e => e.IdAikstele == id);
        }
    }
}
