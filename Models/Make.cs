using System.Collections.ObjectModel;

namespace angular_aspcore_bicycle.Models;

public class Make
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public ICollection<Model> Models { get; set; } = new Collection<Model>();
}
