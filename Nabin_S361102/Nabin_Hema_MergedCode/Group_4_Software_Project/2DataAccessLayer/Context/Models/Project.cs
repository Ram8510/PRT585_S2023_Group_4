using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Project
    {
        public int ProjectId { get; set; } // int
        public string ProjectCode { get; set; } // nvarchar(400) 
        public string ProjectName { get; set; } // nvarchar(400)
    }

}
