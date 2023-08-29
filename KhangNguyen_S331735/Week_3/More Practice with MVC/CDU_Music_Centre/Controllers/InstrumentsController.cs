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
    public class InstrumentsController : Controller
    {
        private readonly IInstrumentsService _service;

        public InstrumentsController(IInstrumentsService service)
        {
            _service = service;
        }

        //GET: Instruments
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: Instruments/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var instrumentDetails = await _service.GetByIdAsync(id);

            if (instrumentDetails == null) return View("NotFound");
            return View(instrumentDetails);
        }

        // GET: Instruments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instrument/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, InstrumentName, InstrumentDescription ")] Instrument instrument)
        {
            if (!ModelState.IsValid)
            {
                return View(instrument);
            }
            await _service.AddAsync(instrument);
            return RedirectToAction(nameof(Index));
        }

        // GET: Instruments/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var instrumentDetails = await _service.GetByIdAsync(id);
            if (instrumentDetails == null) return View("NotFound");
            return View(instrumentDetails);
        }

        // POST: Instruments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, InstrumentName, InstrumentDescription ")] Instrument instrument)
        {
            if (!ModelState.IsValid)
            {
                return View(instrument);
            }
            await _service.UpdateAsync(id, instrument);
            return RedirectToAction(nameof(Index));
        }
        // GET: Instruments/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var instrumentDetails = await _service.GetByIdAsync(id);
            if (instrumentDetails == null) return View("NotFound");
            return View(instrumentDetails);
        }

        // POST: Instruments/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instrumentDetails = await _service.GetByIdAsync(id);
            if (instrumentDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
