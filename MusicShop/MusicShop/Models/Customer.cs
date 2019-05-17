using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicShop.Models
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string login { get; set; }
        public string password { get; set; }

    }
}