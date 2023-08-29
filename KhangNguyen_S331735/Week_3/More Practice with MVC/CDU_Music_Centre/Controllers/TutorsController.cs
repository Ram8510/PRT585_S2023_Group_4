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
    public class TutorsController : Controller
    {
        private readonly ITutorsService _service;

        public TutorsController(ITutorsService service)
        {
            _service = service;
        }
        //GET: Tutors
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: Tutors/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var tutorDetails = await _service.GetByIdAsync(id);

            if (tutorDetails == null) return View("NotFound");
            return View(tutorDetails);
        }


        // GET: Tutors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tutors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Tutorname, TutorDescription ")] Tutor tutor)
        {
            if (!ModelState.IsValid)
            {
                return View(tutor);
            }
            await _service.AddAsync(tutor);
            return RedirectToAction(nameof(Index));
        }

        // GET: Tutors/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var tutorDetails = await _service.GetByIdAsync(id);
            if (tutorDetails == null) return View("NotFound");
            return View(tutorDetails);
        }

        // POST: Tutors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Tutorname, TutorDescription")] Tutor tutor)
        {
            if (!ModelState.IsValid)
            {
                return View(tutor);
            }
            await _service.UpdateAsync(id, tutor);
            return RedirectToAction(nameof(Index));
        }

        // GET: Tutors/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var tutorDetails = await _service.GetByIdAsync(id);
            if (tutorDetails == null) return View("NotFound");
            return View(tutorDetails);
        }

        // POST: Tutors/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tutorDetails = await _service.GetByIdAsync(id);
            if (tutorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
