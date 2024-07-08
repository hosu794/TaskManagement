using Core.Models.Auth;
using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task = Data.Models.Task;

namespace Data;

public partial class TaskManagerDbContext : IdentityDbContext<ApplicationUser>
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

    public virtual DbSet<SharedTask> SharedTasks { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.UserId }).HasName("Manager_pk");

            entity.HasOne(d => d.User).WithMany(p => p.Managers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Manager_User");
        });

        modelBuilder.Entity<Priority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Priority_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SharedTask>(entity =>
        {
            entity.HasOne(d => d.Task).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SharedTask_Task");

            entity.HasOne(d => d.User).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SharedTask_User");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Task_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Priority).WithMany(p => p.Tasks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Task_Priority");

            entity.HasOne(d => d.User).WithMany(p => p.Tasks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Task_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("User_pk");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
