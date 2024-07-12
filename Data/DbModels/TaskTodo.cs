using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Data.DbModels;

[Table("TaskTodo")]
public partial class TaskTodo
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    [StringLength(100)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column("description", TypeName = "text")]
    public string Description { get; set; } = null!;

    [Column("createdAt", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [Column("updatedAt", TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }

    [Column("userId")]
    public int UserId { get; set; }

    [Column("priorityId")]
    public int PriorityId { get; set; }

    [ForeignKey("PriorityId")]
    [InverseProperty("TaskTodos")]
    public virtual Priority Priority { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("TaskTodos")]
    public virtual User User { get; set; } = null!;

    [ForeignKey("TaskId")]
    [InverseProperty("SharedTasks")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
