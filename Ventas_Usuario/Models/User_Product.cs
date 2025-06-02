using System.ComponentModel.DataAnnotations;

namespace User_Sales.Models
{
    public class User_Product
    {

        [Key]
        public int IdUser_Product { get; set; }
        public int IdProduct { get; set; }
        public int IdUser { get; set; }
        public int Quantity { get; set; }
        public User? User { get; set; }
        public Product? Product { get; set; }
    }
}
