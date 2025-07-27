using System.ComponentModel.DataAnnotations;
namespace quanlykho.Models
{
    public class Supplier
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
    }
}
