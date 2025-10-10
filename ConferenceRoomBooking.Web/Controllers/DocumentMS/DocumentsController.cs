using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessAL.DbContext;
using DataAL.Models;

namespace ConferenceRoomBooking.Web.Controllers.DocumentMS
{
    public class DocumentsController : Controller
    {
        private readonly RepositoryContext _context;
        private readonly string _storagePath;

        public DocumentsController(RepositoryContext context, IWebHostEnvironment env)
        {
            _context = context;
            _storagePath = Path.Combine(env.WebRootPath, "uploads");
            if (!Directory.Exists(_storagePath))
                Directory.CreateDirectory(_storagePath);
        }
        public async Task<IActionResult> Index()
        {
            var docs = await _context.Document.OrderByDescending(d => d.UploadedAt).ToListAsync();
            return View(docs);
        }
        public async Task<IActionResult> FileCategories()
        {
            var docs = await _context.DocumentCategory.ToListAsync();
            return View(docs);
        }

        [HttpGet]
        public IActionResult Upload() => View();

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                ModelState.AddModelError("", "Select a file.");
                return View();
            }

            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(_storagePath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
                await file.CopyToAsync(stream);

            var doc = new Document
            {
                FileName = fileName,
                OriginalName = file.FileName,
                UploadedAt = DateTime.UtcNow,
                CreatedByUserId = 1, // Placeholder user ID
                CreatedDate = DateTime.UtcNow,
                IsPublished = true,
                DocumentTypeId = null, // Or set based on your logic
                Description = file.Headers.ContentType,
                FileSize = file.Length,
                FileExtension = Path.GetExtension(file.FileName),
                ModifiedById = 1,
                ModificationDate = DateTime.UtcNow,
                OfficeId = 1 // Placeholder office ID
            };
            _context.Document.Add(doc);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Download(int id)
        {
            var doc = await _context.Document.FindAsync(id);
            if (doc == null) return NotFound();

            var filePath = Path.Combine(_storagePath, doc.FileName);
            if (!System.IO.File.Exists(filePath)) return NotFound();

            var mimeType = "application/octet-stream";
            return PhysicalFile(filePath, mimeType, doc.OriginalName);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var doc = await _context.Document.FindAsync(id);
            if (doc == null) return NotFound();

            var filePath = Path.Combine(_storagePath, doc.FileName);
            try
            {

            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
            }
            catch (Exception ex)
            {

            }

            _context.Document.Remove(doc);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Documents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document
                .Include(d => d.DocumentType)
                .Include(d => d.Office)
                .FirstOrDefaultAsync(m => m.DocumentId == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        // GET: Documents/Create
        public IActionResult Create()
        {
            ViewData["DocumentTypeId"] = new SelectList(_context.DocumentCategory, "DocumentCategoryId", "CategoryName");
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "OfficeId");
            return View();
        }

        // POST: Documents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DocumentId,FileName,OriginalName,Description,UploadedAt,DocumentTypeId,OfficeId,IsPublished,CreatedByUserId,CreatedDate,ModifiedById,ModificationDate")] Document document)
        {
            if (ModelState.IsValid)
            {
                _context.Add(document);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DocumentTypeId"] = new SelectList(_context.DocumentCategory, "DocumentCategoryId", "CategoryName", document.DocumentTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "OfficeId", document.OfficeId);
            return View(document);
        }

        // GET: Documents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document.FindAsync(id);
            if (document == null)
            {
                return NotFound();
            }
            ViewData["DocumentTypeId"] = new SelectList(_context.DocumentCategory, "DocumentCategoryId", "CategoryName", document.DocumentTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "OfficeId", document.OfficeId);
            return View(document);
        }

        // POST: Documents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DocumentId,FileName,OriginalName,Description,UploadedAt,DocumentTypeId,OfficeId,IsPublished,CreatedByUserId,CreatedDate,ModifiedById,ModificationDate")] Document document)
        {
            if (id != document.DocumentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(document);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentExists(document.DocumentId))
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
            ViewData["DocumentTypeId"] = new SelectList(_context.DocumentCategory, "DocumentCategoryId", "CategoryName", document.DocumentTypeId);
            ViewData["OfficeId"] = new SelectList(_context.Office, "OfficeId", "OfficeId", document.OfficeId);
            return View(document);
        }

        // GET: Documents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document
                .Include(d => d.DocumentType)
                .Include(d => d.Office)
                .FirstOrDefaultAsync(m => m.DocumentId == id);
            if (document == null)
            {
                return NotFound();
            }

            return View(document);
        }

        private bool DocumentExists(int id)
        {
            return _context.Document.Any(e => e.DocumentId == id);
        }
    }
}
