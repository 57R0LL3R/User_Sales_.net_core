
using System.ComponentModel.DataAnnotations;
namespace User_Sales.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        public string? Name { get; set; }

        public string? Brand { get; set; }
        public string? Image_product {  get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
        public List<User_Product> User_Products { get; set; } = new();
    }
}
