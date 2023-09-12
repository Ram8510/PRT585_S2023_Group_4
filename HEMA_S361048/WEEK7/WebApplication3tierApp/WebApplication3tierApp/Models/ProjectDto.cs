using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class ProjectDto
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }

        public string ProjectName { get; set; }
                        
    }

    public static class ProjectDtoMapExtensions
    {
        public static ProjectDto ToProjectDto(this ProjectModel src)
        {
            var dst = new ProjectDto();
            dst.ProjectId = src.ProjectId;
            dst.ProjectCode = src.ProjectCode;
            dst.ProjectName = src.ProjectName;            
            return dst;
        }

        public static ProjectModel ToProjectModel(this ProjectDto src)
        {
            var dst = new ProjectModel();
            dst.ProjectId = src.ProjectId;
            dst.ProjectCode = src.ProjectCode;
            dst.ProjectName = src.ProjectName;            
            return dst;
        }
    }
}
