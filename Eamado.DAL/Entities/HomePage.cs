using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamado.DAL.Entities
{
    [Table("HomePage")]
   public class HomePage
    {
        public int ID { get; set; }


        [Column(TypeName = "varchar(50)"), Display(Name = "Resim Kategori Adı"), StringLength(50), Required(ErrorMessage = "Resim kategorisi adı boş geçilemez")]
        public string Name { get; set; }


        [Column(TypeName = "varchar(150)"), Display(Name = "Resim Dosyası"), StringLength(150)]
        public string Picture { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Ürün Linki"), StringLength(150)]
        public string Link { get; set; }

        [Column(TypeName = "decimal(18,2)"), Display(Name = "Ürün Fiyatı")]
        public decimal Price { get; set; }

        [Display(Name = "Görüntülenme Sırası")]
        public int DisplayIndex { get; set; }
    }
}
