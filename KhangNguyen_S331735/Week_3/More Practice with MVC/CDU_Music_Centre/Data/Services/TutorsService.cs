using CDU_Music_Lessons_Application.Data.Base;
using CDU_Music_Lessons_Application.Models;

namespace CDU_Music_Lessons_Application.Data.Services
{
    public class TutorsService : EntityBaseRepository<Tutor>, ITutorsService
    {
        public TutorsService(AppDbContext context) : base(context) { }

    }
}
