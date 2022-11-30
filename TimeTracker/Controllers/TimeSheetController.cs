using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Model;

namespace TimeTracker
{
    public class TimeSheetController : Controller
    {
        private readonly TimeTrackerDbContext _context;

        public TimeSheetController(TimeTrackerDbContext context)
        {
            _context = context;
        }

        // GET: TimeSheet
        public async Task<IActionResult> Index()
        {
              return _context.TimeSheets != null ? 
                          View(await _context.TimeSheets.ToListAsync()) :
                          Problem("Entity set 'TimeTrackerDbContext.TimeSheets'  is null.");
        }

        // GET: TimeSheet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TimeSheets == null)
            {
                return NotFound();
            }

            var timeSheet = await _context.TimeSheets
                .FirstOrDefaultAsync(m => m.TimesheetId == id);
            if (timeSheet == null)
            {
                return NotFound();
            }

            return View(timeSheet);
        }

        // GET: TimeSheet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TimeSheet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimesheetId,WorkDate,BeginTime,Description,Activity")] TimeSheet timeSheet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeSheet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeSheet);
        }

        // GET: TimeSheet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TimeSheets == null)
            {
                return NotFound();
            }

            var timeSheet = await _context.TimeSheets.FindAsync(id);
            if (timeSheet == null)
            {
                return NotFound();
            }
            return View(timeSheet);
        }

        // POST: TimeSheet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TimesheetId,WorkDate,BeginTime,Description,Activity")] TimeSheet timeSheet)
        {
            if (id != timeSheet.TimesheetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeSheet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeSheetExists(timeSheet.TimesheetId))
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
            return View(timeSheet);
        }

        // GET: TimeSheet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TimeSheets == null)
            {
                return NotFound();
            }

            var timeSheet = await _context.TimeSheets
                .FirstOrDefaultAsync(m => m.TimesheetId == id);
            if (timeSheet == null)
            {
                return NotFound();
            }

            return View(timeSheet);
        }

        // POST: TimeSheet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TimeSheets == null)
            {
                return Problem("Entity set 'TimeTrackerDbContext.TimeSheets'  is null.");
            }
            var timeSheet = await _context.TimeSheets.FindAsync(id);
            if (timeSheet != null)
            {
                _context.TimeSheets.Remove(timeSheet);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeSheetExists(int id)
        {
          return (_context.TimeSheets?.Any(e => e.TimesheetId == id)).GetValueOrDefault();
        }
    }
}
