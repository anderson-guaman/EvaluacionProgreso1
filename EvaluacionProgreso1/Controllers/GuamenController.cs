using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvaluacionProgreso.Data;
using EvaluacionProgreso.Models;

namespace EvaluacionProgreso.Controllers
{
    public class GuamenController : Controller
    {
        private readonly DBContext _context;

        public GuamenController(DBContext context)
        {
            _context = context;
        }

        // GET: Guamen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Guaman.ToListAsync());
        }

        // GET: Guamen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guaman = await _context.Guaman
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guaman == null)
            {
                return NotFound();
            }

            return View(guaman);
        }

        // GET: Guamen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guamen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Calificacion,Nombre,Ecuatoriano,FechaNacimiento")] Guaman guaman)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guaman);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guaman);
        }

        // GET: Guamen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guaman = await _context.Guaman.FindAsync(id);
            if (guaman == null)
            {
                return NotFound();
            }
            return View(guaman);
        }

        // POST: Guamen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Calificacion,Nombre,Ecuatoriano,FechaNacimiento")] Guaman guaman)
        {
            if (id != guaman.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guaman);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuamanExists(guaman.Id))
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
            return View(guaman);
        }

        // GET: Guamen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guaman = await _context.Guaman
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guaman == null)
            {
                return NotFound();
            }

            return View(guaman);
        }

        // POST: Guamen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guaman = await _context.Guaman.FindAsync(id);
            if (guaman != null)
            {
                _context.Guaman.Remove(guaman);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuamanExists(int id)
        {
            return _context.Guaman.Any(e => e.Id == id);
        }
    }
}
