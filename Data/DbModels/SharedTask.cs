using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManagement.Data.DbModels;

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
