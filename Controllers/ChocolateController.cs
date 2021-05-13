using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoChocolate.Models;

namespace ProjetoChocolate.Controllers
{
    public class ChocolateController : Controller
    {
        private readonly ChocolateContext _context;

        public ChocolateController(ChocolateContext context)
        {
            _context = context;
        }
        
        // GET: Chocolate
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chocolates.ToListAsync());
        }
        public IActionResult ExibirChocolates()
        {
            List<Chocolate> chocolate = _context.Chocolates.Where(c => c.Preco >= 50).ToList();
            return View(chocolate);
        }

        /*public double CalDesconto(double Preco, double Desconto){
            double Res = Preco - (Preco*(Desconto/100));
           return Res;
        } */

        // GET: Chocolate/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chocolate = await _context.Chocolates
                .FirstOrDefaultAsync(m => m.Id_Chocolate == id);
            if (chocolate == null)
            {
                return NotFound();
            }

            return View(chocolate);
        }

        // GET: Chocolate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chocolate/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Chocolate,Marca,Porcent_Cacau,Tipo,Data_Validade,Preco,Porcent_Desconto")] Chocolate chocolate)
        {
            if (ModelState.IsValid)
            {  
                chocolate.Preco = chocolate.CalcularDesconto(chocolate.Preco, chocolate.Porcent_Desconto);
                _context.Add(chocolate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chocolate);
        }

        // GET: Chocolate/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chocolate = await _context.Chocolates.FindAsync(id);
            if (chocolate == null)
            {
                return NotFound();
            }
            return View(chocolate);
        }

        // POST: Chocolate/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Chocolate,Marca,Porcent_Cacau,Tipo,Data_Validade,Preco,Porcent_Desconto")] Chocolate chocolate)
        {
            if (id != chocolate.Id_Chocolate)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {   chocolate.Preco = chocolate.CalcularDesconto(chocolate.Preco, chocolate.Porcent_Desconto);
                    _context.Update(chocolate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChocolateExists(chocolate.Id_Chocolate))
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
            return View(chocolate);
        }

        // GET: Chocolate/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chocolate = await _context.Chocolates
                .FirstOrDefaultAsync(m => m.Id_Chocolate == id);
            if (chocolate == null)
            {
                return NotFound();
            }

            return View(chocolate);
        }

        // POST: Chocolate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chocolate = await _context.Chocolates.FindAsync(id);
            _context.Chocolates.Remove(chocolate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChocolateExists(int id)
        {
            return _context.Chocolates.Any(e => e.Id_Chocolate == id);
        }
    }
}
