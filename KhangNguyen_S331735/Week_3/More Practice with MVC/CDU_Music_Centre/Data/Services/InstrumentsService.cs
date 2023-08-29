using CDU_Music_Lessons_Application.Data.Base;
using CDU_Music_Lessons_Application.Models;

namespace CDU_Music_Lessons_Application.Data.Services
{
    public class InstrumentsService : EntityBaseRepository<Instrument>, IInstrumentsService
    {
        public InstrumentsService(AppDbContext context) : base(context) { }
    }
}
