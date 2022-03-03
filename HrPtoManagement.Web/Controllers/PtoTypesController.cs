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
using HrPtoManagement.Web.Interfaces;

namespace HrPtoManagement.Web.Controllers
{
    public class PtoTypesController : Controller
    {
        private readonly IPtoTypeRepository ptoTypeRepository;
        private readonly IMapper mapper;

        public PtoTypesController(IPtoTypeRepository ptoTypeRepository, IMapper mapper)
        {
            this.ptoTypeRepository = ptoTypeRepository;
            this.mapper = mapper;
        }

        // GET: PtoTypes
        public async Task<IActionResult> Index()
        {
            var ptoTypes = mapper.Map<List<PtoTypeViewModel>>(await ptoTypeRepository.GetAllAsync());
            return View(ptoTypes);
        }

        // GET: PtoTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var ptoType = await ptoTypeRepository.GetAsync(id);
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
                await ptoTypeRepository.AddAsync(ptoType);
                return RedirectToAction(nameof(Index));
            }
            return View(ptoTypeViewModel);
        }

        // GET: PtoTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var ptoType = await ptoTypeRepository.GetAsync(id);
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
                    await ptoTypeRepository.UpdateAsync(ptoType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ptoTypeRepository.Exists(ptoTypeViewModel.Id))
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

        // POST: PtoTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await ptoTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
