using System.ComponentModel.DataAnnotations;

namespace API.Entity;

public class Temp
{
    [Key]
    public int Id { get; set; }
    public  string? Name  {get ; set ; }  

}
