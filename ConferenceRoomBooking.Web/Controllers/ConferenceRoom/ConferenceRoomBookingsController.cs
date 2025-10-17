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
using Microsoft.AspNetCore.Authorization;
using ConferenceRoomBooking.Web.Helper;

namespace ConferenceRoomBooking.Web.Controllers
{
    [Authorize]
    public class ConferenceRoomBookingsController : Controller
    {
        private readonly RepositoryContext _context;
        private readonly string _storagePath;

        public ConferenceRoomBookingsController(RepositoryContext context, IWebHostEnvironment env)
        {
            _context = context;
            _storagePath = Path.Combine(env.WebRootPath, "bookings");
            if (!Directory.Exists(_storagePath))
                Directory.CreateDirectory(_storagePath);
        }

        // GET: ConferenceRoomBookings
        public async Task<IActionResult> Index(int flag)
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
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date <= DateTime.Now.Date.AddDays(flag) && b.DateOfEvent.Date >= DateTime.Now.Date).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                case 14:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date <= DateTime.Now.Date.AddDays(flag) && b.DateOfEvent.Date >= DateTime.Now.Date).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                default:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date >= DateTime.Now.Date).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
            }
            return View(await finalData.OrderBy(b => b.DateOfEvent).ToListAsync());
        }

        // GET: ConferenceRoomBookings
        public async Task<IActionResult> Upcoming(int flag)
        {
            var repositoryContext = _context.ConferenceRoomBooking.Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
            var finalData = repositoryContext;
            switch (flag)
            {
                case -1:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date >= DateTime.Now.Date && (b.ChairpersonId != 1 && b.ChairpersonId != 2)).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                case 1:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date >= DateTime.Now.Date && b.ChairpersonId == flag).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                case 2:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date >= DateTime.Now.Date && b.ChairpersonId == flag).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
                default:
                    finalData = repositoryContext.Where(b => b.DateOfEvent.Date >= DateTime.Now.Date).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
                    break;
            }
            return View(await finalData.OrderBy(b => b.DateOfEvent).ToListAsync());
        }

        // GET: ConferenceRoomBookings
        public async Task<IActionResult> Today()
        {
            var repositoryContext = _context.ConferenceRoomBooking.Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
            var finalData = repositoryContext.Where(b => b.DateOfEvent.Date == DateTime.Now.Date).Include(c => c.Chairperson).Include(c => c.EventType).Include(c => c.Office);
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
            ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context);
            ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name");
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name");
            return View();
        }

        // POST: ConferenceRoomBookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConferenceRoomBookingId,DateOfEvent,StartTime,Subject,EventTypeId,Description,ChairpersonId,TentativeEndTime,OfficeId,IsPublished,CreatedByUserId,CreatedDate,ModifiedById,ModificationDate,ContactPersonMobile,ContactPersonaName,OfficeOrderUrl,ZoomMeetingId,ZoomMeetingPasscode,ZoomMeetingLink")] DataAL.Models.ConferenceRoomBooking conferenceRoomBooking, IFormFile file)
        {
            conferenceRoomBooking.IsPublished = true;
            conferenceRoomBooking.OfficeId = 1; // To be removed later
            conferenceRoomBooking.CreatedByUserId = 1;
            conferenceRoomBooking.CreatedDate = DateTime.Now;
            conferenceRoomBooking.ModifiedById = 1;
            conferenceRoomBooking.ModificationDate = DateTime.Now;
            conferenceRoomBooking.StartTime = "string.Empty";
            ModelState.Remove("StartTime");
            ModelState.Remove("NewDateOfEvent");
            var singleBooking = await _context.ConferenceRoomBooking.Where(b => b.DateOfEvent == conferenceRoomBooking.DateOfEvent).FirstOrDefaultAsync();
            if (singleBooking != null)
            {
                ModelState.AddModelError(string.Empty, "A booking already exists for the selected date. Please choose a different date.");
                ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context, conferenceRoomBooking.ChairpersonId);
                ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
                ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
                return View(conferenceRoomBooking);
            }
            if (file != null && file.Length > 0)
            {
                var fileName = Guid.NewGuid() + "-" + file.Name + Path.GetExtension(file.FileName);
                var filePath = Path.Combine(_storagePath, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                    await file.CopyToAsync(stream);
                conferenceRoomBooking.OfficeOrderUrl = fileName;
                conferenceRoomBooking.OriginalName = file.FileName;
            }

            if (ModelState.IsValid)
            {
                _context.Add(conferenceRoomBooking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context, conferenceRoomBooking.ChairpersonId);
            ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
            return View(conferenceRoomBooking);
        }
        public async Task<IActionResult> Download(int id)
        {
            var doc = await _context.ConferenceRoomBooking.FindAsync(id);
            if (doc == null) return NotFound();

            var filePath = Path.Combine(_storagePath, doc.OfficeOrderUrl);
            if (!System.IO.File.Exists(filePath)) return NotFound();

            var mimeType = "application/octet-stream";
            return PhysicalFile(filePath, mimeType, doc.OriginalName);
        }

        // GET: ConferenceRoomBookings/Edit/5
        public async Task<IActionResult> Shift(int? id)
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
            ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context, conferenceRoomBooking.ChairpersonId);
            ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
            return View(conferenceRoomBooking);
        }

        // POST: ConferenceRoomBookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Shift(int id, [Bind("ConferenceRoomBookingId,DateOfEvent,StartTime,Subject,EventTypeId,Description,ChairpersonId,TentativeEndTime,OfficeId,IsPublished,CreatedByUserId,CreatedDate,ModifiedById,ModificationDate,ContactPersonMobile,ContactPersonaName,OfficeOrderUrl,ZoomMeetingId,ZoomMeetingPasscode,ZoomMeetingLink,NewDateOfEvent")] DataAL.Models.ConferenceRoomBooking conferenceRoomBooking)
        {
            if (id != conferenceRoomBooking.ConferenceRoomBookingId)
            {
                return NotFound();
            }
            var oldBooking = await _context.ConferenceRoomBooking.AsNoTracking().FirstOrDefaultAsync(b => b.ConferenceRoomBookingId == conferenceRoomBooking.ConferenceRoomBookingId);
            if (oldBooking == null)
            {
                return NotFound();
            }
            conferenceRoomBooking.IsPublished = true;
            conferenceRoomBooking.OfficeId = oldBooking.OfficeId; // To be removed later
            conferenceRoomBooking.CreatedByUserId = oldBooking.CreatedByUserId;
            conferenceRoomBooking.CreatedDate = oldBooking.CreatedDate;
            conferenceRoomBooking.DateOfEvent = conferenceRoomBooking.NewDateOfEvent.Value;
            conferenceRoomBooking.ModifiedById = 1;
            conferenceRoomBooking.ModificationDate = DateTime.Now;
            conferenceRoomBooking.StartTime = "string.Empty";
            ModelState.Remove("StartTime");

            var existingBooking = await _context.ConferenceRoomBooking.Where(b => b.DateOfEvent == conferenceRoomBooking.NewDateOfEvent.Value).FirstOrDefaultAsync();
            if (existingBooking != null && existingBooking.ConferenceRoomBookingId != conferenceRoomBooking.ConferenceRoomBookingId)
            {
                ModelState.AddModelError(string.Empty, "A booking already exists for the selected date. Please choose a different date.");
                ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context, conferenceRoomBooking.ChairpersonId);
                ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
                ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
                return View(conferenceRoomBooking);
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (oldBooking!=null)
                    {
                        _context.Entry(oldBooking).State = EntityState.Detached;
                    }
                    //_context.Entry(existingBooking).State = EntityState.Detached;
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
            ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context, conferenceRoomBooking.ChairpersonId);
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
            ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context, conferenceRoomBooking.ChairpersonId);
            ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
            return View(conferenceRoomBooking);
        }

        // POST: ConferenceRoomBookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConferenceRoomBookingId,DateOfEvent,StartTime,Subject,EventTypeId,Description,ChairpersonId,TentativeEndTime,OfficeId,IsPublished,CreatedByUserId,CreatedDate,ModifiedById,ModificationDate,ContactPersonMobile,ContactPersonaName,OfficeOrderUrl,ZoomMeetingId,ZoomMeetingPasscode,ZoomMeetingLink")] DataAL.Models.ConferenceRoomBooking conferenceRoomBooking, IFormFile file)
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
            ModelState.Remove("NewDateOfEvent");
            var existingBooking = await _context.ConferenceRoomBooking.Where(b => b.DateOfEvent == conferenceRoomBooking.DateOfEvent).FirstOrDefaultAsync();
            if (existingBooking != null && existingBooking.ConferenceRoomBookingId != conferenceRoomBooking.ConferenceRoomBookingId)
            {
                ModelState.AddModelError(string.Empty, "A booking already exists for the selected date. Please choose a different date.");
                ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context, conferenceRoomBooking.ChairpersonId);
                ViewData["EventTypeId"] = new SelectList(_context.EventType, "EventTypeId", "Name", conferenceRoomBooking.EventTypeId);
                ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "Name", conferenceRoomBooking.OfficeId);
                return View(conferenceRoomBooking);
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null && file.Length >= 0)
                    {
                        var fileName = Guid.NewGuid() + "-" + file.Name + Path.GetExtension(file.FileName);
                        var filePath = Path.Combine(_storagePath, fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                            await file.CopyToAsync(stream);
                        conferenceRoomBooking.OfficeOrderUrl = filePath;
                        conferenceRoomBooking.OriginalName = file.FileName;
                    }

                    if (existingBooking != null)
                    {
                        _context.Entry(existingBooking).State = EntityState.Detached;
                    }

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
            ViewData["ChairpersonId"] = WebHelper.GetChairPerson(_context, conferenceRoomBooking.ChairpersonId);
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
