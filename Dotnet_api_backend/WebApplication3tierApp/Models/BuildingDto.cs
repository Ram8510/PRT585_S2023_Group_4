using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class BuildingDto
    {
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public string BuildingDepartment { get; set; }
                        
    }

    public static class BuildingDtoMapExtensions
    {
        public static BuildingDto ToBuildingDto(this BuildingModel src)
        {
            var dst = new BuildingDto();
            dst.BuildingId = src.BuildingId;
            dst.BuildingName = src.BuildingName;
            dst.BuildingDepartment = src.BuildingDepartment;
            return dst;
        }

        public static BuildingModel ToBuildingModel(this BuildingDto src)
        {
            var dst = new BuildingModel();
            dst.BuildingId = src.BuildingId;
            dst.BuildingName = src.BuildingName;
            dst.BuildingDepartment = src.BuildingDepartment;
            return dst;
        }
    }
}
