
namespace angular_aspcore_bicycle.Models;

public class Model
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public Make Make { get; set; } = new();

}
