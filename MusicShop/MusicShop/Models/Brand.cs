using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicShop.Models
{
    public class Brand
    {
        [Key]
        public int brand_id { get; set; }
        public string brand_name { get; set; }
    }
}