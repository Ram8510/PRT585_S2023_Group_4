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
    public static class BuildingMapExtensions
    {
        public static BuildingModel ToBuildingModel(this Building src)
        {
            var dst = new BuildingModel();

            dst.BuildingId = src.BuildingId;
            dst.BuildingName = src.BuildingName;
            dst.BuildingDepartment = src.BuildingDepartment;

            return dst;
        }

        public static Building ToBuilding(this BuildingModel src, Building dst = null)
        {
            if (dst == null)
            {
                dst = new Building();
            }

            dst.BuildingId = src.BuildingId;
            dst.BuildingName = src.BuildingName;
            dst.BuildingDepartment = src.BuildingDepartment;

            return dst;
        }
    }
}
