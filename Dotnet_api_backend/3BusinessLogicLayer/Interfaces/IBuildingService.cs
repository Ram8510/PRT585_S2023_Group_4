using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IBuildingService
    {
        Task<BuildingModel?> GetById(int BuildingId);
        Task<List<BuildingModel>> GetAll();

        Task<int> CreateBuilding(BuildingModel Building);
        Task UpdateBuilding(BuildingModel Building);
        Task DeleteBuilding(int BuildingId);
    }
}
