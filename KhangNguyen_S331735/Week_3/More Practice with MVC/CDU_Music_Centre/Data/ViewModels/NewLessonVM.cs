using CDU_Music_Lessons_Application.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace CDU_Music_Lessons_Application.Data.ViewModels
{
    public class NewLessonVM
    {
        public int Id { get; set; }


        [Display(Name = "Lesson name")]
        [Required(ErrorMessage = "Name is required")]
        public string LessonName { get; set; }


        [Display(Name = "Lesson description")]
        [Required(ErrorMessage = "Description is required")]
        public string LessonDescription { get; set; }


        [Display(Name = "Term and Year")]
        [Required(ErrorMessage = "Term and Year is required")]
        public string TermAndYear { get; set; }

        

        [Display(Name = "Lesson start date and time")]
        [Required(ErrorMessage = "Start date and time is required")]
        public DateTime LessonDateAndTime { get; set; }


        [Display(Name = "Payment Status")]
        [Required(ErrorMessage = "Payment status is required")]
        public string PaymentStatus { get; set; }


        [Display(Name = "Select the Lesson Level")]
        [Required(ErrorMessage = "Movie Level is required")]
        public LessonLevel LessonLevel { get; set; }


        //Relationships
        [Display(Name = "Select Student")]
        [Required(ErrorMessage = "Student is required")]
        public List<int> StudentIds { get; set; }


        [Display(Name = "Select the Instrument")]
        [Required(ErrorMessage = "Instrument is required")]
        public int InstrumentId { get; set; }


        [Display(Name = "Select the Tutor")]
        [Required(ErrorMessage = "Tutor is required")]
        public int TutorId { get; set; }

        [Display(Name = "Select the Duration")]
        [Required(ErrorMessage = "Duration is required")]
        public int DurationId { get; set; }
    }
}
