namespace CDU_Music_Lessons_Application.Models
{
    public class Student_Lesson
    {

        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }


        public int StudentId { get; set; }
        public Student Student { get; set; }

        
    }
}
