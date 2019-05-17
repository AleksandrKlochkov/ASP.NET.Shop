using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MusicShop.Models;

namespace MusicShop.Controllers
{
    public class BasketController : Controller
    {
        DataContext db = new DataContext();
        // GET: Basket
        public ActionResult Index()
        {

            
            // var CartList = new List<IQueryable>();
            // IEnumerable<object> a = new IEnumerable<object>();
            //    List<object> ListCart = new List<object>();

            List<Good> ListCart = new List<Good>();



            //var t = db.Goods.Where(p => p.goods_id == ).ToList();
            //    ListCart.Add(db.Goods.Where(p => p.goods_id == 1).ToList());

            decimal countPrice = 0;

            if (Session["cart"] != null)
                {
                    foreach (var g in Session["cart"] as System.Collections.Generic.Dictionary<int, int>)
                    {
                    // < div > @g.Key + @g.Value </ div >
                    if (g.Key != 0)
                    {
                        ListCart.Add(db.Goods.Where(p => p.goods_id == g.Key).First());
                    }
  
                    }

                foreach (var g in Session["cart"] as System.Collections.Generic.Dictionary<int, int>)
                {
                    foreach (Good pr in (List<Good>)ListCart)
                    {
                        if (g.Key == pr.goods_id)
                        {
                            countPrice += pr.price * g.Value;
                        }

                    }
                }
            }
            
            
           
            Session["countPrice"] = countPrice;


                ViewBag.ListCart = ListCart;
                //IEnumerable<object> en = ListCart;
                //ViewBag.ProductCart = CartList.ToList();

                return View();
        }

        [HttpGet]
        public int AddToCart(int? goodId) {


            //Session["elements"] = element;
            if (goodId != null)
            {
                Dictionary<int, int> cart = Session["cart"] as Dictionary<int, int>;
                if (cart == null) cart = new Dictionary<int, int>();
                int g_id = Convert.ToInt32(goodId);
                
                if (Session["cart"] != null)
                {
                    //если товар существует в корзине
                    try {

                        cart[g_id] += 1;
                        Session["cart"] = cart;


                    } catch {
                        g_id = Convert.ToInt32(goodId);
                        cart.Add(g_id, 1);
                        Session["cart"] = cart;
                    }
                   
                }
                else
                {
                    //еслии в массиве cart нет товара
                    cart[g_id] = 1;

                    Session["cart"] = cart;
                }
            }
            var countList = new List<int>();
        
            int count = 0;
            

            if (Session["cart"] != null)
            {
                
                    foreach (var g in Session["cart"] as System.Collections.Generic.Dictionary<int, int>)
                    {
                        // < div > @g.Key + @g.Value </ div >

                        countList.Add(g.Value);
                    }
                


                foreach (var c in countList) {
                    count += c;
                }
            }


                Session["cart_quantyty"] = count;
            

           
            return count;
        }

        [HttpGet]
        public int DellToProduct(int? goodId)
        {
          var count = 0;
            if (goodId != null)
            {
                Dictionary<int, int> cart = Session["cart"] as Dictionary<int, int>;
                if (cart == null) cart = new Dictionary<int, int>();
                int g_id = Convert.ToInt32(goodId);

                if (Session["cart"] != null)
                {
                        //cart[g_id] = 0;
                        cart.Remove(g_id);

                    Session["cart"] = cart;
                    if (cart.Count <= 0) {
                        Session["cart"] = null;
                    }

                    if (cart.Count != 0)
                    {

                        var countList = new List<int>();
                    
                        foreach (var g in Session["cart"] as System.Collections.Generic.Dictionary<int, int>)
                        {
                            if (g.Key != 0)
                            {
                                // < div > @g.Key + @g.Value </ div >
                                countList.Add(g.Value);
                            }
                        }
                  

                    foreach (var c in countList)
                    {
                        count += c;
                    }
                    }

                    Session["cart_quantyty"] = count;

                }

            }
            count= Convert.ToInt32(Session["cart_quantyty"]);
            return count;
        }

        [HttpGet]
        public ActionResult Order()
        {
            return View();
        }
    }
}