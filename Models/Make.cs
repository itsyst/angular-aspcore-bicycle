using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Bicycle.Models;
public class Make
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(255)]
    public string Name { get; set; } = "";
    public ICollection<Model> Models { get; set; } = new Collection<Model>();
}
