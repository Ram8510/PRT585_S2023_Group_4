using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IClubService
    {
        Task<ClubModel?> GetById(int ClubId);
        Task<List<ClubModel>> GetAll();

        Task<int> CreateClub(ClubModel Club);
        Task UpdateClub(ClubModel Club);
        Task DeleteClub(int ClubId);
    }
}
