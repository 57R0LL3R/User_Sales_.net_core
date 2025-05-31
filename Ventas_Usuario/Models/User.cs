
using System.ComponentModel.DataAnnotations;
namespace User_Sales.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; } = 0;

        public string? Name { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public string? Password { get; set; }

        public List<User_Product> User_Products { get; set; } = new();
    }
}
