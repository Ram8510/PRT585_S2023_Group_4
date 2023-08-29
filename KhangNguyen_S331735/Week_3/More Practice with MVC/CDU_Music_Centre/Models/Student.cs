using CDU_Music_Lessons_Application.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace CDU_Music_Lessons_Application.Models
{
    public class Student:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string Fname { get; set; }

        [Display(Name = "Last Name")]
        public string Lname { get; set; }

        [Display(Name = "DOB")]
        public DateTime Dateofbirth { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Parent Name")]
        public string Parentname { get; set; }

        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string Phonenumber { get; set; }

        //Relationships
        public List<Student_Lesson> Students_Lessons { get; set; }


    }
}
