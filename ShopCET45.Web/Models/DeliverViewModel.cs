using System;
using System.ComponentModel.DataAnnotations;

namespace ShopCET45.Web.Models
{
    public class DeliverViewModel
    {

        public int Id { get; set; }


        [Display(Name = "Delivery date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime DeliveryDate { get; set; }
    }
}
