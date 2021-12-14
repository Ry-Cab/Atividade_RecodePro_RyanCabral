using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trip_Show_AgenciaDeViagens.Data;
using Trip_Show_AgenciaDeViagens.Models;

namespace Passagens.Controllers
{
    public class PassagensController : Controller
    {
        private readonly PassagemContext _context;

        public PassagensController(PassagemContext context)
        {
            _context = context;
        }

        // GET: Passagens
        public async Task<IActionResult> Index()
        {
            var passagemContext = _context.Passagens.Include(p => p.Cliente).Include(p => p.Destino);
            return View(await passagemContext.ToListAsync());
        }

        // GET: Passagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.Passagens
                .Include(p => p.Cliente)
                .Include(p => p.Destino)
                .FirstOrDefaultAsync(m => m.ID_PASSAGEM == id);
            if (passagem == null)
            {
                return NotFound();
            }

            return View(passagem);
        }

        // GET: Passagens/Create
        public IActionResult Create()
        {
            ViewData["ClienteID_CLIENTE"] = new SelectList(_context.Clientes, "ID_CLIENTE", "CIDADE_CLIENTE");
            ViewData["DestinoID_DESTINO"] = new SelectList(_context.Destinos, "ID_DESTINO", "CIDADE_DESTINO");
            return View();
        }

        // POST: Passagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_PASSAGEM,DATA_COMPRA,ClienteID_CLIENTE,DestinoID_DESTINO")] Passagem passagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteID_CLIENTE"] = new SelectList(_context.Clientes, "ID_CLIENTE", "CIDADE_CLIENTE", passagem.ClienteID_CLIENTE);
            ViewData["DestinoID_DESTINO"] = new SelectList(_context.Destinos, "ID_DESTINO", "CIDADE_DESTINO", passagem.DestinoID_DESTINO);
            return View(passagem);
        }

        // GET: Passagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.Passagens.FindAsync(id);
            if (passagem == null)
            {
                return NotFound();
            }
            ViewData["ClienteID_CLIENTE"] = new SelectList(_context.Clientes, "ID_CLIENTE", "CIDADE_CLIENTE", passagem.ClienteID_CLIENTE);
            ViewData["DestinoID_DESTINO"] = new SelectList(_context.Destinos, "ID_DESTINO", "CIDADE_DESTINO", passagem.DestinoID_DESTINO);
            return View(passagem);
        }

        // POST: Passagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_PASSAGEM,DATA_COMPRA,ClienteID_CLIENTE,DestinoID_DESTINO")] Passagem passagem)
        {
            if (id != passagem.ID_PASSAGEM)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassagemExists(passagem.ID_PASSAGEM))
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
            ViewData["ClienteID_CLIENTE"] = new SelectList(_context.Clientes, "ID_CLIENTE", "CIDADE_CLIENTE", passagem.ClienteID_CLIENTE);
            ViewData["DestinoID_DESTINO"] = new SelectList(_context.Destinos, "ID_DESTINO", "CIDADE_DESTINO", passagem.DestinoID_DESTINO);
            return View(passagem);
        }

        // GET: Passagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passagem = await _context.Passagens
                .Include(p => p.Cliente)
                .Include(p => p.Destino)
                .FirstOrDefaultAsync(m => m.ID_PASSAGEM == id);
            if (passagem == null)
            {
                return NotFound();
            }

            return View(passagem);
        }

        // POST: Passagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var passagem = await _context.Passagens.FindAsync(id);
            _context.Passagens.Remove(passagem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassagemExists(int id)
        {
            return _context.Passagens.Any(e => e.ID_PASSAGEM == id);
        }
    }
}
