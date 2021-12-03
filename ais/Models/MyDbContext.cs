using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ais.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupSubject> GroupSubjects { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectGrade> SubjectGrades { get; set; }
        public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user id=root;password=rootroot;database=ais_db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(45)
                    .HasColumnName("group_name");
            });

            modelBuilder.Entity<GroupSubject>(entity =>
            {
                entity.ToTable("group_subject");

                entity.HasIndex(e => e.GroupId, "fk_group_subject_group1_idx");

                entity.HasIndex(e => e.TeacherSubjectId, "fk_group_subject_teacher_subject1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.TeacherSubjectId).HasColumnName("teacher_subject_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupSubjects)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_subject_group1");

                entity.HasOne(d => d.TeacherSubject)
                    .WithMany(p => p.GroupSubjects)
                    .HasForeignKey(d => d.TeacherSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_group_subject_teacher_subject1");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("subject");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(45)
                    .HasColumnName("subject_name");
            });

            modelBuilder.Entity<SubjectGrade>(entity =>
            {
                entity.ToTable("subject_grade");

                entity.HasIndex(e => e.TeacherSubjectId, "fk_subject_grade_teacher_subject1_idx");

                entity.HasIndex(e => e.UserId, "fk_subject_grade_user1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.TeacherSubjectId).HasColumnName("teacher_subject_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.TeacherSubject)
                    .WithMany(p => p.SubjectGrades)
                    .HasForeignKey(d => d.TeacherSubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_subject_grade_teacher_subject1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SubjectGrades)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_subject_grade_user1");
            });

            modelBuilder.Entity<TeacherSubject>(entity =>
            {
                entity.ToTable("teacher_subject");

                entity.HasIndex(e => e.SubjectId, "fk_teacher_subject_subject1_idx");

                entity.HasIndex(e => e.UserId, "fk_teacher_subject_user1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_teacher_subject_subject1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_teacher_subject_user1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.GroupId, "fk_user_group1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .HasColumnName("surname");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("fk_user_group1");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("user_role");

                entity.HasIndex(e => e.RoleId, "fk_user_role_role1_idx");

                entity.HasIndex(e => e.UserId, "fk_user_role_user_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.RoleId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("role_id");

                entity.Property(e => e.UserId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_role_role1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_role_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
