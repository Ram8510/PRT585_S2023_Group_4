using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class ProjectModel
    {
        public int ProjectId { get; set; } // int
        public string ProjectCode { get; set; } // nvarchar(400) 
        public string ProjectName { get; set; } // nvarchar(400)
    }

}
