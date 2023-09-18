using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface ISongDal
    {
        // Getters
        SongModel? GetById(int SongId);
        List<SongModel> GetAll();

        // Actions
        int CreateSong(SongModel Song);
        void UpdateSong(SongModel Song);
        void DeleteSong(int SongId);
    }
}
