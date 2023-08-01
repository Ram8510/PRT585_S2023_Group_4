using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CDU_Music_Lessons_Application.Data;
using CDU_Music_Lessons_Application.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using CDU_Music_Lessons_Application.Data.Services;
using Microsoft.AspNetCore.Authorization;
using System.Numerics;

namespace CDU_Music_Lessons_Application.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsService _service;

        public StudentsController(IStudentsService service)
        {
            _service = service;
        }
        //GET: Student
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }


        // GET: Students/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);

            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fname,Lname,Dateofbirth,Age,Gender,Parentname,Email,Phonenumber")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.AddAsync(student);
            return RedirectToAction(nameof(Index));
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fname,Lname,Dateofbirth,Age,Gender,Parentname,Email,Phonenumber")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.UpdateAsync(id, student);
            return RedirectToAction(nameof(Index));
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
