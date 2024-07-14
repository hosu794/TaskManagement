using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Data.DbModels;

namespace TaskManagement.Data;

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
            entity.HasKey(e => e.UserId).HasName("Manager_pk");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithOne(p => p.Manager)
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

            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.Users).HasConstraintName("User_Manager");

            entity.HasMany(d => d.SharedTasks).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "SharedTask",
                    r => r.HasOne<TaskTodo>().WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("SharedTask_Task"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("SharedTask_User"),
                    j =>
                    {
                        j.HasKey("UserId", "TaskId").HasName("SharedTask_pk");
                        j.ToTable("SharedTask");
                        j.IndexerProperty<int>("UserId").HasColumnName("userId");
                        j.IndexerProperty<int>("TaskId").HasColumnName("Task_id");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
