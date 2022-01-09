using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamado.DAL.Entities
{
    [Table("Product")]
    public class Product
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Ürün Adı"), StringLength(50), Required(ErrorMessage = "Ürün  adı boşgeçilemez.")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)"), Display(Name = "Ürün Fiyatı")]
        public decimal Price { get; set; }

        [Column(TypeName ="text"),Display(Name ="Detaylar")]
        public string Detail{ get; set; }

        [Display(Name ="Görüntülenme Sayısı")]
        public int DisplayIdex { get; set; }

        public ICollection<ProductPicture> ProductPictures { get; set; }


        public int? BrandID { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
