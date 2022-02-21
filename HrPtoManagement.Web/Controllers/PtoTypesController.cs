#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HrPtoManagement.Web.Data;
using AutoMapper;
using HrPtoManagement.Web.Models;

namespace HrPtoManagement.Web.Controllers
{
    public class PtoTypesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public PtoTypesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: PtoTypes
        public async Task<IActionResult> Index()
        {
            var ptoTypes = mapper.Map<List<PtoTypeViewModel>>(await _context.PtoTypes.ToListAsync());
            return View(ptoTypes);
        }

        // GET: PtoTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ptoType = await _context.PtoTypes.FindAsync(id);
            if (ptoType == null)
            {
                return NotFound();
            }

            var ptoTypeViewModel = mapper.Map<PtoTypeViewModel>(ptoType);
            return View(ptoTypeViewModel);
        }

        // GET: PtoTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PtoTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PtoTypeViewModel ptoTypeViewModel)
        {
            if (ModelState.IsValid)
            {
                var ptoType = mapper.Map<PtoType>(ptoTypeViewModel);
                _context.Add(ptoType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ptoTypeViewModel);
        }

        // GET: PtoTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ptoType = await _context.PtoTypes.FindAsync(id);
            if (ptoType == null)
            {
                return NotFound();
            }

            var ptoTypeViewModel = mapper.Map<PtoTypeViewModel>(ptoType);
            return View(ptoTypeViewModel);
        }

        // POST: PtoTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PtoTypeViewModel ptoTypeViewModel)
        {
            if (id != ptoTypeViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var ptoType = mapper.Map<PtoType>(ptoTypeViewModel);
                    _context.Update(ptoType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PtoTypeExists(ptoTypeViewModel.Id))
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
            return View(ptoTypeViewModel);
        }

        // GET: PtoTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ptoType = await _context.PtoTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ptoType == null)
            {
                return NotFound();
            }

            return View(ptoType);
        }

        // POST: PtoTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ptoType = await _context.PtoTypes.FindAsync(id);
            _context.PtoTypes.Remove(ptoType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PtoTypeExists(int id)
        {
            return _context.PtoTypes.Any(e => e.Id == id);
        }
    }
}
