using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamado.DAL.Entities
{
    [Table("Category")]
    public class Category
    {
        public int ID { get; set; }


        [Column(TypeName = "varchar(50)"), Display(Name = "Kategori Adı"), StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Görüntülenme Sırası")]
        public int DisplayIndex { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
