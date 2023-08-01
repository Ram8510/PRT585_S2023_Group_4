using CDU_Music_Lessons_Application.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace CDU_Music_Lessons_Application.Models
{
    public class Tutor:IEntityBase
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Tutor Name")]
        public string Tutorname { get; set; }

        [Display(Name = "Description for Tutor")]
        public string TutorDescription { get; set; }

        //Relationships
        public List<Lesson> Lessons { get; set; }

    }
}
