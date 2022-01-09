using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamado.DAL.Entities
{
    [Table("ProductPicture")]
    public class ProductPicture
    {
        public int ID { get; set; }

        [Column(TypeName ="varchar(150)"),Display(Name ="Resim yolu"),StringLength(150)]
        public string PicturePath{ get; set; }

        [Display(Name ="Görüntülenme Sayısı")]
        public int DisplayIdex { get; set; }

        [Display(Name ="Bağlı olduğu ürün")]
        public int ProductID{ get; set; }
        public Product Product { get; set; }

    }
}
