using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class SongMapExtensions
    {
        public static SongModel ToSongModel(this Song src)
        {
            var dst = new SongModel();

            dst.SongId = src.SongId;
            dst.SongName = src.SongName;
            dst.SongAuthor = src.SongAuthor;

            return dst;
        }

        public static Song ToSong(this SongModel src, Song dst = null)
        {
            if (dst == null)
            {
                dst = new Song();
            }

            dst.SongId = src.SongId;
            dst.SongName = src.SongName;
            dst.SongAuthor = src.SongAuthor;

            return dst;
        }
    }
}
