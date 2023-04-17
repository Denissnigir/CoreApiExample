using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Model;

public partial class ProContext : DbContext
{
    public ProContext()
    {
    }

    public ProContext(DbContextOptions<ProContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=root;Database=pro");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Test>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("test");

            entity.Property(e => e.Huy)
                .HasColumnType("character varying")
                .HasColumnName("huy");
            entity.Property(e => e.Test1)
                .HasColumnType("character varying")
                .HasColumnName("test");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_pk");

            entity.ToTable("user");

            entity.HasIndex(e => e.Id, "user_id_index");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BirthDate)
                .HasColumnType("character varying")
                .HasColumnName("birth_date");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.FirstName)
                .HasColumnType("character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.Login)
                .HasColumnType("character varying")
                .HasColumnName("login");
            entity.Property(e => e.Mail)
                .HasColumnType("character varying")
                .HasColumnName("mail");
            entity.Property(e => e.Note)
                .HasColumnType("character varying")
                .HasColumnName("note");
            entity.Property(e => e.PassportNumber).HasColumnName("passport_number");
            entity.Property(e => e.PassportSeries).HasColumnName("passport_series");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.RoleId)
                .HasColumnType("character varying")
                .HasColumnName("role_id");
            entity.Property(e => e.SecondName)
                .HasColumnType("character varying")
                .HasColumnName("second_name");
            entity.Property(e => e.ThirdName)
                .HasColumnType("character varying")
                .HasColumnName("third_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
