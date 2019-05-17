using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicShop.Models
{
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        public DateTime date { get; set; }
        public int delivery_id { get; set; } 
        public int payment_id { get; set; } 
        public int status { get; set; }
    }
}