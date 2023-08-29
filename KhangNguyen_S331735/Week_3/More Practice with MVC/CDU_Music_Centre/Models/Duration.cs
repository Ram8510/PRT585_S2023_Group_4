using CDU_Music_Lessons_Application.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace CDU_Music_Lessons_Application.Models
{
    public class Duration:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Duration and Fixed Price")]
        public string DurationTypeAndCost { get; set; }

        [Display(Name = "Note For All Students")]
        public string DurationDescription { get; set; }

        //Relationships
        public List<Lesson> Lessons { get; set; }



    }
}
