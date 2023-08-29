using CDU_Music_Lessons_Application.Data.Base;
using CDU_Music_Lessons_Application.Models;

namespace CDU_Music_Lessons_Application.Data.Services
{
    public class StudentsService: EntityBaseRepository<Student>, IStudentsService
    {
        public StudentsService(AppDbContext context) : base(context) { }
        
    }
}
