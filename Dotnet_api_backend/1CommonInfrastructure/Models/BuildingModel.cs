using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class BuildingModel
    {
        public int BuildingId { get; set; } // int
        public string BuildingName { get; set; } // nvarchar(400)
        public string BuildingDepartment { get; set; }

    }

}
