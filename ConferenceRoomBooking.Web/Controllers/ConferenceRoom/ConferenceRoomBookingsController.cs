using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessAL.DbContext;
using DataAL.Models;
using System.Net.Http.Headers;

namespace ConferenceRoomBooking.Web.Controllers
{
    public class ConferenceRoomBookingsController : Controller
    {
        private readonly RepositoryContext _context;

        public ConferenceRoomBookingsController(RepositoryContext context)
        {
            _context = context;
        }

        // GET: ConferenceRoomBookings
        public async Task<IActionResult> Index(int flag )
        {
            var repositoryContext = _context.ConferenceRoomBooking.Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
            var finalData = repositoryContext;
            switch (flag)
            {
                case 100:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date == DateTime.Now.Date).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                case 1:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date >= DateTime.Now.Date).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                case -1:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date < DateTime.Now.Date).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                case 7:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date <= DateTime.Now.Date.AddDays(flag)).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                case 14:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date <= DateTime.Now.Date.AddDays(flag)).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                default:
                    break;
            }
            return View(await finalData.OrderBy(b => b.DateOfEvent).ToListAsync());
        }

        // GET: ConferenceRoomBookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conferenceRoomBooking = await _context.ConferenceRoomBooking
                .Include(c => c.Chairperson)
                .Include(c => c.EventType)
                .Include(c => c.Office)
                .FirstOrDefaultAsync(m => m.ConferenceRoomBookingId == id);
            if (conferenceRoomBooking == null)
            {
                return NotFound();
            }

            return View(conferenceRoomBooking);
        }

        // GET: ConferenceRoomBookings/Create
        public IActionResult Create()
        {
            ViewData["ChairpersonId"] = new SelectList(_context.Chairperson, "ChairpersonId", "ChairpersonName");
            ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name");
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name");
            return View();
        }

        // POST: ConferenceRoomBookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConferenceRoomBookingId,DateOfEvent,StartTime,Subject,EventTypeId,Description,ChairpersonId,TentativeEndTime,OfficeId,IsPublished,CreatedByUserId,CreatedDate,ModifiedById,ModificationDate")] DataAL.Models.ConferenceRoomBooking conferenceRoomBooking)
        {
            conferenceRoomBooking.IsPublished = true;
            conferenceRoomBooking.OfficeId = 1; // To be removed later
            conferenceRoomBooking.CreatedByUserId = 1;
            conferenceRoomBooking.CreatedDate = DateTime.Now;
            conferenceRoomBooking.ModifiedById = 1;
            conferenceRoomBooking.ModificationDate = DateTime.Now;
            conferenceRoomBooking.StartTime = "string.Empty";
            ModelState.Remove("StartTime");
            var singleBooking = await _context.ConferenceRoomBooking.Where(b => b.DateOfEvent == conferenceRoomBooking.DateOfEvent).FirstOrDefaultAsync();
            if (singleBooking != null)
            {
                ModelState.AddModelError(string.Empty, "A booking already exists for the selected date. Please choose a different date.");
                ViewData["ChairpersonId"] = new SelectList(_context.Chairperson, "ChairpersonId", "ChairpersonName", conferenceRoomBooking.ChairpersonId);
                ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
                ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
                return View(conferenceRoomBooking);
            }

            if (ModelState.IsValid)
            {
                _context.Add(conferenceRoomBooking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChairpersonId"] = new SelectList(_context.Chairperson, "ChairpersonId", "ChairpersonName", conferenceRoomBooking.ChairpersonId);
            ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
            return View(conferenceRoomBooking);
        }

        // GET: ConferenceRoomBookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conferenceRoomBooking = await _context.ConferenceRoomBooking.FindAsync(id);
            if (conferenceRoomBooking == null)
            {
                return NotFound();
            }
            ViewData["ChairpersonId"] = new SelectList(_context.Chairperson, "ChairpersonId", "ChairpersonName", conferenceRoomBooking.ChairpersonId);
            ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
            return View(conferenceRoomBooking);
        }

        // POST: ConferenceRoomBookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConferenceRoomBookingId,DateOfEvent,StartTime,Subject,EventTypeId,Description,ChairpersonId,TentativeEndTime,OfficeId,IsPublished,CreatedByUserId,CreatedDate,ModifiedById,ModificationDate")] DataAL.Models.ConferenceRoomBooking conferenceRoomBooking)
        {
            if (id != conferenceRoomBooking.ConferenceRoomBookingId)
            {
                return NotFound();
            }
            conferenceRoomBooking.IsPublished = true;
            conferenceRoomBooking.OfficeId = 1; // To be removed later
            conferenceRoomBooking.CreatedByUserId = 1;
            conferenceRoomBooking.CreatedDate = DateTime.Now;
            conferenceRoomBooking.ModifiedById = 1;
            conferenceRoomBooking.ModificationDate = DateTime.Now;
            conferenceRoomBooking.StartTime = "string.Empty";
            ModelState.Remove("StartTime");
            var existingBooking = await _context.ConferenceRoomBooking.Where(b => b.DateOfEvent == conferenceRoomBooking.DateOfEvent).FirstOrDefaultAsync();
            if (existingBooking != null && existingBooking.ConferenceRoomBookingId != conferenceRoomBooking.ConferenceRoomBookingId)
            {
                ModelState.AddModelError(string.Empty, "A booking already exists for the selected date. Please choose a different date.");
                ViewData["ChairpersonId"] = new SelectList(_context.Chairperson, "ChairpersonId", "ChairpersonName", conferenceRoomBooking.ChairpersonId);
                ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
                ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
                return View(conferenceRoomBooking);
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conferenceRoomBooking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConferenceRoomBookingExists(conferenceRoomBooking.ConferenceRoomBookingId))
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
            ViewData["ChairpersonId"] = new SelectList(_context.Chairperson, "ChairpersonId", "ChairpersonName", conferenceRoomBooking.ChairpersonId);
            ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
            return View(conferenceRoomBooking);
        }

        // GET: ConferenceRoomBookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conferenceRoomBooking = await _context.ConferenceRoomBooking
                .Include(c => c.Chairperson)
                .Include(c => c.EventType)
                .Include(c => c.Office)
                .FirstOrDefaultAsync(m => m.ConferenceRoomBookingId == id);
            if (conferenceRoomBooking == null)
            {
                return NotFound();
            }

            return View(conferenceRoomBooking);
        }

        // POST: ConferenceRoomBookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conferenceRoomBooking = await _context.ConferenceRoomBooking.FindAsync(id);
            if (conferenceRoomBooking != null)
            {
                _context.ConferenceRoomBooking.Remove(conferenceRoomBooking);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConferenceRoomBookingExists(int id)
        {
            return _context.ConferenceRoomBooking.Any(e => e.ConferenceRoomBookingId == id);
        }
    }
}
