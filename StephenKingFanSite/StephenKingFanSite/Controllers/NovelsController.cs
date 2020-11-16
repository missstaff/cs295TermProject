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
        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["PublisherSortParm"] = sortOrder == "Publisher" ? "publisher_desc" : "Publisher";
            ViewData["GenreSortParm"] = sortOrder == "Genre" ? "genre_desc" : "Genre";
            ViewData["RatingSortParm"] = sortOrder == "Rating" ? "rating_desc" : "Rating";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            var novels = from n in _context.Novels
                         select n;
            if (!String.IsNullOrEmpty(searchString))
            {
                novels = novels.Where(s => s.Title.Contains(searchString)
                                       || s.Publisher.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    novels = novels.OrderByDescending(m => m.Title);
                    break;
                case "Director":
                    novels = novels.OrderBy(m => m.Publisher);
                    break;
                case "director_desc":
                    novels = novels.OrderByDescending(m => m.Publisher);
                    break;
                case "Date":
                    novels = novels.OrderBy(m => m.PulicationDate);
                    break;
                case "date_desc":
                    novels = novels.OrderByDescending(m => m.PulicationDate);
                    break;
                case "Genre":
                    novels = novels.OrderBy(m => m.Genre);
                    break;
                case "genre_desc":
                    novels = novels.OrderByDescending(m => m.Genre);
                    break;
                case "Rating":
                    novels = novels.OrderBy(m => m.Rating);
                    break;
                case "rating_desc":
                    novels = novels.OrderByDescending(m => m.Rating);
                    break;
                default:
                    novels = novels.OrderBy(s => s.Title);
                    break;
            }
            int pageSize = 3;
            return View(await PaginatedList<Novel>.CreateAsync(novels.AsNoTracking(), pageNumber ?? 1, pageSize));
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
