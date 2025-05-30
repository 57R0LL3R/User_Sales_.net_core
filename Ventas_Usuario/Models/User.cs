
using System.ComponentModel.DataAnnotations;
namespace Ventas_Usuario.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; } = 0;

        public string? Name { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public string? Password { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
