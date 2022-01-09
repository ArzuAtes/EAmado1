using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eamado.DAL.Entities
{
    [Table ("Menu")]
   public class Menu
    {
        public int ID{ get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Menu Adı"), StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Görüntülenme Sırası")]
        public int DisplayIndex { get; set; }


    }
}
