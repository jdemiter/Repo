using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectResume.Data;
using ProjectResume.Models;

namespace ProjectResume.Controllers
{
    public class CertificationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CertificationsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Certifications
        public async Task<IActionResult> Index()
        {
            return View(await _context.Certifications.ToListAsync());
        }

        // GET: Certifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certifications = await _context.Certifications.SingleOrDefaultAsync(m => m.ID == id);
            if (certifications == null)
            {
                return NotFound();
            }

            return View(certifications);
        }

        // GET: Certifications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Certifications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CertificationReceived,DateReceived,From")] Certifications certifications)
        {
            if (ModelState.IsValid)
            {
                _context.Add(certifications);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(certifications);
        }

        // GET: Certifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certifications = await _context.Certifications.SingleOrDefaultAsync(m => m.ID == id);
            if (certifications == null)
            {
                return NotFound();
            }
            return View(certifications);
        }

        // POST: Certifications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CertificationReceived,DateReceived,From")] Certifications certifications)
        {
            if (id != certifications.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(certifications);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CertificationsExists(certifications.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(certifications);
        }

        // GET: Certifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certifications = await _context.Certifications.SingleOrDefaultAsync(m => m.ID == id);
            if (certifications == null)
            {
                return NotFound();
            }

            return View(certifications);
        }

        // POST: Certifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var certifications = await _context.Certifications.SingleOrDefaultAsync(m => m.ID == id);
            _context.Certifications.Remove(certifications);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CertificationsExists(int id)
        {
            return _context.Certifications.Any(e => e.ID == id);
        }
    }
}
