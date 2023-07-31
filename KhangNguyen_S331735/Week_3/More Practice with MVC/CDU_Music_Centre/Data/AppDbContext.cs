using CDU_Music_Lessons_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace CDU_Music_Lessons_Application.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Student_Lesson>().HasKey(am => new
            {
                am.StudentId,
                am.LessonId
            });

            modelBuilder.Entity<Student_Lesson>().HasOne(m => m.Lesson).WithMany(am => am.Students_Lessons).HasForeignKey(m => m.LessonId);

            modelBuilder.Entity<Student_Lesson>().HasOne(m => m.Student).WithMany(am => am.Students_Lessons).HasForeignKey(m => m.StudentId);




            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student_Lesson> Students_Lessons { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Duration> Durations { get; set; }
        public DbSet<Tutor> Tutors { get; set; }

    }
}
