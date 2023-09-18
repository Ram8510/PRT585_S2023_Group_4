using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class SongDto
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string SongAuthor { get; set; }
                        
    }

    public static class SongDtoMapExtensions
    {
        public static SongDto ToSongDto(this SongModel src)
        {
            var dst = new SongDto();
            dst.SongId = src.SongId;
            dst.SongName = src.SongName;
            dst.SongAuthor = src.SongAuthor;
            return dst;
        }

        public static SongModel ToSongModel(this SongDto src)
        {
            var dst = new SongModel();
            dst.SongId = src.SongId;
            dst.SongName = src.SongName;
            dst.SongAuthor = src.SongAuthor;
            return dst;
        }
    }
}
