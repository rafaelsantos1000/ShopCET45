using Microsoft.AspNetCore.Http;
using ShopCET45.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace ShopCET45.Web.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }

}
