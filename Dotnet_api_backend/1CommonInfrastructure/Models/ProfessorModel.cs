using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class ProfessorModel
    {
        public int ProfessorId { get; set; } // int
        public string ProfessorName { get; set; } // nvarchar(400)
        public string ProfessorDepartment { get; set; }

    }

}
