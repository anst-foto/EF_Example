using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_Example;

[Index(nameof(Name), IsUnique = true)]
[Table("table_users")]
public class User
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("date_of_birth")]
    public DateTime DateOfBirth  { get; set; }

    [Column("role_id")]
    public int RoleId { get; set; }
    public Role Role { get; set; }
}