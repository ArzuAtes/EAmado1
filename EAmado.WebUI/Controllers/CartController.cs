using Eamado.DAL.Entities;
using EAmado.BL.Repositories;
using EAmado.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAmado.WebUI.Controllers
{
    public class CartController : Controller
    {
        SqlRepo<Product> repoProduct;

        public CartController(SqlRepo<Product> _repoProduct)
        {
            repoProduct = _repoProduct;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("/sepet/ekle"),HttpPost]
        public string AddCart(int productID, int quantity)
        {
            Product product = repoProduct.GetAll(x => x.ID == productID).Include(i=>i.ProductPictures).FirstOrDefault() ?? null;
            if (product != null)
            {
                string picture = product.ProductPictures.FirstOrDefault().PicturePath;
                if (string.IsNullOrEmpty(picture))
                {
                    picture = "/img/bg-img/nopicture";
                }
                List<Cart> carts;
                Cart cart = new Cart
                {
                    ID = productID, Name = product.Name, Price = product.Price, Quantity = quantity, Picture = picture
                };

                if (Request.Cookies["SepetCookie"]==null)
                {
                    carts = new List<Cart>();
                    carts.Add(cart);
                }
                else
                {
                    carts = JsonConvert.DeserializeObject<List<Cart>>(Request.Cookies["SepetCookie"]);
                    bool varmi = false;
                    foreach (Cart Crt in carts)
                    {
                        if (Crt.ID==product.ID)
                        {
                            Crt.Quantity = quantity;
                            varmi = true;
                        }
                       
                    }
                    if (varmi == false) carts.Add(cart);
                   
                }
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("SepetCookie", JsonConvert.SerializeObject(carts), cookieOptions);
                return product.Name+""+ quantity + " "+"Eklendi";
            }
            else return "";

        }

    }
}
