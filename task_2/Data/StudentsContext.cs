using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using task_2.Data.Entities;

namespace task_2.Data;

public partial class StudentsContext : DbContext
{
    public StudentsContext()
    {
    }

    public StudentsContext(DbContextOptions<StudentsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudentInfo> StudentInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=students;TrustServerCertificate=True;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentInfo>(entity =>
        {
            entity.HasKey(e => e.Sid);

            entity.ToTable("Student_info");

            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Cgpa)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("CGPA");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
