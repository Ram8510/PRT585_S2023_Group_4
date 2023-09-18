using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class ClubDto
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubLocation { get; set; }
                        
    }

    public static class ClubDtoMapExtensions
    {
        public static ClubDto ToClubDto(this ClubModel src)
        {
            var dst = new ClubDto();
            dst.ClubId = src.ClubId;
            dst.ClubName = src.ClubName;
            dst.ClubLocation = src.ClubLocation;
            return dst;
        }

        public static ClubModel ToClubModel(this ClubDto src)
        {
            var dst = new ClubModel();
            dst.ClubId = src.ClubId;
            dst.ClubName = src.ClubName;
            dst.ClubLocation = src.ClubLocation;
            return dst;
        }
    }
}
