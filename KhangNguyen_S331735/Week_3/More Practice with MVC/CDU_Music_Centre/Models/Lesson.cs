using CDU_Music_Lessons_Application.Data.Base;
using CDU_Music_Lessons_Application.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDU_Music_Lessons_Application.Models
{
    public class Lesson:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string LessonName { get; set; }

        public string LessonDescription { get; set; }

        public string TermAndYear { get; set; }

        public DateTime LessonDateAndTime { get; set; }

        public string PaymentStatus { get; set; }

        public LessonLevel LessonLevel { get; set; }


        

        //Instruments
        public int InstrumentId { get; set; }
        [ForeignKey("InstrumentId")]
        public Instrument Instrument { get; set; }


        //Tutors
        public int TutorId { get; set; }
        [ForeignKey("TutorId")]
        public Tutor Tutor { get; set; }


        //Durations
        public int DurationId { get; set; }
        [ForeignKey("DurationId")]
        public Duration Duration { get; set; }

        //Relationships
        public List<Student_Lesson> Students_Lessons { get; set; }
    }
}
