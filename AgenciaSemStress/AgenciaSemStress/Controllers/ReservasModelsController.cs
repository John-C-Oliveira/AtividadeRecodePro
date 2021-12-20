using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgenciaSemStress.Context;
using AgenciaSemStress.Models;

namespace AgenciaSemStress.Controllers
{
    public class ReservasModelsController : Controller
    {
        private readonly MVCContext _context;

        public ReservasModelsController(MVCContext context)
        {
            _context = context;
        }

        // GET: ReservasModels
       
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservas.ToListAsync());
        }

        // GET: ReservasModels/Details/5
      
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasModel = await _context.Reservas
                .FirstOrDefaultAsync(m => m.ReservaID == id);
            if (reservasModel == null)
            {
                return NotFound();
            }

            return View(reservasModel);
        }

        // GET: ReservasModels/Create
       
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReservasModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("ReservaID,FKDestinoID,FKClienteID,FKAnuncioID")] ReservasModel reservasModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservasModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reservasModel);
        }

        // GET: ReservasModels/Edit/5
     
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasModel = await _context.Reservas.FindAsync(id);
            if (reservasModel == null)
            {
                return NotFound();
            }
            return View(reservasModel);
        }

        // POST: ReservasModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Edit(int id, [Bind("ReservaID,FKDestinoID,FKClienteID,FKAnuncioID")] ReservasModel reservasModel)
        {
            if (id != reservasModel.ReservaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservasModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservasModelExists(reservasModel.ReservaID))
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
            return View(reservasModel);
        }

        // GET: ReservasModels/Delete/5
      
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasModel = await _context.Reservas
                .FirstOrDefaultAsync(m => m.ReservaID == id);
            if (reservasModel == null)
            {
                return NotFound();
            }

            return View(reservasModel);
        }

        // POST: ReservasModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservasModel = await _context.Reservas.FindAsync(id);
            _context.Reservas.Remove(reservasModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservasModelExists(int id)
        {
            return _context.Reservas.Any(e => e.ReservaID == id);
        }
    }
}
