using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DoctorManagement.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DoctorDetail> DoctorDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-D8R39Q7\\SQLEXPRESS2019;Database=DB_Clinical_Management_System;User ID=sa;Password=Kedar1234@;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoctorDetail>(entity =>
        {
            entity.HasKey(e => e.DoctorId);

            entity.ToTable("Doctor_Details");

            entity.Property(e => e.DoctorId).HasColumnName("Doctor_Id");
            entity.Property(e => e.AaddharNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aaddhar_No");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("Email_ID");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Full_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Mobile_No1");
            entity.Property(e => e.MobileNo2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsSparse()
                .HasColumnName("Mobile_No2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
