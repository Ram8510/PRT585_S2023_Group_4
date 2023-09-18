using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class ClubModel
    {
        public int ClubId { get; set; } // int
        public string ClubName { get; set; } // nvarchar(400)
        public string ClubLocation { get; set; }

    }

}
