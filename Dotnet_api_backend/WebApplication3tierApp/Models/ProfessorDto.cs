using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class ProfessorDto
    {
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }
        public string ProfessorDepartment { get; set; }
                        
    }

    public static class ProfessorDtoMapExtensions
    {
        public static ProfessorDto ToProfessorDto(this ProfessorModel src)
        {
            var dst = new ProfessorDto();
            dst.ProfessorId = src.ProfessorId;
            dst.ProfessorName = src.ProfessorName;
            dst.ProfessorDepartment = src.ProfessorDepartment;
            return dst;
        }

        public static ProfessorModel ToProfessorModel(this ProfessorDto src)
        {
            var dst = new ProfessorModel();
            dst.ProfessorId = src.ProfessorId;
            dst.ProfessorName = src.ProfessorName;
            dst.ProfessorDepartment = src.ProfessorDepartment;
            return dst;
        }
    }
}
