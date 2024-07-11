using Core.Models.Auth;
using Data.DbModels;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Data;

public partial class TaskManagerDbContext : DbContext
{
    public TaskManagerDbContext()
    {
    }

    public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Manager> Managers { get; set; }


    public virtual DbSet<Priority> Priorities { get; set; }

    public virtual DbSet<TaskTodo> TaskTodos { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.UserId }).HasName("Manager_pk");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.User).WithMany(p => p.Managers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Manager_User");
        });

        modelBuilder.Entity<Priority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Priority_pk");
        });

        modelBuilder.Entity<TaskTodo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Task_pk");

            entity.HasOne(d => d.Priority).WithMany(p => p.TaskTodos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Task_Priority");

            entity.HasOne(d => d.User).WithMany(p => p.TaskTodos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Task_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("User_pk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
