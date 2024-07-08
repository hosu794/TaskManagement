using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

[Keyless]
[Table("SharedTask")]
public partial class SharedTask
{
    [Column("userId")]
    public int UserId { get; set; }

    [Column("Task_id")]
    public int TaskId { get; set; }

    [ForeignKey("TaskId")]
    public virtual Task Task { get; set; } = null!;

    [ForeignKey("UserId")]
    public virtual User User { get; set; } = null!;
}
