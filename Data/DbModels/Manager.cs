using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

[PrimaryKey("Id", "UserId")]
[Table("Manager")]
public partial class Manager
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Key]
    [Column("userId")]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Managers")]
    public virtual User User { get; set; } = null!;
}
