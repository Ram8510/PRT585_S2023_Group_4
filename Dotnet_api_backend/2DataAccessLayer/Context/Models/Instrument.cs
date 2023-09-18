using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Instrument
    {
        public int InstrumentId { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentStatus { get; set; }
    }
}
