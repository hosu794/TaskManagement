using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

[Table("Task")]
public partial class Task
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

    [Column("statusId")]
    public int StatusId { get; set; }

    [ForeignKey("PriorityId")]
    [InverseProperty("Tasks")]
    public virtual Priority Priority { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Tasks")]
    public virtual User User { get; set; } = null!;
}
