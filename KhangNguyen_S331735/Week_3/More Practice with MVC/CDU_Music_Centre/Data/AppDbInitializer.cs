using CDU_Music_Lessons_Application.Models;

namespace CDU_Music_Lessons_Application.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                

                //Duration
                if (!context.Durations.Any())
                {
                    context.Durations.AddRange(new List<Duration>()
                    {
                        new Duration()
                        {
                            DurationTypeAndCost = "30 Minutes for $100 ",
                            DurationDescription = "Please come to the class on time and refer to timetable for room number"
                        },
                        new Duration()
                        {
                            DurationTypeAndCost = "45 Minutes for $170 ",
                            DurationDescription = "Please come to the class on time and refer to timetable for room number"
                        },
                        new Duration()
                        {
                            DurationTypeAndCost = "60 Minutes for $190 ",
                            DurationDescription = "Please come to the class on time and refer to timetable for room number"
                        },

                    });
                    context.SaveChanges();
                }

                //Instrument
                if (!context.Instruments.Any())
                {
                    context.Instruments.AddRange(new List<Instrument>()
                    {
                        new Instrument()
                        {
                            InstrumentName = "Classical Guitar ",
                            InstrumentDescription = "Classical Guitar uses Nylon strings"
                        },
                        new Instrument()
                        {
                           InstrumentName = "Acoustic Guitar ",
                           InstrumentDescription = "Acoustic Guitar uses steel strings"
                        },
                        new Instrument()
                        {
                            InstrumentName = "Concert Grand Piano",
                            InstrumentDescription = "Over 88 keys and 3 pedals for professional performance"
                        },
                        new Instrument()
                        {
                            InstrumentName = "Electronic Piano",
                            InstrumentDescription = "Suitable choice for beginners and children"
                        },
                        new Instrument()
                        {
                            InstrumentName = "Upright Piano",
                            InstrumentDescription = "Standard choice for advanced players to proficient players"
                        },
                        new Instrument()
                        {
                            InstrumentName = "Violin",
                            InstrumentDescription = "A classic Violin style suitable for all ages"
                        },

                    });
                    context.SaveChanges();
                }

                //Tutor
                if (!context.Tutors.Any())
                {
                    context.Tutors.AddRange(new List<Tutor>()
                    {
                        new Tutor()
                        {
                            Tutorname = "Liam Grayson ",
                            TutorDescription = "Expertise for Classical Guitar"
                        },
                        new Tutor()
                        {
                            Tutorname = "Mateo Lucas",
                            TutorDescription = "Expertise for Acoustic Guitar"
                        },
                        new Tutor()
                        {
                            Tutorname = "James Wyatt ",
                            TutorDescription = "Expertise for Concert Grand Piano"
                        },
                        new Tutor()
                        {
                            Tutorname = "Nova Mila ",
                            TutorDescription = "Expertise for Upright Piano"
                        },
                        new Tutor()
                        {
                            Tutorname = "Evelyn Gia",
                            TutorDescription = "Expertise for Electronic Piano"
                        },
                        new Tutor()
                        {
                            Tutorname = "Amelia Asher ",
                            TutorDescription = "Expertise for Violin"
                        },

                    });
                    context.SaveChanges();
                }

                //Student
                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        new Student()
                        {
                            Fname = "Alex ",
                            Lname = "Kourus",
                            Dateofbirth = DateTime.Parse("1989-2-12"),
                            Age = 33,
                            Gender = "Male",
                            Parentname = "Peter Kourus",
                            Email = "AlexKourus@gmail.com",
                            Phonenumber = "046171721223"

                        },
                        new Student()
                        {
                            Fname = "Jack",
                            Lname = "Hughie",
                            Dateofbirth = DateTime.Parse("1999-5-11"),
                            Age = 23,
                            Gender = "Male",
                            Parentname = "Oliver Hughie",
                            Email = "JackHughie@gmail.com",
                            Phonenumber = "067323284812"

                        },
                        new Student()
                        {
                            Fname = "Rickie",
                            Lname = "Wang",
                            Dateofbirth = DateTime.Parse("1995-10-9"),
                            Age = 27,
                            Gender = "Male",
                            Parentname = "Chen Wang",
                            Email = "RickieWang@gmail.com",
                            Phonenumber = "01623723322"

                        },
                        new Student()
                        {
                            Fname = "Sophia",
                            Lname = "Mcdonnal",
                            Dateofbirth = DateTime.Parse("2000-1-2"),
                            Age = 22,
                            Gender = "Female",
                            Parentname = "Stephanie Mcdonnal",
                            Email = "SophiaMcdonnal@gmail.com",
                            Phonenumber = "027178930887"

                        },
                        new Student()
                        {
                            Fname = "Kate",
                            Lname = "Hughman",
                            Dateofbirth = DateTime.Parse("1998-5-11"),
                            Age = 24,
                            Gender = "Female",
                            Parentname = "Jackie Hughman",
                            Email = "KateHughman@gmail.com",
                            Phonenumber = "016849222742"

                        },
                        new Student()
                        {
                            Fname = "Khang",
                            Lname = "Nguyen",
                            Dateofbirth = DateTime.Parse("2001-1-2"),
                            Age = 21,
                            Gender = "Male",
                            Parentname = "Jimmy Nguyen",
                            Email = "KhangNguyen@gmail.com",
                            Phonenumber = "01235894728112"

                        },

                    });
                    context.SaveChanges();
                }

                //Lesson
                if (!context.Lessons.Any())
                {
                    context.Lessons.AddRange(new List<Lesson>()
                    {
                        new Lesson()
                        {
                            LessonName = "Classic Guitar for Solo",
                            LessonDescription = "Practicing Solo with Classical Guitar",
                            TermAndYear = "Term 1 - 2022",
                            LessonDateAndTime = DateTime.Parse("2022-1-12"),
                            InstrumentId = 1,
                            TutorId = 1,
                            DurationId = 2,
                            LessonLevel = Enums.LessonLevel.Beginner,
                            PaymentStatus = "Paid",
                        },
                        new Lesson()
                        {
                            LessonName = "Acoustic Guitar for Singing",
                            LessonDescription = "Practicing Solo and Singing with Acoustic Guitar",
                            TermAndYear = "Term 1 - 2023",
                            LessonDateAndTime = DateTime.Parse("2023-10-2"),
                            InstrumentId = 2,
                            TutorId = 2,
                            DurationId = 3,
                            LessonLevel = Enums.LessonLevel.Advanced,
                            PaymentStatus = "Paid",
                        },
                        new Lesson()
                        {
                            LessonName = "Professional Performance Piano",
                            LessonDescription = "High-level of performance piano with Concert Grand Piano",
                            TermAndYear = "Term 1 - 2022",
                            LessonDateAndTime = DateTime.Parse("2022-1-12"),
                            InstrumentId = 3,
                            TutorId = 3,
                            DurationId = 3,
                            LessonLevel = Enums.LessonLevel.Expert,
                            PaymentStatus = "Paid",
                        },
                        new Lesson()
                        {
                            LessonName = "Beginner Solo with Electronc Piano",
                            LessonDescription = "Practicing Solo and Learn with Electronic Piano",
                            TermAndYear = "Term 2 - 2023",
                            LessonDateAndTime = DateTime.Parse("2023-7-7"),
                            InstrumentId = 4,
                            TutorId = 4,
                            DurationId = 1,
                            LessonLevel = Enums.LessonLevel.Beginner,
                            PaymentStatus = "Paid",
                        },
                        new Lesson()
                        {
                            LessonName = "Advanced Solo and Singing with Piano",
                            LessonDescription = "Practicing Solo and Singing with Upright Piano",
                            TermAndYear = "Term 1 - 2022",
                            LessonDateAndTime = DateTime.Parse("2022-1-12"),
                            InstrumentId = 5,
                            TutorId = 5,
                            DurationId = 2,
                            LessonLevel = Enums.LessonLevel.Advanced,
                            PaymentStatus = "Paid",
                        },
                        new Lesson()
                        {
                            LessonName = "Violin Master Class",
                            LessonDescription = "Learn and Practice Solo with Violin",
                            TermAndYear = "Term 1 - 2022",
                            LessonDateAndTime = DateTime.Parse("2022-1-12"),
                            InstrumentId = 6,
                            TutorId = 6,
                            DurationId = 2,
                            LessonLevel = Enums.LessonLevel.Proficient,
                            PaymentStatus = "Paid",
                        },

                    });
                    context.SaveChanges();
                }


                //Students & Lessons
                if (!context.Students_Lessons.Any())
                {
                    context.Students_Lessons.AddRange(new List<Student_Lesson>()
                    {
                        new Student_Lesson()
                        {
                            LessonId = 1,
                            StudentId = 1
                        },
                        new Student_Lesson()
                        {
                            LessonId = 3,
                            StudentId = 1
                        },
                        new Student_Lesson()
                        {
                            LessonId = 4,
                            StudentId = 1
                        },
                        new Student_Lesson()
                        {
                            LessonId = 2,
                            StudentId = 2
                        },
                        new Student_Lesson()
                        {
                            LessonId = 5,
                            StudentId = 2
                        },
                        new Student_Lesson()
                        {
                            LessonId = 4,
                            StudentId = 3
                        },
                        new Student_Lesson()
                        {
                            LessonId = 6,
                            StudentId = 3
                        },
                        new Student_Lesson()
                        {
                            LessonId = 1,
                            StudentId = 4
                        },
                        new Student_Lesson()
                        {
                            LessonId = 2,
                            StudentId = 4
                        },
                        new Student_Lesson()
                        {
                            LessonId = 3,
                            StudentId = 5
                        },
                        new Student_Lesson()
                        {
                            LessonId = 5,
                            StudentId = 5
                        },
                        new Student_Lesson()
                        {
                            LessonId = 6,
                            StudentId = 6
                        },
                        new Student_Lesson()
                        {
                            LessonId = 1,
                            StudentId = 6
                        },

                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
