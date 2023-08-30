using Microsoft.EntityFrameworkCore;

namespace OnlineLineExam.Models
{
    public class OnlineDbContext:DbContext
    {
        public OnlineDbContext(DbContextOptions<OnlineDbContext> options):base(options)
        {

        }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ExamResult> ExamResult { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<QandAns> QandAns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.UserName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(50);

            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.UserName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(50);
                entity.Property(e => e.MobileNumber).IsRequired().HasMaxLength(50);
                entity.Property(e => e.CVFileName).HasMaxLength(250);
                entity.Property(e => e.PictureFileName).HasMaxLength(250);
                entity.HasOne(d => d.Groups).WithMany(p => p.Student).HasForeignKey(e => e.GroupsId);
            });
            modelBuilder.Entity<QandAns>(entity =>
            {
                entity.Property(e => e.Questions).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Option1).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Option2).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Option3).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Option4).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Answer).IsRequired();
                entity.HasOne(d => d.Exam).WithMany(p => p.QandAnswers).HasForeignKey(e => e.ExamId).OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<Groups>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(50);
                entity.HasOne(d => d.Users).WithMany(p => p.Groups).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<Exam>(entity =>
            {
                entity.Property(e => e.Title).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Description).HasMaxLength(50);
                entity.HasOne(d => d.Groups).WithMany(p => p.Exams).HasForeignKey(e => e.GroupId).OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<ExamResult>(entity =>
            {
                
                entity.HasOne(d => d.Qns).WithMany(p => p.ExamResults).HasForeignKey(e => e.QansAnsId).OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.Exam).WithMany(p => p.ExamResults).HasForeignKey(e => e.ExamId);
                entity.HasOne(d => d.student).WithMany(p => p.ExamResults).HasForeignKey(e => e.studentId).OnDelete(DeleteBehavior.ClientSetNull);

            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
