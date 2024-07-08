using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("username")]
    [StringLength(100)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("password")]
    [StringLength(300)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Manager> Managers { get; set; } = new List<Manager>();

    [InverseProperty("User")]
    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
