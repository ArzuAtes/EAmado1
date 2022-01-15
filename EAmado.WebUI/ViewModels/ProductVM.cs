using Eamado.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAmado.WebUI.ViewModels
{
    public class ProductVM
    {
        public Product Products{ get; set; }

        public IEnumerable<Product> ProductPicture2 { get; set; }
    }
}
