
using System.ComponentModel.DataAnnotations;
namespace Ventas_Usuario.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        public string? Name { get; set; }

        public string? Brand { get; set; }

        public string? Price { get; set; }
        public int IdUser { get; set; }

        public User? User { get; set; }
    }
}
