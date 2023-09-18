using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface ISongService
    {
        Task<SongModel?> GetById(int SongId);
        Task<List<SongModel>> GetAll();

        Task<int> CreateSong(SongModel Song);
        Task UpdateSong(SongModel Song);
        Task DeleteSong(int SongId);
    }
}
