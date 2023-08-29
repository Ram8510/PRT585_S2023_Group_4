using CDU_Music_Lessons_Application.Models;

namespace CDU_Music_Lessons_Application.Data.ViewModels
{
    public class NewLessonDropdownsVM
    {
        public NewLessonDropdownsVM()
        {
            Instruments = new List<Instrument>();
            Tutors = new List<Tutor>();
            Durations = new List<Duration>();
            Students = new List<Student>();
                
        }

        public List<Instrument> Instruments { get; set; }
        public List<Tutor> Tutors { get; set; }
        public List<Duration> Durations { get; set; }
        public List<Student> Students { get; set; }
    }
}
