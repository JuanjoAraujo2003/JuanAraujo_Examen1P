using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuanAraujo_Examen1P.Data;
using JuanAraujo_Examen1P.Models;

namespace JuanAraujo_Examen1P.Controllers
{
    public class JuanAraujo_tablaController : Controller
    {
        private readonly JuanAraujo_Examen1PContext _context;

        public JuanAraujo_tablaController(JuanAraujo_Examen1PContext context)
        {
            _context = context;
        }

        // GET: JuanAraujo_tabla
        public async Task<IActionResult> Index()
        {
              return _context.JuanAraujo_tabla != null ? 
                          View(await _context.JuanAraujo_tabla.ToListAsync()) :
                          Problem("Entity set 'JuanAraujo_Examen1PContext.JuanAraujo_tabla'  is null.");
        }

        // GET: JuanAraujo_tabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.JuanAraujo_tabla == null)
            {
                return NotFound();
            }

            var juanAraujo_tabla = await _context.JuanAraujo_tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (juanAraujo_tabla == null)
            {
                return NotFound();
            }

            return View(juanAraujo_tabla);
        }

        // GET: JuanAraujo_tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JuanAraujo_tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JaName,JaTieneCita,JaFechaCita,JaValorCita")] JuanAraujo_tabla juanAraujo_tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(juanAraujo_tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(juanAraujo_tabla);
        }

        // GET: JuanAraujo_tabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.JuanAraujo_tabla == null)
            {
                return NotFound();
            }

            var juanAraujo_tabla = await _context.JuanAraujo_tabla.FindAsync(id);
            if (juanAraujo_tabla == null)
            {
                return NotFound();
            }
            return View(juanAraujo_tabla);
        }

        // POST: JuanAraujo_tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JaName,JaTieneCita,JaFechaCita,JaValorCita")] JuanAraujo_tabla juanAraujo_tabla)
        {
            if (id != juanAraujo_tabla.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(juanAraujo_tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JuanAraujo_tablaExists(juanAraujo_tabla.Id))
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
            return View(juanAraujo_tabla);
        }

        // GET: JuanAraujo_tabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.JuanAraujo_tabla == null)
            {
                return NotFound();
            }

            var juanAraujo_tabla = await _context.JuanAraujo_tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (juanAraujo_tabla == null)
            {
                return NotFound();
            }

            return View(juanAraujo_tabla);
        }

        // POST: JuanAraujo_tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.JuanAraujo_tabla == null)
            {
                return Problem("Entity set 'JuanAraujo_Examen1PContext.JuanAraujo_tabla'  is null.");
            }
            var juanAraujo_tabla = await _context.JuanAraujo_tabla.FindAsync(id);
            if (juanAraujo_tabla != null)
            {
                _context.JuanAraujo_tabla.Remove(juanAraujo_tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JuanAraujo_tablaExists(int id)
        {
          return (_context.JuanAraujo_tabla?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
