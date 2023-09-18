using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class SongDal : ISongDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public SongDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<SongModel> GetAll()
        {
            var result = _db.Songs.ToList();

            var returnObject = new List<SongModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToSongModel());
            }

            return returnObject;
        }

        public SongModel? GetById(int SongId)
        {
            var result = _db.Songs.SingleOrDefault(x => x.SongId == SongId);
            return result?.ToSongModel();
        }


        public int CreateSong(SongModel Song)
        {
            var newSong = Song.ToSong();
            _db.Songs.Add(newSong);
            _db.SaveChanges();
            return newSong.SongId;
        }


        public void UpdateSong(SongModel Song)
        {
            var existingSong = _db.Songs
                .SingleOrDefault(x => x.SongId == Song.SongId);

            if (existingSong == null)
            {
                throw new ApplicationException($"Song {Song.SongId} does not exist.");
            }
            Song.ToSong(existingSong);

            _db.Update(existingSong);
            _db.SaveChanges();
        }

        public void DeleteSong(int SongId)
        {
            var efModel = _db.Songs.Find(SongId);
            _db.Songs.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
