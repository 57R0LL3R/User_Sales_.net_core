using Microsoft.AspNetCore.Mvc.Rendering;

namespace User_Sales.Models
{
    public class UserProductViewModel
    {
        public User_Product UserProduct { get; set; } = new User_Product();
        public List<SelectListItem> Usuarios { get; set; } = [];
    }

}
