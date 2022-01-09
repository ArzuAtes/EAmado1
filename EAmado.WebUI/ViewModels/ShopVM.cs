using Eamado.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAmado.WebUI.ViewModels
{
    public class ShopVM
    {
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<Brand> Brand { get; set; }
        public IEnumerable<Product> ProductPicture1 { get; set; }
        public IEnumerable<Product> ProductPicture2 { get; set; }
        public IEnumerable<Product> products { get; set; }

    }
}
