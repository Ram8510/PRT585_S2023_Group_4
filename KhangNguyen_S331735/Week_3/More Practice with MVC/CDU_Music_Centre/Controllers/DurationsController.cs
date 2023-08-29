using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CDU_Music_Lessons_Application.Data;
using CDU_Music_Lessons_Application.Models;
using CDU_Music_Lessons_Application.Data.Services;
using Microsoft.AspNetCore.Authorization;

namespace CDU_Music_Lessons_Application.Controllers
{
    public class DurationsController : Controller
    {

        private readonly IDurationsService _service;

        public DurationsController(IDurationsService service)
        {
            _service = service;
        }

        //GET: Duration
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: Duration/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var durationDetails = await _service.GetByIdAsync(id);

            if (durationDetails == null) return View("NotFound");
            return View(durationDetails);
        }

        // GET: Duration/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Duration/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, DurationTypeAndCost, DurationDescription ")] Duration duration)
        {
            if (!ModelState.IsValid)
            {
                return View(duration);
            }
            await _service.AddAsync(duration);
            return RedirectToAction(nameof(Index));
        }

        // GET: Durations/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var durationDetails = await _service.GetByIdAsync(id);
            if (durationDetails == null) return View("NotFound");
            return View(durationDetails);
        }

        // POST: Duration/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, DurationTypeAndCost, DurationDescription")] Duration duration)
        {
            if (!ModelState.IsValid)
            {
                return View(duration);
            }
            await _service.UpdateAsync(id, duration);
            return RedirectToAction(nameof(Index));
        }
        // GET: Duration/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var durationDetails = await _service.GetByIdAsync(id);
            if (durationDetails == null) return View("NotFound");
            return View(durationDetails);
        }

        // POST: Durations/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var durationDetails = await _service.GetByIdAsync(id);
            if (durationDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

