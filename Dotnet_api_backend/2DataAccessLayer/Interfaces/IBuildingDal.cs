using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IBuildingDal
    {
        // Getters
        BuildingModel? GetById(int BuildingId);
        List<BuildingModel> GetAll();

        // Actions
        int CreateBuilding(BuildingModel Building);
        void UpdateBuilding(BuildingModel Building);
        void DeleteBuilding(int BuildingId);
    }
}
