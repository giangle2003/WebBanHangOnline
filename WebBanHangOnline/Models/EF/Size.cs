using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("Size")]
    public class Size
    {
        public Size()
        {
            Size_Colors = new HashSet<Size_Color>();
        }
        [Key]
        public int size_id { get; set; }

        [Column("size")]
        [StringLength(50)]
        public string size { get; set; }


        public virtual ICollection<Size_Color> Size_Colors { get; set; }

    }
}