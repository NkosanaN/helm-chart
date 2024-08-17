using System.ComponentModel.DataAnnotations.Schema;

namespace Docker7;

[Table("Company")]
public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
}
