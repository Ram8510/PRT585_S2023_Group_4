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
using CDU_Music_Lessons_Application.Data.ViewModels;

namespace CDU_Music_Lessons_Application.Controllers
{
    public class LessonsController : Controller
    {
        private readonly ILessonsService _service;

        public LessonsController(ILessonsService service)
        {
            _service = service;
        }

        // GET: Lessons
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allLessons = await _service.GetAllAsync(n => n.Instrument, n => n.Tutor, n => n.Duration);
            return View(allLessons);
        }


        // GET: Lessons/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var lessonDetail = await _service.GetLessonByIdAsync(id);
            return View(lessonDetail);
        }

        // GET: Lessons/Create
        public async Task<IActionResult> Create()
        {
            var lessonDropdownsData = await _service.GetNewLessonDropdownsValues();

            ViewBag.Instruments = new SelectList(lessonDropdownsData.Instruments, "Id", "InstrumentName");
            ViewBag.Tutors = new SelectList(lessonDropdownsData.Tutors, "Id", "Tutorname");
            ViewBag.Durations = new SelectList(lessonDropdownsData.Durations, "Id", "DurationTypeAndCost");
            ViewBag.Students = new SelectList(lessonDropdownsData.Students, "Id", "Fname");

            return View();
        }

        // POST: Lessons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(NewLessonVM lesson)
        {
            if (!ModelState.IsValid)
            {
                var lessonDropdownsData = await _service.GetNewLessonDropdownsValues();

                ViewBag.Instruments = new SelectList(lessonDropdownsData.Instruments, "Id", "InstrumentName");
                ViewBag.Tutors = new SelectList(lessonDropdownsData.Tutors, "Id", "Tutorname");
                ViewBag.Durations = new SelectList(lessonDropdownsData.Durations, "Id", "DurationTypeAndCost");
                ViewBag.Students = new SelectList(lessonDropdownsData.Students, "Id", "Fname");

                return View(lesson);
            }

            await _service.AddNewLessonAsync(lesson);
            return RedirectToAction(nameof(Index));
        }


        // GET: Lessons/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var lessonDetails = await _service.GetLessonByIdAsync(id);
            if (lessonDetails == null) return View("NotFound");

            var response = new NewLessonVM()
            {
                Id = lessonDetails.Id,
                LessonName = lessonDetails.LessonName,
                LessonDescription = lessonDetails.LessonDescription,
                TermAndYear = lessonDetails.TermAndYear,
                PaymentStatus = lessonDetails.PaymentStatus,
                LessonLevel = lessonDetails.LessonLevel,
                InstrumentId = lessonDetails.InstrumentId,
                TutorId = lessonDetails.TutorId,
                DurationId = lessonDetails.DurationId,
                StudentIds = lessonDetails.Students_Lessons.Select(n => n.StudentId).ToList(),

            };

            var lessonDropdownsData = await _service.GetNewLessonDropdownsValues();
            ViewBag.Instruments = new SelectList(lessonDropdownsData.Instruments, "Id", "InstrumentName");
            ViewBag.Tutors = new SelectList(lessonDropdownsData.Tutors, "Id", "Tutorname");
            ViewBag.Durations = new SelectList(lessonDropdownsData.Durations, "Id", "DurationTypeAndCost");
            ViewBag.Students = new SelectList(lessonDropdownsData.Students, "Id", "Fname");

            return View(response);
        }

        // POST: Lessons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewLessonVM lesson)
        {
            if (id != lesson.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var lessonDropdownsData = await _service.GetNewLessonDropdownsValues();

                ViewBag.Instruments = new SelectList(lessonDropdownsData.Instruments, "Id", "InstrumentName");
                ViewBag.Tutors = new SelectList(lessonDropdownsData.Tutors, "Id", "Tutorname");
                ViewBag.Durations = new SelectList(lessonDropdownsData.Durations, "Id", "DurationTypeAndCost");
                ViewBag.Students = new SelectList(lessonDropdownsData.Students, "Id", "Fname");

                return View(lesson);
            }

            await _service.UpdateLessonAsync(lesson);
            return RedirectToAction(nameof(Index));
        }

        // GET: Lessons/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var lessonDetails = await _service.GetByIdAsync(id);
            if (lessonDetails == null) return View("NotFound");
            return View(lessonDetails);
        }

        // POST: Lessons/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lessonDetails = await _service.GetByIdAsync(id);
            if (lessonDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
