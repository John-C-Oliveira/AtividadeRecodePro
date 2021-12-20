using AgenciaSemStress.Context;
using AgenciaSemStress.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgenciaSemStress.Controllers
{
    public class AnunciosModelsController : Controller
    {
        private readonly MVCContext _context;

        public AnunciosModelsController(MVCContext context)
        {
            _context = context;
        }

        // GET: AnunciosModels
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Anuncios.ToListAsync());
        }

        // GET: AnunciosModels/Details/5
       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anunciosModel = await _context.Anuncios
                .FirstOrDefaultAsync(m => m.AnuncioID == id);
            if (anunciosModel == null)
            {
                return NotFound();
            }

            return View(anunciosModel);
        }

        // GET: AnunciosModels/Create
      
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnunciosModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
   
        public async Task<IActionResult> Create([Bind("AnuncioID,TipoAnuncio,ValorAnuncio,NomeAnuncio,DataSaida,DataRetorno")] AnunciosModel anunciosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(anunciosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(anunciosModel);
        }

        // GET: AnunciosModels/Edit/5
     
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anunciosModel = await _context.Anuncios.FindAsync(id);
            if (anunciosModel == null)
            {
                return NotFound();
            }
            return View(anunciosModel);
        }

        // POST: AnunciosModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
     
        public async Task<IActionResult> Edit(int id, [Bind("AnuncioID,TipoAnuncio,ValorAnuncio,NomeAnuncio,DataSaida,DataRetorno")] AnunciosModel anunciosModel)
        {
            if (id != anunciosModel.AnuncioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(anunciosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnunciosModelExists(anunciosModel.AnuncioID))
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
            return View(anunciosModel);
        }

        // GET: AnunciosModels/Delete/5
     
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anunciosModel = await _context.Anuncios
                .FirstOrDefaultAsync(m => m.AnuncioID == id);
            if (anunciosModel == null)
            {
                return NotFound();
            }

            return View(anunciosModel);
        }

        // POST: AnunciosModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var anunciosModel = await _context.Anuncios.FindAsync(id);
            _context.Anuncios.Remove(anunciosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnunciosModelExists(int id)
        {
            return _context.Anuncios.Any(e => e.AnuncioID == id);
        }
    }
}
