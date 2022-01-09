using Eamado.DAL.Entities;
using EAmado.BL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EAmado.WebUI.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        SqlRepo<Menu> repoMenu;
        public HeaderViewComponent(SqlRepo<Menu>_repoMenu)
        {
            repoMenu = _repoMenu;
        }
        public IViewComponentResult Invoke()
        {
            return View(repoMenu.GetAll().OrderBy(o=>o.DisplayIndex));
        }

    }
}
