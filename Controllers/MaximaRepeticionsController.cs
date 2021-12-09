using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using defensoresTablada.Data;
using defensoresTablada.Models.BBDD;

namespace defensoresTablada.Controllers
{
    public class MaximaRepeticionsController : Controller
    {
        private readonly DefensoresContext _context;

        public MaximaRepeticionsController(DefensoresContext context)
        {
            _context = context;
        }

        // GET: MaximaRepeticions
        public async Task<IActionResult> Index()
        {
            return View(await _context.MaximasRepeticiones.ToListAsync());
        }

        // GET: MaximaRepeticions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maximaRepeticion = await _context.MaximasRepeticiones
                .FirstOrDefaultAsync(m => m.ID == id);
            if (maximaRepeticion == null)
            {
                return NotFound();
            }

            return View(maximaRepeticion);
        }

        // GET: MaximaRepeticions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MaximaRepeticions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Repeticion,Peso,ID,Nombre")] MaximaRepeticion maximaRepeticion)
        {
            if (ModelState.IsValid)
            {

                maximaRepeticion.Peso = (float)(maximaRepeticion.Peso / (1.0278 - 0.0278 * maximaRepeticion.Repeticion));
               
                _context.Add(maximaRepeticion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maximaRepeticion);
        }

        // GET: MaximaRepeticions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maximaRepeticion = await _context.MaximasRepeticiones.FindAsync(id);
            if (maximaRepeticion == null)
            {
                return NotFound();
            }
            return View(maximaRepeticion);
        }

        // POST: MaximaRepeticions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Repeticion,Peso,ID,Nombre")] MaximaRepeticion maximaRepeticion)
        {

            if (id != maximaRepeticion.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maximaRepeticion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaximaRepeticionExists(maximaRepeticion.ID))
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
            return View(maximaRepeticion);
        }

        // GET: MaximaRepeticions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maximaRepeticion = await _context.MaximasRepeticiones
                .FirstOrDefaultAsync(m => m.ID == id);
            if (maximaRepeticion == null)
            {
                return NotFound();
            }

            return View(maximaRepeticion);
        }

        // POST: MaximaRepeticions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maximaRepeticion = await _context.MaximasRepeticiones.FindAsync(id);
            _context.MaximasRepeticiones.Remove(maximaRepeticion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaximaRepeticionExists(int id)
        {
            return _context.MaximasRepeticiones.Any(e => e.ID == id);
        }
    }
}
