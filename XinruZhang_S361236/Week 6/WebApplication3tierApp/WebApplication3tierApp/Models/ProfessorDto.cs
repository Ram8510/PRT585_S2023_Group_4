using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class ProfessorDto
    {
        public int ProfessorId { get; set; }
        public string ProfessorCode { get; set; }
        public string ProfessorName { get; set; }
                        
    }

    public static class ProfessorDtoMapExtensions
    {
        public static ProfessorDto ToProfessorDto(this ProfessorModel src)
        {
            var dst = new ProfessorDto();
            dst.ProfessorId = src.ProfessorId;
            dst.ProfessorCode = src.ProfessorCode;
            dst.ProfessorName = src.ProfessorName;            
            return dst;
        }

        public static ProfessorModel ToProfessorModel(this ProfessorDto src)
        {
            var dst = new ProfessorModel();
            dst.ProfessorId = src.ProfessorId;
            dst.ProfessorCode = src.ProfessorCode;
            dst.ProfessorName = src.ProfessorName;            
            return dst;
        }
    }
}
