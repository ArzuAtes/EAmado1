using Eamado.DAL.Entities;
using EAmado.BL.Repositories;
using EAmado.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAmado.WebUI.Controllers
{
    public class ShopController : Controller
    {
        SqlRepo<Category> repoCategory;
        SqlRepo<Brand> repoBrand;
        SqlRepo<Product> repoProduct;
       

        public ShopController(SqlRepo<Category> _repoCategory, SqlRepo<Brand> _repoBrand, SqlRepo<Product> _repoProduct)
        {
            repoCategory = _repoCategory;
           
            repoBrand = _repoBrand;
            repoProduct = _repoProduct;

        }



        [Route("/ALISVERIS")]
        public IActionResult Index()
        {
            ShopVM shopVM = new ShopVM
            {
                Category = repoCategory.GetAll(),
                Brand = repoBrand.GetAll(),
                ProductPicture1=repoProduct.GetAll().Include(i=>i.ProductPictures).OrderBy(o=>o.DisplayIdex).Take(6),
                //ProductPicture2 = repoProduct.GetAll().Include(i=>i.ProductPictures).OrderBy(o => Guid.NewGuid()).Take(12)


            };
            return View(shopVM);
        }


    }
}
