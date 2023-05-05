using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplicacionMVC.Models;
using AplicacionMVC.Models.Entities;
using AplicacionMVC.ViewModels;
using AplicacionMVC.Models.Repository;

namespace AplicacionMVC.Controllers
{
    public class NoticesController : Controller
    {
        private readonly IRepository<Notice> _noticeRepository;

        public NoticesController(IRepository<Notice> noticeRepository)
        {
            _noticeRepository = noticeRepository;
        }

        // GET: Notices
        public async Task<IActionResult> Index()
        {
            return View(_noticeRepository.Get());
        }

        // GET: Notices/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
            //if (id == null || _context.Notices == null)
            //{
            //    return NotFound();
            //}

            //var notice = await _context.Notices
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (notice == null)
            //{
            //    return NotFound();
            //}

            //return View(notice);
        //}

        // GET: Notices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NoticeFormVM noticeViewModel)
        {
            if (ModelState.IsValid)
            {
                byte[] bytesImage;
                using (var stream = new MemoryStream())
                {
                    await noticeViewModel.UrlImage.CopyToAsync(stream);
                    bytesImage = stream.ToArray();
                }
                Notice notice = new Notice() { Description = noticeViewModel.Description, Title = noticeViewModel.Title,
                UrlImage = bytesImage};
                _noticeRepository.Add(notice);
                _noticeRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(noticeViewModel);
        }

        // GET: Notices/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Notices == null)
        //    {
        //        return NotFound();
        //    }

        //    var notice = await _context.Notices.FindAsync(id);
        //    if (notice == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(notice);
        //}

        // POST: Notices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,UrlImage")] Notice notice)
        //{
            //if (id != notice.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(notice);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!NoticeExists(notice.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(notice);
        //}

        // GET: Notices/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
            //if (id == null || _context.Notices == null)
            //{
            //    return NotFound();
            //}

            //var notice = await _context.Notices
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (notice == null)
            //{
            //    return NotFound();
            //}

            //return View(notice);
        //}

        // POST: Notices/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Notices == null)
        //    {
        //        return Problem("Entity set 'FootballAppContext.Notices'  is null.");
        //    }
        //    var notice = await _context.Notices.FindAsync(id);
        //    if (notice != null)
        //    {
        //        _context.Notices.Remove(notice);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool NoticeExists(int id)
        //{
        //  return (_context.Notices?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
