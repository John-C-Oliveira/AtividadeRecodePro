using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgenciaSemStress.Context;
using AgenciaSemStress.Models;
using System.IO;


namespace AgenciaSemStress.Controllers
{
    public class DestinosModelsController : Controller
    {
        private readonly MVCContext _context;

        public DestinosModelsController(MVCContext context)
        {
            _context = context;
        }

        // GET: DestinosModels
     
        public async Task<IActionResult> Index()
        {
            return View(await _context.Destinos.ToListAsync());
        }

        // GET: DestinosModels/Details/5
  
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinosModel = await _context.Destinos
                .FirstOrDefaultAsync(m => m.DestinoID == id);
            if (destinosModel == null)
            {
                return NotFound();
            }

            return View(destinosModel);
        }

        // GET: DestinosModels/Create
     
        public IActionResult Create()
        {
            return View();
        }

        // POST: DestinosModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public async Task<IActionResult> Create([Bind("DestinoID,NomeDestino,QtdadePessoa,IMGDestino,EnderecoDestino,PaisDestino,UFDestino,DataCadastroDestino")] DestinosModel destinosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destinosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(destinosModel);
        }

        // GET: DestinosModels/Edit/5
       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinosModel = await _context.Destinos.FindAsync(id);
            if (destinosModel == null)
            {
                return NotFound();
            }
            return View(destinosModel);
        }

        // POST: DestinosModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
    
        public async Task<IActionResult> Edit(int id, [Bind("DestinoID,NomeDestino,QtdadePessoa,IMGDestino,EnderecoDestino,PaisDestino,UFDestino,DataCadastroDestino")] DestinosModel destinosModel)
        {
            if (id != destinosModel.DestinoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destinosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestinosModelExists(destinosModel.DestinoID))
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
            return View(destinosModel);
        }

        // GET: DestinosModels/Delete/5
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinosModel = await _context.Destinos
                .FirstOrDefaultAsync(m => m.DestinoID == id);
            if (destinosModel == null)
            {
                return NotFound();
            }

            return View(destinosModel);
        }

        // POST: DestinosModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
      
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var destinosModel = await _context.Destinos.FindAsync(id);
            _context.Destinos.Remove(destinosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestinosModelExists(int id)
        {
            return _context.Destinos.Any(e => e.DestinoID == id);
        }
    }
}
