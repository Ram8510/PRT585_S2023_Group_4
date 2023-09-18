using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class InstrumentDto
    {
        public int InstrumentId { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentStatus { get; set; }
                        
    }

    public static class InstrumentDtoMapExtensions
    {
        public static InstrumentDto ToInstrumentDto(this InstrumentModel src)
        {
            var dst = new InstrumentDto();
            dst.InstrumentId = src.InstrumentId;
            dst.InstrumentName = src.InstrumentName;
            dst.InstrumentStatus = src.InstrumentStatus;
            return dst;
        }

        public static InstrumentModel ToInstrumentModel(this InstrumentDto src)
        {
            var dst = new InstrumentModel();
            dst.InstrumentId = src.InstrumentId;
            dst.InstrumentName = src.InstrumentName;
            dst.InstrumentStatus = src.InstrumentStatus;
            return dst;
        }
    }
}
