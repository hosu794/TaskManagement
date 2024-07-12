using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Data.DbModels;

[Table("Priority")]
public partial class Priority
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [InverseProperty("Priority")]
    public virtual ICollection<TaskTodo> TaskTodos { get; set; } = new List<TaskTodo>();
}
