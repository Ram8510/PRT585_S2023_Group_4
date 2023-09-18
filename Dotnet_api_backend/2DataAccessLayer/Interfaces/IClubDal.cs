using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IClubDal
    {
        // Getters
        ClubModel? GetById(int ClubId);
        List<ClubModel> GetAll();

        // Actions
        int CreateClub(ClubModel Club);
        void UpdateClub(ClubModel Club);
        void DeleteClub(int ClubId);
    }
}
