using Eamado.DAL.Entities;
using EAmado.BL.Repositories;
using EAmado.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAmado.WebUI.Controllers
{
    public class HomeController : Controller
    {
        SqlRepo<HomePage> repoHomepage;
       
        public HomeController(SqlRepo<HomePage> _repoHomepage)
        {
            repoHomepage = _repoHomepage;


        }
        public IActionResult Index()
        {

            IndexVM indexVM = new IndexVM
            {
                HomePages = repoHomepage.GetAll()
            };
            return View(indexVM);
        }
    }
}
