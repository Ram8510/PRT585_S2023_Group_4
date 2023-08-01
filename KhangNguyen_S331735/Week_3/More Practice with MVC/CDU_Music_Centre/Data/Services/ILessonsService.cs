using CDU_Music_Lessons_Application.Data.Base;
using CDU_Music_Lessons_Application.Data.ViewModels;
using CDU_Music_Lessons_Application.Models;

namespace CDU_Music_Lessons_Application.Data.Services
{
    public interface ILessonsService : IEntityBaseRepository<Lesson>
    {
        Task<Lesson> GetLessonByIdAsync(int id);
        Task<NewLessonDropdownsVM> GetNewLessonDropdownsValues();
        Task AddNewLessonAsync(NewLessonVM data);
        Task UpdateLessonAsync(NewLessonVM data);
    }
}
