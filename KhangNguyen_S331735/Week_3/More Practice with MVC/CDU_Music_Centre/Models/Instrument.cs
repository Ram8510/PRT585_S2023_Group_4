using CDU_Music_Lessons_Application.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace CDU_Music_Lessons_Application.Models
{
    public class Instrument:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string InstrumentName { get; set; }

        public string InstrumentDescription { get; set; }

        //Relationships
        public List<Lesson> Lessons { get; set; }


        
    }
}
