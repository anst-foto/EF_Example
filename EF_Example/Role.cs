using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_Example;

[Index(nameof(Name), IsUnique = true)]
[Table("table_roles")]
public class Role
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }

    public List<User> Users { get; set; }
}