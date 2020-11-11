using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StephenKingFanSite.Data;
using StephenKingFanSite.Models;

namespace StephenKingFanSite.Controllers
{
    public class NovelsController : Controller
    {
        private readonly KingContext _context;

        public NovelsController(KingContext context)
        {
            _context = context;
        }

        // GET: Novels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Novels.ToListAsync());
        }

        // GET: Novels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novel = await _context.Novels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (novel == null)
            {
                return NotFound();
            }

            return View(novel);
        }

        // GET: Novels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Novels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Publisher,PulicationDate,Genre")] Novel novel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(novel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(novel);
        }

        // GET: Novels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novel = await _context.Novels.FindAsync(id);
            if (novel == null)
            {
                return NotFound();
            }
            return View(novel);
        }

        // POST: Novels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Publisher,PulicationDate,Genre")] Novel novel)
        {
            if (id != novel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(novel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NovelExists(novel.ID))
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
            return View(novel);
        }

        // GET: Novels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novel = await _context.Novels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (novel == null)
            {
                return NotFound();
            }

            return View(novel);
        }

        // POST: Novels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var novel = await _context.Novels.FindAsync(id);
            _context.Novels.Remove(novel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NovelExists(int id)
        {
            return _context.Novels.Any(e => e.ID == id);
        }
    }
}
