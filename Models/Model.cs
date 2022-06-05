
using System.ComponentModel.DataAnnotations;

namespace angular_aspcore_bicycle.Models;
public class Model
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(255)]
    public string Name { get; set; } = "";
    public Make Make { get; set; } = new();

}
