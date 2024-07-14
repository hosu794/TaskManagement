using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Data.DbModels;

[Table("Manager")]
public partial class Manager
{
    [Key]
    [Column("userId")]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Manager")]
    public virtual User User { get; set; } = null!;

    [InverseProperty("ManagerNavigation")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
