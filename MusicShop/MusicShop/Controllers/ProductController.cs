using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicShop.Models;

namespace MusicShop.Controllers
{
    public class ProductController : Controller
    {
        DataContext db = new DataContext();
        // GET: Product
        [HttpGet]
        public ActionResult Index(int? productId)
        {
            ViewBag.Title = "Продукт";
            ViewBag.VisibleGood = false;
            //   IEnumerable<Good> goods = db.Goods.Where(g => g.goods_id == productId); 
            if (productId != null) {
                var product = db.Goods.Where(g => g.goods_id == productId);
                ViewBag.Good = product;
                // IEnumerable<Good> goods = db.Goods.Where(g => g.goods_id == productId);
                //Good products = db.Goods
                //ViewBag.Good = db.Goods.Where(g => g.goods_id == productId);
                //var name_good = db.Goods.Select(g=>g.name);
                ViewBag.VisibleGood = true;
            }
            //    var goods = db.Goods.Find(productId);
             

            return View();
        }
    }
}