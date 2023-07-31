using CDU_Music_Lessons_Application.Data.Base;
using CDU_Music_Lessons_Application.Data.Enums;
using CDU_Music_Lessons_Application.Data.ViewModels;
using CDU_Music_Lessons_Application.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CDU_Music_Lessons_Application.Data.Services
{
    public class LessonsService:EntityBaseRepository<Lesson>, ILessonsService
    {
        private readonly AppDbContext _context;
        public LessonsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewLessonAsync(NewLessonVM data)
        {
            var newLesson = new Lesson()
            {
                LessonName = data.LessonName,
                LessonDescription = data.LessonDescription,
                TermAndYear = data.TermAndYear,
                LessonDateAndTime = data.LessonDateAndTime,
                PaymentStatus = data.PaymentStatus,
                LessonLevel = data.LessonLevel,
                InstrumentId = data.InstrumentId,
                TutorId = data.TutorId,
                DurationId = data.DurationId,
                
            };
            await _context.Lessons.AddAsync(newLesson);
            await _context.SaveChangesAsync();

            //Add Lesson Students
            foreach (var studentId in data.StudentIds)
            {
                var newStudentLesson = new Student_Lesson()
                {
                    LessonId = newLesson.Id,
                    StudentId = studentId
                };
                await _context.Students_Lessons.AddAsync(newStudentLesson);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Lesson> GetLessonByIdAsync(int id)
        {
            var lessonDetails = await _context.Lessons
                .Include(i => i.Instrument)
                .Include(t => t.Tutor)
                .Include(d => d.Duration)
                .Include(am => am.Students_Lessons).ThenInclude(s => s.Student)
                .FirstOrDefaultAsync(n => n.Id == id);

            return lessonDetails;
        }

        public async Task<NewLessonDropdownsVM> GetNewLessonDropdownsValues()
        {
            var response = new NewLessonDropdownsVM()
            {
                Students = await _context.Students.OrderBy(n => n.Fname).ToListAsync(),
                Instruments = await _context.Instruments.OrderBy(n => n.InstrumentName).ToListAsync(),
                Tutors = await _context.Tutors.OrderBy(n => n.Tutorname).ToListAsync(),
                Durations = await _context.Durations.OrderBy(n => n.DurationTypeAndCost).ToListAsync()
            };

            return response;
        }

        public async Task UpdateLessonAsync(NewLessonVM data)
        {
            var dbLesson = await _context.Lessons.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbLesson != null)
            {
                dbLesson.LessonName = data.LessonName;
                dbLesson.LessonDescription = data.LessonDescription;
                dbLesson.TermAndYear = data.TermAndYear;
                dbLesson.LessonDateAndTime = data.LessonDateAndTime;
                dbLesson.PaymentStatus = data.PaymentStatus;
                dbLesson.LessonLevel = data.LessonLevel;
                dbLesson.InstrumentId = data.InstrumentId;
                dbLesson.TutorId = data.TutorId;
                dbLesson.DurationId = data.DurationId;
                await _context.SaveChangesAsync();
            }

            //Remove existing students
            var existingStudentsDb = _context.Students_Lessons.Where(n => n.LessonId == data.Id).ToList();
            _context.Students_Lessons.RemoveRange(existingStudentsDb);
            await _context.SaveChangesAsync();

            //Add Lesson and students
            foreach (var studentId in data.StudentIds)
            {
                var newStudentLesson = new Student_Lesson()
                {
                    LessonId = data.Id,
                    StudentId = studentId
                };
                await _context.Students_Lessons.AddAsync(newStudentLesson);
            }
            await _context.SaveChangesAsync();
        }
    }
}
