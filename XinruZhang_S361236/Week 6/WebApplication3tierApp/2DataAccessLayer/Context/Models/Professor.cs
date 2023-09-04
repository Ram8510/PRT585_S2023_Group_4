using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; } // int
        public string ProfessorCode { get; set; } // nvarchar(400) 
        public string ProfessorName { get; set; } // nvarchar(400)
    }


}
