using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MusicShop.Models;

namespace MusicShop.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        [HttpGet]
        public ActionResult Index(int? id, string filter)
        {
            if (id == null)
            {
                ViewBag.Tab = "Лидеры продаж";
                ViewBag.Goods = db.Goods;
                //var Products = db.Products.ToList();
                switch (filter)
                {
                    case "priceup":
                        ViewBag.Goods = db.Goods.OrderBy(g => g.price);
                        break;
                    case "pricedown":
                        ViewBag.Goods = db.Goods.OrderByDescending(g => g.price);
                        break;
                    default:
                        ViewBag.Goods = db.Goods;
                    break;
                }
            }
            else {
                
                ViewBag.Goods = db.Goods.Where(g => g.goods_category_id == id);
            
                //var Products = db.Products.ToList();
            }

            return View();

        }

        [HttpGet]
        public ActionResult Search(string search)
        {
            if (!String.IsNullOrEmpty(search))
            {
                if (String.IsNullOrEmpty(search)) return HttpNotFound();
                var products = db.Goods.Where(g => g.name.Contains(search));
                if (!products.Any()) return View("Nosearch");
                ViewBag.Title = "Поиск " + search;
                ViewBag.Goods = products.ToList();
                return View("Index");
            }
            else {
                ViewBag.Goods = db.Goods;
                return View("Index");
            }
        }


        public ActionResult About()
        {
            ViewBag.Tab = null;
            ViewBag.About = "О нас";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Tab = null;
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}