using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicShop.Models
{
    public class Good
    {
        [Key]
        public int goods_id { get; set;}
        public string name { get; set; }
        public string keywords { get; set; }
        public string description { get; set; }
        public string img { get; set; }
        public int goods_brand_id { get; set; }
        public int goods_category_id { get; set; }
        public int goods_subcategory_id { get; set; }
        public string anons { get; set; }
        public string context { get; set; }
        public string characteristic { get; set; }
        public decimal price { get; set; }
        public DateTime date { get; set; }
        public string img_slide { get; set; }
        public string hits { get; set; }
        public int quantity { get; set; }
    }
}