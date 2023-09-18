using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class InstrumentModel
    {
        public int InstrumentId { get; set; } // int
        public string InstrumentName { get; set; } // nvarchar(400)
        public string InstrumentStatus { get; set; }

    }

}
