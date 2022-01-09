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
    public class ProductController : Controller
    {

       
        SqlRepo<Product> repoProduct;

        public ProductController( SqlRepo<Product> _repoProduct)
        {
         

           
            repoProduct = _repoProduct;

        }

        public IActionResult Index()//
        {
            return View();
        }

        [Route("/ALISVERİS/{name}-{id}")]
        public IActionResult Detail(string name,int id)
        {
            //ProductVM productVM = new ProductVM
            //{
              
            //   Products = repoProduct.GetAll().Include(i=>i.ProductPictures)
              
            //   // ProductPicture2 = repoProduct.GetAll().Include(i => i.ProductPictures).OrderBy(i => i.DisplayIdex)


            //};
            return View(repoProduct.GetAll(i=>i.ID==id).Include(i => i.ProductPictures).FirstOrDefault());
           
        }
    }
}
