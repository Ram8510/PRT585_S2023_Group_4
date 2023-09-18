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
    public static class InstrumentMapExtensions
    {
        public static InstrumentModel ToInstrumentModel(this Instrument src)
        {
            var dst = new InstrumentModel();

            dst.InstrumentId = src.InstrumentId;
            dst.InstrumentName = src.InstrumentName;
            dst.InstrumentStatus = src.InstrumentStatus;

            return dst;
        }

        public static Instrument ToInstrument(this InstrumentModel src, Instrument dst = null)
        {
            if (dst == null)
            {
                dst = new Instrument();
            }

            dst.InstrumentId = src.InstrumentId;
            dst.InstrumentName = src.InstrumentName;
            dst.InstrumentStatus = src.InstrumentStatus;

            return dst;
        }
    }
}
