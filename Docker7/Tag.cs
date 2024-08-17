using System.ComponentModel.DataAnnotations.Schema;

namespace Docker7;

[Table("Tag")]
public class Tag
{
    public int id { get; set; }
    public string tag { get; set; }
}
