using System.ComponentModel.DataAnnotations;
namespace quanlykho.Models
{
    public class Product
    {
        [Key] public int Id { get; set; }
        [Required] public string Sku { get; set; }
        [Required] public string Name { get; set; }
    }
}