using CDU_Music_Lessons_Application.Data.Base;
using CDU_Music_Lessons_Application.Models;

namespace CDU_Music_Lessons_Application.Data.Services
{
    public class DurationsService : EntityBaseRepository<Duration>, IDurationsService
    {
        public DurationsService(AppDbContext context) : base(context) { }
    }
}
