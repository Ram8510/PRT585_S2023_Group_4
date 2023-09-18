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
    public static class ClubMapExtensions
    {
        public static ClubModel ToClubModel(this Club src)
        {
            var dst = new ClubModel();

            dst.ClubId = src.ClubId;
            dst.ClubName = src.ClubName;
            dst.ClubLocation = src.ClubLocation;

            return dst;
        }

        public static Club ToClub(this ClubModel src, Club dst = null)
        {
            if (dst == null)
            {
                dst = new Club();
            }

            dst.ClubId = src.ClubId;
            dst.ClubName = src.ClubName;
            dst.ClubLocation = src.ClubLocation;

            return dst;
        }
    }
}
